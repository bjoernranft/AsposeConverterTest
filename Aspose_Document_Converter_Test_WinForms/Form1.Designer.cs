namespace Aspose_Document_Converter_Test_WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.openSrcDocButton = new System.Windows.Forms.Button();
            this.convertTypesCombobox = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // openSrcDocButton
            // 
            this.openSrcDocButton.Location = new System.Drawing.Point(265, 69);
            this.openSrcDocButton.Name = "openSrcDocButton";
            this.openSrcDocButton.Size = new System.Drawing.Size(149, 45);
            this.openSrcDocButton.TabIndex = 0;
            this.openSrcDocButton.Text = "Dokument(e) laden";
            this.openSrcDocButton.UseVisualStyleBackColor = true;
            this.openSrcDocButton.Click += new System.EventHandler(this.openSrcDocButton_Click);
            // 
            // convertTypesCombobox
            // 
            this.convertTypesCombobox.FormattingEnabled = true;
            this.convertTypesCombobox.Location = new System.Drawing.Point(118, 93);
            this.convertTypesCombobox.Name = "convertTypesCombobox";
            this.convertTypesCombobox.Size = new System.Drawing.Size(121, 21);
            this.convertTypesCombobox.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(118, 243);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(434, 125);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Es können mehrere Dokumente über den FileDialog ausgewählt werden, Dokumente müss" +
    "en in einem gemeinsamen Verzeichnis liegen.  Die konvertierten Dokumente werden " +
    "im selben Verzeichnis gespeichert.";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(118, 144);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(434, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.convertTypesCombobox);
            this.Controls.Add(this.openSrcDocButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openSrcDocButton;
        private System.Windows.Forms.ComboBox convertTypesCombobox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

