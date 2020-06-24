namespace InventurUpdater
{
    partial class frmInventurUpdater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventurUpdater));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.butOpenInvList = new System.Windows.Forms.Button();
            this.openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.edInvListe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edStartZeile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edArtSpalte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edNrSpalte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butAssignNum = new System.Windows.Forms.Button();
            this.butInvListSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grdNr = new System.Windows.Forms.DataGridView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNr)).BeginInit();
            this.SuspendLayout();
            // 
            // butOpenInvList
            // 
            this.butOpenInvList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOpenInvList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butOpenInvList.Location = new System.Drawing.Point(13, 18);
            this.butOpenInvList.Margin = new System.Windows.Forms.Padding(4);
            this.butOpenInvList.Name = "butOpenInvList";
            this.butOpenInvList.Size = new System.Drawing.Size(269, 35);
            this.butOpenInvList.TabIndex = 0;
            this.butOpenInvList.Text = "1) Inventurliste öffnen";
            this.butOpenInvList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butOpenInvList.UseVisualStyleBackColor = true;
            this.butOpenInvList.Click += new System.EventHandler(this.ButOpenInvList_Click);
            // 
            // openFileDialogExcel
            // 
            this.openFileDialogExcel.DefaultExt = "xlsx";
            this.openFileDialogExcel.Filter = "Excel files (*.xlsx)|*.xlsx";
            this.openFileDialogExcel.Title = "Inventurliste auswählen";
            // 
            // edInvListe
            // 
            this.edInvListe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edInvListe.Location = new System.Drawing.Point(453, 42);
            this.edInvListe.Name = "edInvListe";
            this.edInvListe.ReadOnly = true;
            this.edInvListe.Size = new System.Drawing.Size(751, 23);
            this.edInvListe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventur Liste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Artikel ab Zeile";
            // 
            // edStartZeile
            // 
            this.edStartZeile.Location = new System.Drawing.Point(445, 133);
            this.edStartZeile.Name = "edStartZeile";
            this.edStartZeile.Size = new System.Drawing.Size(19, 23);
            this.edStartZeile.TabIndex = 4;
            this.edStartZeile.Text = "9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(887, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "1) Alle zu bearbeitenden Inventurlisten in das gleiche Verzeichnis wie dieses Pro" +
    "gramm kopieren und danach eine nach der anderen öffnen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(547, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "2) Jeder ArtikelNr, die nicht in der Liste unten steht, eine laufenden Nummer zuo" +
    "dnen";
            // 
            // edArtSpalte
            // 
            this.edArtSpalte.Location = new System.Drawing.Point(650, 133);
            this.edArtSpalte.Name = "edArtSpalte";
            this.edArtSpalte.Size = new System.Drawing.Size(19, 23);
            this.edArtSpalte.TabIndex = 8;
            this.edArtSpalte.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "ArtikelNr ist in Spalte";
            // 
            // edNrSpalte
            // 
            this.edNrSpalte.Location = new System.Drawing.Point(931, 133);
            this.edNrSpalte.Name = "edNrSpalte";
            this.edNrSpalte.Size = new System.Drawing.Size(19, 23);
            this.edNrSpalte.TabIndex = 10;
            this.edNrSpalte.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(719, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Spalte für fortlaufende Nummer";
            // 
            // butAssignNum
            // 
            this.butAssignNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAssignNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butAssignNum.Location = new System.Drawing.Point(13, 105);
            this.butAssignNum.Margin = new System.Windows.Forms.Padding(4);
            this.butAssignNum.Name = "butAssignNum";
            this.butAssignNum.Size = new System.Drawing.Size(269, 36);
            this.butAssignNum.TabIndex = 11;
            this.butAssignNum.Text = "2) Laufende Nummer zuordnen";
            this.butAssignNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butAssignNum.UseVisualStyleBackColor = true;
            this.butAssignNum.Click += new System.EventHandler(this.butAssignNum_Click);
            // 
            // butInvListSave
            // 
            this.butInvListSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butInvListSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInvListSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butInvListSave.Location = new System.Drawing.Point(13, 480);
            this.butInvListSave.Margin = new System.Windows.Forms.Padding(4);
            this.butInvListSave.Name = "butInvListSave";
            this.butInvListSave.Size = new System.Drawing.Size(269, 35);
            this.butInvListSave.TabIndex = 12;
            this.butInvListSave.Text = "3) Inventurliste speichern";
            this.butInvListSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butInvListSave.UseVisualStyleBackColor = true;
            this.butInvListSave.Click += new System.EventHandler(this.butInvListSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(696, 467);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // grdNr
            // 
            this.grdNr.AllowUserToAddRows = false;
            this.grdNr.AllowUserToDeleteRows = false;
            this.grdNr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdNr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdNr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdNr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNr.Location = new System.Drawing.Point(306, 176);
            this.grdNr.Name = "grdNr";
            this.grdNr.ReadOnly = true;
            this.grdNr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdNr.Size = new System.Drawing.Size(343, 339);
            this.grdNr.TabIndex = 16;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(306, 521);
            this.progressBar.Minimum = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(343, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 17;
            this.progressBar.UseWaitCursor = true;
            this.progressBar.Value = 1;
            this.progressBar.Visible = false;
            // 
            // frmInventurUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 554);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.grdNr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butInvListSave);
            this.Controls.Add(this.butAssignNum);
            this.Controls.Add(this.edNrSpalte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edArtSpalte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edStartZeile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edInvListe);
            this.Controls.Add(this.butOpenInvList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInventurUpdater";
            this.Text = "STI - Datenbank der Inventur Artikel";
            this.Load += new System.EventHandler(this.frmInventurUpdater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butOpenInvList;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcel;
        private System.Windows.Forms.TextBox edInvListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edStartZeile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edArtSpalte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edNrSpalte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butAssignNum;
        private System.Windows.Forms.Button butInvListSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView grdNr;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

