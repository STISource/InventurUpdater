namespace InventurUpdater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.butSelectFile = new System.Windows.Forms.Button();
            this.openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.edInvListe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butSelectFile
            // 
            this.butSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSelectFile.Location = new System.Drawing.Point(925, 13);
            this.butSelectFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butSelectFile.Name = "butSelectFile";
            this.butSelectFile.Size = new System.Drawing.Size(237, 35);
            this.butSelectFile.TabIndex = 0;
            this.butSelectFile.Text = "(1) Inventurliste auswählen";
            this.butSelectFile.UseVisualStyleBackColor = true;
            this.butSelectFile.Click += new System.EventHandler(this.ButSelectFile_Click);
            // 
            // openFileDialogExcel
            // 
            this.openFileDialogExcel.DefaultExt = "xlsx";
            this.openFileDialogExcel.InitialDirectory = "K:\\88 EDV\\Programmierung\\SourceCode\\InventurUpdater\\DATA";
            this.openFileDialogExcel.Title = "Inventurliste auswählen";
            // 
            // edInvListe
            // 
            this.edInvListe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edInvListe.Location = new System.Drawing.Point(103, 19);
            this.edInvListe.Name = "edInvListe";
            this.edInvListe.ReadOnly = true;
            this.edInvListe.Size = new System.Drawing.Size(789, 23);
            this.edInvListe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Invetur Liste";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edInvListe);
            this.Controls.Add(this.butSelectFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "STI Invetur Artikel Katalog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcel;
        private System.Windows.Forms.TextBox edInvListe;
        private System.Windows.Forms.Label label1;
    }
}

