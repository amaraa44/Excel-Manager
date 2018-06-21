using Excel_Manager.Dialogs;
using Excel_Manager.Exports.Excels;
using Excel_Manager.Exports.Export;
using Excel_Manager.Printing;
using Excel_Manager.ProgBar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Excel_Manager
{
    public partial class Form1 : Form
    {
        private string _berlapPath;
        private string _nevekPath;
        private string _mentesPath;
        private List<String> _nevekList;

        public static int NevekSor = 1;
        public static int NevekOszlop = 1;
        public static int BerlapSor = 1;
        public static int BerlapOszlop = 1;

        public static String PrinterName;

        public Form1()
        {
            InitializeComponent();
        }

        private void BerlapFileDialogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MyFileDialog myFileDialog = new MyFileDialog("Excel|*.xlsx");

                myFileDialog.Open();

                berlapFDTxtBox.Text = myFileDialog.Path;
                _berlapPath = myFileDialog.Path;
            }catch(IOException error)
            {
                MessageBox.Show("Hiba kód: 1\n" + error.Message);
            }
            
        }

        private void NevekFileDialogBtn_Click(object sender, EventArgs e)
        {
            try {

                MyFileDialog myFileDialog = new MyFileDialog("Excel|*.xlsx");

                myFileDialog.Open();

                nevekFDTxtBox.Text = myFileDialog.Path;
                _nevekPath = myFileDialog.Path;  
            }
            catch(IOException error)
            {
                MessageBox.Show("Hiba kód: 2\n" + error.Message);
            }
        }
     
        private void MentesFileDialogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MyFolderDialog myFolderDialog = new MyFolderDialog();

                myFolderDialog.Open();

                mentesFDTxtBox.Text = myFolderDialog.Path;
                _mentesPath = myFolderDialog.Path;
            }
            catch (IOException error)
            {
                MessageBox.Show("Hiba kód: 3\n" + error.Message);
            }
        }

        private MyExcel _berlap;
        private MyExcel _nevek;
        private void StartBtn_Click(object sender, EventArgs e)
        {

            if (_berlapPath == null && berlapFDTxtBox != null)
            {
                _berlapPath = berlapFDTxtBox.Text;
            }

            if (_nevekPath == null && nevekFDTxtBox != null)
            {
                _nevekPath = nevekFDTxtBox.Text;
            }

            if (_mentesPath == null && mentesFDTxtBox != null)
            {
                _mentesPath = mentesFDTxtBox.Text;
            }

            if(_nevekPath == null || _mentesPath == null || _berlapPath == null)
            {
                MessageBox.Show("Add meg az útvonalakat. \n(Bérlap helye, nevek helye, mentés helye)");
                return;
            }

            try
            {

                var progBar = new MyProgressBar(progressBar);

                //Berlap
                _berlap = new MyExcel();
                _berlap.Open(_berlapPath);

                progBar.Increase(5);

                //Nevek
                _nevek = new MyExcel();
                _nevek.Open(_nevekPath);

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
                        Directory.CreateDirectory(_mentesPath + "/" + dirName.Text);
                        _mentesPath = _mentesPath + "/" + dirName.Text;
                    }
                    
                }

                progBar.Increase(5);
                var export = new Export(progBar);
                var nevekList = export.NevekList(_nevek, NevekSor, NevekOszlop);
                _nevekList = nevekList;

                progBar.Increase(10);

                if (export.ExportIt(nevekList, _berlap, _mentesPath, BerlapSor, BerlapOszlop))
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
                MessageBox.Show("Hiba kód: 4\n" + error.Message);
            }
            finally
            {
                //Close berlap
                _berlap.Close();

                //Close nevek
                _nevek.Close();
            }
            
        }

        private void MentesMappabaCheckBox_CheckedChanged(object sender, EventArgs e)
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
                MessageBox.Show("Hiba kód: 5\n" + error.Message);
            }

            
        }

        private void CustomSettingsBtn_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }


        private MyExcel _printExcel;

        private System.Drawing.Printing.PrinterSettings _printerSettings;


        //PRINTING
        private void BtnPrint(object sender, EventArgs e)
        {

            var progBar = new MyProgressBar(nyomtatProgBar) {Value = 0};


            if(_nevekList.Count == 0)
            {
                MessageBox.Show("Nem tudok mit nyomtatni.");
                return;
            }

            try
            {
                
                if(PrinterName == "")
                {
                    _printerSettings = new System.Drawing.Printing.PrinterSettings();
                    PrinterName = _printerSettings.PrinterName;
                }
                
            }
            catch
            {
                MessageBox.Show("Nem található nyomtató.");
                return;
            }

            progBar.Increase(5);


            try
            {
                foreach (string nev in _nevekList)
                {
                    _printExcel = new MyExcel();
                    _printExcel.Open(_mentesPath + "/" + nev + ".xlsx");

                    var print = new MyPrinting(_printExcel, PrinterName);
                    print.PrintIt();


                    var step = progBar.CalcSteps(_nevekList.Count, 95);
                    progBar.Increase(step);
                }
            }
            catch (IOException error)
            {
                _printExcel.Close();

                MessageBox.Show("Hiba kód: 6\n" + error.Message);
            }
            finally
            {
                progBar.CatchUp();
            }
        }

        private void BtnPrinterSetting(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
