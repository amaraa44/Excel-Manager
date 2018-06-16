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
using Excel_Manager.Dialogs;
using Excel_Manager.Exports.Excels;
using Excel_Manager.Exports.Export;
using Excel_Manager.ProgBar;

namespace Excel_Manager
{
    public partial class Form1 : Form
    {
        private string berlapPath;
        private string nevekPath;
        private string mentesPath;
        private List<String> _nevekList;

        public static int nevekSor = 1;
        public static int nevekOszlop = 1;
        public static int berlapSor = 1;
        public static int berlapOszlop = 1;

        public static String printerName;

        //TODO: ProgressBar and make nicer the printing.

        public Form1()
        {
            InitializeComponent();
        }

        private void berlapFileDialogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MyFileDialog myFileDialog = new MyFileDialog("Excel|*.xlsx");

                myFileDialog.open();

                berlapFDTxtBox.Text = myFileDialog.Path;
                berlapPath = myFileDialog.Path;
            }catch(IOException error)
            {
                MessageBox.Show("Hiba kód: 1\n" + error.Message.ToString());
            }
            
        }

        private void nevekFileDialogBtn_Click(object sender, EventArgs e)
        {
            try {

                MyFileDialog myFileDialog = new MyFileDialog("Excel|*.xlsx");

                myFileDialog.open();

                nevekFDTxtBox.Text = myFileDialog.Path;
                nevekPath = myFileDialog.Path;  
            }
            catch(IOException error)
            {
                MessageBox.Show("Hiba kód: 2\n" + error.Message.ToString());
            }
        }
     
        private void mentesFileDialogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MyFolderDialog myFolderDialog = new MyFolderDialog();

                myFolderDialog.open();

                mentesFDTxtBox.Text = myFolderDialog.Path;
                mentesPath = myFolderDialog.Path;
            }
            catch (IOException error)
            {
                MessageBox.Show("Hiba kód: 3\n" + error.Message.ToString());
            }
        }

        private MyExcel berlap;
        private MyExcel nevek;
        private void startBtn_Click(object sender, EventArgs e)
        {
            if(nevekPath == null || mentesPath == null || berlapPath == null)
            {
                MessageBox.Show("Add meg az útvonalakat. \n(Bérlap helye, nevek helye, mentés helye)");
                return;
            }



            try
            {

                MyProgressBar progBar = new MyProgressBar(progressBar);

                //Berlap
                berlap = new MyExcel();
                berlap.Open(berlapPath);

                progBar.Increase(5);

                //Nevek
                nevek = new MyExcel();
                nevek.Open(nevekPath);

                progBar.Increase(5);

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

                progBar.Increase(5);
                Export export = new Export(progBar);
                List<string> nevekList = export.nevekList(nevek, nevekSor, nevekOszlop);

                progBar.Increase(10);

                if (export.ExportIt(nevekList, berlap, mentesPath, berlapSor, berlapOszlop))
                {
                    progBar.CatchUp();

                    MessageBox.Show("Kész!");

                    printBtn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Valami nem oké!");
                }                
            }
            catch (IOException error)
            {
                MessageBox.Show("Hiba kód: 4\n" + error.Message.ToString());
            }
            finally
            {
                //Close berlap
                berlap.Close();

                //Close nevek
                nevek.Close();
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

            if(_nevekList.Count == 0)
            {
                MessageBox.Show("Nem tudok mit nyomtatni.");
                return;
            }

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
                for (int i = 0; i < _nevekList.Count; i++)
                {
                    printExcel = new Excel.Application();
                    printWB = printExcel.Workbooks.Open(mentesPath + "/" + _nevekList[i] + ".xlsx");
                    printWS = printExcel.ActiveSheet as Excel.Worksheet;


                    printWB.PrintOutEx(Type.Missing, Type.Missing, Type.Missing, printPreview, printerName, false, false, Type.Missing, false);

                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    nyomtatProgBar.Value = nyomtatProgBar.Value + (100 / _nevekList.Count );
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
