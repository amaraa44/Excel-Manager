using System;
using System.Windows.Forms;

namespace Excel_Manager
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                listBox1.Items.Add(printer);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form1.PrinterName = listBox1.SelectedItem.ToString();
            this.Close();
        }
    }
}
