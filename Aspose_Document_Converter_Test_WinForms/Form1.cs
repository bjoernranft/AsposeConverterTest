using Aspose.Words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtensionMethods;
using System.IO;
using Aspose.Words.Saving;

namespace Aspose_Document_Converter_Test_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Dictionary<int, string> comboItems = new Dictionary<int, string>();
            comboItems.Add(0, "ODT's TO DOCX's");
            comboItems.Add(1, "ODT's TO PDF's");
            comboItems.Add(2, "DOCX's TO ODT's");
            comboItems.Add(3, "DOCX's TO PDF's");

            convertTypesCombobox.DisplayMember = "Value";
            convertTypesCombobox.ValueMember = "Key";
            convertTypesCombobox.DataSource = new BindingSource(comboItems, null);
        }

        private void openSrcDocButton_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            
            String[] srcDocumentPath = null;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;

            int selectedFormat = ((KeyValuePair<int, string>)convertTypesCombobox.SelectedItem).Key;
            if (selectedFormat == 0 || selectedFormat == 1)
            {
                fileDialog.Filter = "ODT Documents|*.odt";
            } else
            {
                fileDialog.Filter = "DOCX Documents|*.docx";
            }

            string srcDirectoryPath = String.Empty;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                srcDocumentPath = fileDialog.FileNames;
                srcDirectoryPath = Path.GetDirectoryName(fileDialog.FileNames[0]);
                progressBar1.Maximum = fileDialog.FileNames.Length;
            }

            if (srcDocumentPath.IsNullOrEmpty())
                return;

            List<Document> docs = new List<Document>();

            foreach (String docPath in srcDocumentPath) {
                docs.Add(new Document(docPath));
            }

            this.convertDocuments(docs, srcDirectoryPath, selectedFormat);
        }

        private void convertDocuments(List<Document> docs, String directoryPath, int selectedFormat)
        {
            foreach(Document doc in docs)
            {
                Aspose.Words.SaveFormat saveFormat = SaveFormat.Unknown;
                string filetype = string.Empty; 

                if (selectedFormat == 0)
                {
                    saveFormat = Aspose.Words.SaveFormat.Docx;
                    filetype = ".docx";
                } else if (selectedFormat == 1 || selectedFormat == 3)
                {
                    saveFormat = Aspose.Words.SaveFormat.Pdf;
                    filetype = ".pdf";
                } else if (selectedFormat == 2)
                {
                    saveFormat = Aspose.Words.SaveFormat.Odt;
                    filetype = ".odt";
                } else
                {
                    //
                }

                //workaround..wenn 'doc.OriginalFileName' = 'datei.odt' könnte eigentlich nur durch Angabe anhand von 'saveFormat' 'datei.odt.docx' werden, speichert dann aber nicht, daher
                //originale dateiendung entfernen und ziel-endung setzen
                string filenameWithoutExtension = doc.OriginalFileName.Substring(0, doc.OriginalFileName.LastIndexOf('.'));
                doc.Save(filenameWithoutExtension + filetype, saveFormat);
                progressBar1.Value += 1;
            }
        }
    }
}
