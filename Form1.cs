using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.IO;


namespace InventurUpdater
{
    public partial class frmInventurUpdater : Form
    {
        Excel.Application oXL;
        Excel._Workbook oWB;
        Excel._Worksheet oSheet;

        string pathNr = System.AppContext.BaseDirectory + "STI-Inventur-ArtikelNr_Datenbank.xml";
        System.Data.DataTable dtNr;
        DataSet dsNr;

        public frmInventurUpdater()
        {
            InitializeComponent();
        }

        private void frmInventurUpdater_Load(object sender, EventArgs e)
        {
            openFileDialogExcel.InitialDirectory = System.AppContext.BaseDirectory;
            Open_NrDB();
        }




        private void Open_NrDB()
        {
            try
            {
            dsNr = new DataSet("Root");

            if (File.Exists(pathNr))
            {
                dsNr.ReadXml(pathNr, XmlReadMode.ReadSchema);
                dtNr = dsNr.Tables[0];
            }
            else
            {
                dtNr = new System.Data.DataTable("dt");

                dtNr.Columns.Add("ArtikelNr", typeof(string));
                dtNr.Columns.Add("LfdNr", typeof(int));
                dsNr.Tables.Add(dtNr);
            }
            grdNr.DataSource = dtNr;

            grdNr.Columns["ArtikelNr"].Width = 203;
            grdNr.Columns["LfdNr"].Width = 80;
            }
            catch (Exception theException)
            {
                string errorMessage = String.Concat(theException.Message, theException.Source);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Save_NrDB()
        {
            try
            {
                if (dsNr != null)
                    dsNr.WriteXml(pathNr, XmlWriteMode.WriteSchema);
            }
            catch (Exception theException)
            {
                string errorMessage = String.Concat(theException.Message, theException.Source);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void ButOpenInvList_Click(object sender, EventArgs e)
        {


            try
            {

                if (openFileDialogExcel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    edInvListe.Text = openFileDialogExcel.FileName;

                    //Start Excel and get Application object.
                    oXL = new Excel.Application();
                    oXL.Visible = true;

                    // Datei öffnen und aktives Blatt und benutzten Bereich auswählen
                    oWB = oXL.Workbooks.Open(openFileDialogExcel.FileName);
                    oSheet = (Excel._Worksheet)oWB.ActiveSheet;
                }
            }
            catch (Exception theException)
            {
                string errorMessage = String.Concat(theException.Message, theException.Source);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Int32 getLfdNr(string ArtNr)
        {
            Int32 LfdNr = 0;
            try
            {

                // ArtikelNr suchen
                DataRow[] rows = dtNr.Select("ArtikelNr='" + ArtNr + "'");

                // ArtikelNr existiert in der Liste: dessen laufende Nummer zurückgeben.
                if (rows.Length > 0)
                {
                    LfdNr = (Int32)rows[0][1];
                }

                // Artikelnummer fehlt in der Liste: neuen Artikel einfügen mit der nächste freien laufenden Nummer.
                else
                {
                    // Höchste laufende Nummer ermitteln
                    int maxLfdNr = 0;
                    if (dtNr.Rows.Count > 0)
                    {
                        maxLfdNr = (int)dtNr.Compute("MAX([LfdNr])", "");
                    }
                    LfdNr = maxLfdNr + 1;

                    // Neuen Eintrag einfügen
                    DataRow newRow = dtNr.NewRow();
                    newRow[0] = ArtNr;
                    newRow[1] = LfdNr;
                    dtNr.Rows.Add(newRow);
                }

                return LfdNr;
            }
            catch (Exception theException)
            {
                string errorMessage = String.Concat(theException.Message, theException.Source);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return LfdNr;
            }
        }

        private void butInvListSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (oSheet != null)
                {
                    oXL.ActiveWorkbook.Save();
                    oXL.ActiveWorkbook.Close(true);
                    oSheet = null;
                    oXL.Quit();
                }
            }

            catch (Exception theException)
            {
                string errorMessage = String.Concat(theException.Message, theException.Source);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butAssignNum_Click(object sender, EventArgs e)
        {
            string artNr;
            Int32 lfdNr;

            try
            {
                if (oSheet == null)
                {
                    MessageBox.Show("Bitte vorher eine Inventurliste öffnen!", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    Cursor = Cursors.WaitCursor;
                 
                    int zeileVon = int.Parse(edStartZeile.Text);
                    int zeileBis = oSheet.UsedRange.Rows.Count;

                    progressBar.Minimum = zeileVon;
                    progressBar.Maximum = zeileBis;
                    progressBar.Value = zeileVon;
                    progressBar.Visible = true;

                    int spalteArtNr = int.Parse(edArtSpalte.Text);
                    int spalteLfdNr = int.Parse(edNrSpalte.Text);

                    oSheet.Cells[8, 3].Value = "Laufende Nr";

                    for (int i = zeileVon; i <= zeileBis; i++)
                    {
                        artNr = oSheet.Cells[i, spalteArtNr].Value;
                        if ((artNr != null) & (artNr != ""))
                        {
                            lfdNr = getLfdNr(artNr);
                            oSheet.Cells[i, spalteLfdNr].Value = lfdNr;
                        }
                        progressBar.PerformStep();
                    }

                    Save_NrDB();
                    progressBar.Visible = false;
                }
            }
            catch (Exception theException)
            {
                Cursor = Cursors.Default;
                string errorMessage = String.Concat(theException.Message, theException.Source);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                progressBar.Visible = false;
            }
        }
    }

}
