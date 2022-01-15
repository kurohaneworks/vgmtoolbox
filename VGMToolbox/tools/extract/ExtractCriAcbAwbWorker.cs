using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
//using System.Linq;
using System.Text;

using VGMToolbox.format;
using VGMToolbox.plugin;
using VGMToolbox.util;

namespace VGMToolbox.tools.extract
{
    class ExtractCriAcbAwbWorker : AVgmtDragAndDropWorker, IVgmtBackgroundWorker
    {
        public struct ExtractCriAcbAwbStruct : IVgmtWorkerStruct
        {
            public string[] SourcePaths { set; get; }
            public bool IncludeCueIdInFileName { set; get; }
        }

        public ExtractCriAcbAwbWorker() :
            base() { }

        protected override void DoTaskForFile(string pPath, IVgmtWorkerStruct pExtractStruct, DoWorkEventArgs e)
        {
            ExtractCriAcbAwbStruct extractStruct = (ExtractCriAcbAwbStruct)pExtractStruct;
            byte[] magicBytes;
            long awbOffset = 0;

            using (FileStream fs = File.Open(pPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                magicBytes = ParseFile.ParseSimpleOffset(fs, 0, 4);

                this.progressStruct.Clear();

                // ACB
                if (ParseFile.CompareSegment(magicBytes, 0, CriAcbFile.SIGNATURE_BYTES))
                {
                    this.progressStruct.GenericMessage = String.Format("Processing ACB file: '{0}'.{1}", Path.GetFileName(pPath), Environment.NewLine);
                    ReportProgress(Constants.ProgressMessageOnly, this.progressStruct);

                    CriAcbFile acb = new CriAcbFile(fs, 0, extractStruct.IncludeCueIdInFileName);
                    acb.ExtractAll();

                    string key = null;

                    if (acb.ExternalAwb != null && acb.ExternalAwb.SubKey != 0x0)
                    {
                        key = acb.ExternalAwb.SubKey.ToString("X4");
                    }
                    else if (acb.InternalAwb != null && acb.InternalAwb.SubKey != 0x0)
                    {
                        key = acb.InternalAwb.SubKey.ToString("X4");
                    }

                    if (key != null)
                    {
                        this.progressStruct.GenericMessage = String.Format("AWB SubKey: 0x{0}.{1}", key, Environment.NewLine);
                        ReportProgress(Constants.ProgressMessageOnly, this.progressStruct);
                    }
                }
                else if (ParseFile.CompareSegment(magicBytes, 0, CriAfs2Archive.SIGNATURE))
                {
                    this.progressStruct.GenericMessage = String.Format("Processing AWB file: '{0}'.{1}", Path.GetFileName(pPath), Environment.NewLine);
                    ReportProgress(Constants.ProgressMessageOnly, this.progressStruct);

                    CriAfs2Archive afs2 = new CriAfs2Archive(fs, 0);
                    afs2.ExtractAll();

                    if (afs2.SubKey != 0x0)
                    {
                        this.progressStruct.GenericMessage = String.Format("AWB SubKey: 0x{0}.{1}", afs2.SubKey.ToString("X4"), Environment.NewLine);
                        ReportProgress(Constants.ProgressMessageOnly, this.progressStruct);
                    }
                }
                else
                {
                    this.progressStruct.GenericMessage = String.Format("ACB/AWB signature not found at offset 0...scanning for AWB signature: '{0}'.{1}", Path.GetFileName(pPath), Environment.NewLine);
                    ReportProgress(Constants.ProgressMessageOnly, this.progressStruct);

                    awbOffset = ParseFile.GetNextOffset(fs, 0, CriAfs2Archive.SIGNATURE);

                    if (awbOffset > 0)
                    {
                        CriAfs2Archive afs2 = new CriAfs2Archive(fs, awbOffset);
                        afs2.ExtractAll();                    
                    }
                    else
                    {
                        this.progressStruct.GenericMessage = String.Format("File is not an ACB or AWB...skipping: '{0}'.{1}", Path.GetFileName(pPath), Environment.NewLine);
                        ReportProgress(Constants.ProgressMessageOnly, this.progressStruct);
                    }
                }
            }            
        }        
    }
}
