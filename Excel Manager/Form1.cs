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
        private string metesPath;

        public Form1()
        {
            InitializeComponent();
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
                    metesPath = fbd.SelectedPath;
                }
            }
            catch (IOException error)
            {
                MessageBox.Show("Hiba kód: 3\n" + error.Message.ToString());
            }


        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar.Value = 0;
                //MessageBox.Show(berlapPath + "\n" + nevekPath + "\n" + metesPath);

                //Berlap
                Excel.Application berlapExcel = new Excel.Application();
                Excel.Workbook berlap = berlapExcel.Workbooks.Open(berlapPath);
                Excel.Worksheet berlapSheet = berlapExcel.ActiveSheet as Excel.Worksheet;


                progressBar.Value = 5;
                //Nevek
                Excel.Application nevekExcel = new Excel.Application();
                Excel.Workbook nevek = nevekExcel.Workbooks.Open(nevekPath);
                Excel.Worksheet nevekSheet = nevekExcel.ActiveSheet as Excel.Worksheet;

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
                        Directory.CreateDirectory(metesPath + "/" + dirName.Text);
                        metesPath = metesPath + "/" + dirName.Text;
                    }
                    
                }


                //Nevek szama
                Excel.Range usedRange = nevekSheet.UsedRange;
                int nevekSzama = usedRange.Rows.Count;

                progressBar.Value = 15;

            
                for(int i = 1; i <= nevekSzama; i++)
                {
                    //Aktuális név kiszedése az excelből
                    string actualNev = (string)(nevekSheet.Cells[i, 1] as Excel.Range).Value;

                    //Aktuális név berakása az excelbe
                    (berlapSheet.Cells[1, 1] as Excel.Range).Value = actualNev;

                    //Mentés as
                    berlap.SaveAs(metesPath + "/" + actualNev + ".xlsx");

                    progressBar.Value = progressBar.Value + 75 / nevekSzama;
                }
                //MessageBox.Show(progressBar.Value.ToString());

                //Close berlap
                berlap.Close();
                berlapExcel.Quit();
                Marshal.ReleaseComObject(berlapExcel);
                Marshal.ReleaseComObject(berlapSheet);
                Marshal.ReleaseComObject(berlap);

                progressBar.Value += 5;

               //Close nevek
                nevek.Close();
                nevekExcel.Quit();
                Marshal.ReleaseComObject(nevekExcel);
                Marshal.ReleaseComObject(nevekSheet);
                Marshal.ReleaseComObject(nevek);

                progressBar.Value += 5;

                //Finish
                //MessageBox.Show(progressBar.Value.ToString());
                progressBar.Value = 100;
                MessageBox.Show("Kész van!");
            }
            catch (IOException error)
            {
                MessageBox.Show("Hiba kód: 4\n" + error.Message.ToString());
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
    }
}
