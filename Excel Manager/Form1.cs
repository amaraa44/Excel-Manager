using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;

namespace Excel_Manager
{
    public partial class Form1 : Form
    {
        private string berlapPath;
        private string nevekPath;
        private string mentesPath;
        private List<String> nevekList;

        public static int nevekSor = 1;
        public static int nevekOszlop = 1;
        public static int berlapSor = 1;
        public static int berlapOszlop = 1;

        public static String printerName;



        public Form1()
        {
            InitializeComponent();
        }
        public void setNevekSor(int i)
        {
            nevekSor = i;
        }

        private void berlapFileDialogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Filter = "Excel|*.xlsx";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    berlapFDTxtBox.Text = ofd.FileName;
                    berlapPath = ofd.FileName;
                }
            }catch(IOException error)
            {
                MessageBox.Show("Hiba kód: 1\n" + error.Message.ToString());
            }
            
        }

        private void nevekFileDialogBtn_Click(object sender, EventArgs e)
        {
            try {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Filter = "Excel|*.xlsx";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    nevekFDTxtBox.Text = ofd.FileName;
                    nevekPath = ofd.FileName;
                }
            } catch (IOException error)
            {
                MessageBox.Show("Hiba kód: 2\n" + error.Message.ToString());
            }


        }

        private void mentesFileDialogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();

                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    mentesFDTxtBox.Text = fbd.SelectedPath;
                    mentesPath = fbd.SelectedPath;
                }
            }
            catch (IOException error)
            {
                MessageBox.Show("Hiba kód: 3\n" + error.Message.ToString());
            }


        }


        private Excel.Application berlapExcel;
        private Excel.Workbook berlap;
        private Excel.Worksheet berlapSheet;

        private Excel.Application nevekExcel;
        private Excel.Workbook nevek;
        private Excel.Worksheet nevekSheet;
        private void startBtn_Click(object sender, EventArgs e)
        {
            if(nevekPath == null || mentesPath == null || berlapPath == null)
            {
                //MessageBox.Show(nevekOszlop.ToString());

                MessageBox.Show("Add meg az útvonalakat. \n(Bérlap helye, nevek helye, mentés helye)");
                return;
            }

            

            try
            {
                
                progressBar.Value = 0;
                //MessageBox.Show(berlapPath + "\n" + nevekPath + "\n" + metesPath);

                //Berlap
                berlapExcel = new Excel.Application();
                berlap = berlapExcel.Workbooks.Open(berlapPath);
                berlapSheet = berlapExcel.ActiveSheet as Excel.Worksheet;


                progressBar.Value = 5;
                //Nevek
                nevekExcel = new Excel.Application();
                nevek = nevekExcel.Workbooks.Open(nevekPath);
                nevekSheet = nevekExcel.ActiveSheet as Excel.Worksheet;

                progressBar.Value = 10;

                //Mappa készítés
                if (mentesMappabaCheckBox.Checked)
                {
                    if (dirName.Text == "")
                    {
                        MessageBox.Show("Adj nevet a mappának!");
                    }
                    else
                    {
                        Directory.CreateDirectory(mentesPath + "/" + dirName.Text);
                        mentesPath = mentesPath + "/" + dirName.Text;
                    }
                    
                }


                //Nevek szama
                Excel.Range usedRange = nevekSheet.UsedRange;
                int nevekSzama = usedRange.Rows.Count;

                int sorokSzama = 0;
                int nevS = nevekSor;
                while(!String.IsNullOrEmpty((string)(nevekSheet.Cells[nevS, nevekOszlop] as Excel.Range).Value)){
                    sorokSzama++;
                    nevS++;
                }
                //MessageBox.Show(sorokSzama.ToString());

                progressBar.Value = 15;

                //MessageBox.Show(nevS.ToString());
                int utolsoSor = nevS;

                nevekList = new List<String>();
                for (int i = nevekSor; i < utolsoSor; i++)
                {
                    //Aktuális név kiszedése az excelből
                    string actualNev = (string)(nevekSheet.Cells[i, nevekOszlop] as Excel.Range).Value;

                    //Aktuális név berakása az excelbe
                    nevekList.Add(actualNev);
                    (berlapSheet.Cells[berlapSor, berlapOszlop] as Excel.Range).Value = actualNev;

                    //Mentés as
                    berlap.SaveAs(mentesPath + "/" + actualNev + ".xlsx");

                    progressBar.Value = progressBar.Value + 75 / nevekSzama;
                }
                //MessageBox.Show(progressBar.Value.ToString());



                progressBar.Value += 5;

                //Finish
                //MessageBox.Show(progressBar.Value.ToString());
                progressBar.Value = 100;
                MessageBox.Show("Kész van!");
                //MessageBox.Show(nevekList[0]);

                printBtn.Enabled = true;
            }
            catch (IOException error)
            {
                MessageBox.Show("Hiba kód: 4\n" + error.Message.ToString());
            }
            finally
            {
                //Close berlap
                berlap.Close();
                berlapExcel.Quit();
                Marshal.ReleaseComObject(berlapExcel);
                Marshal.ReleaseComObject(berlapSheet);
                Marshal.ReleaseComObject(berlap);

                //progressBar.Value += 5;

                //Close nevek
                nevek.Close();
                nevekExcel.Quit();
                Marshal.ReleaseComObject(nevekExcel);
                Marshal.ReleaseComObject(nevekSheet);
                Marshal.ReleaseComObject(nevek);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mentesMappabaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (mentesMappabaCheckBox.Checked)
                {
                    dirName.Enabled = true;
                }
                else
                {
                    dirName.Enabled = false;
                }
            }
            catch (IOException error)
            {
                MessageBox.Show("Hiba kód: 5\n" + error.Message.ToString());
            }

            
        }

        private void customSettingsBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }


        private bool printPreview = false;

        private Excel.Application printExcel;
        private Excel.Workbook printWB;
        private Excel.Worksheet printWS;

        private System.Drawing.Printing.PrinterSettings printerSettings;


        private void button1_Click(object sender, EventArgs e)
        {
            nyomtatProgBar.Value = 0;

            try
            {
                
                if(printerName == "")
                {
                    printerSettings = new System.Drawing.Printing.PrinterSettings();
                    printerName = printerSettings.PrinterName;
                }
                
            }
            catch
            {
                MessageBox.Show("Nem található nyomtató.");
                return;
            }
            
            


            try
            {
                for (int i = 0; i < nevekList.Count; i++)
                {
                    printExcel = new Excel.Application();
                    printWB = printExcel.Workbooks.Open(mentesPath + "/" + nevekList[i] + ".xlsx");
                    printWS = printExcel.ActiveSheet as Excel.Worksheet;


                    printWB.PrintOutEx(Type.Missing, Type.Missing, Type.Missing, printPreview, printerName, false, false, Type.Missing, false);

                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    nyomtatProgBar.Value = nyomtatProgBar.Value + (100 / nevekList.Count );
                }
            }
            catch(IOException error)
            {
                MessageBox.Show("Hiba kód: 6\n" + error.Message.ToString());
            }
            finally
            {
                Marshal.FinalReleaseComObject(printWS);

                printWB.Close();
                Marshal.FinalReleaseComObject(printWB);

                printExcel.Quit();
                Marshal.FinalReleaseComObject(printExcel);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
