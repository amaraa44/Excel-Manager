using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Excel_Manager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nevO = (int)(nevekOszlop.Value);
            int nevS = (int)(nevekSor.Value);

            int blapO = (int)(berlapOszlop.Value);
            int blapS = (int)(berlapSor.Value);

            if(nevO <= 0 || nevS <= 0 || blapO <= 0 || blapS <= 0)
            {
                MessageBox.Show("Az egyik érték kisebb vagy egyenlő mint nulla!\nNulla vagy negatív értékű cellák nincsenek az Excelben!");
            }
            
            Form1.nevekOszlop = nevO;
            Form1.nevekSor = nevS;

            Form1.berlapOszlop = blapO;
            Form1.berlapSor = blapS;

            this.Close();
        }
    }
}
