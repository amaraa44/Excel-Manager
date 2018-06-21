using System;
using System.Windows.Forms;

namespace Excel_Manager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnApplyClick(object sender, EventArgs e)
        {
            var nevO = (int)(nevekOszlop.Value);
            var nevS = (int)(nevekSor.Value);

            var blapO = (int)(berlapOszlop.Value);
            var blapS = (int)(berlapSor.Value);

            if(nevO <= 0 || nevS <= 0 || blapO <= 0 || blapS <= 0)
            {
                MessageBox.Show("Az egyik érték kisebb vagy egyenlő mint nulla!\nNulla vagy negatív értékű cellák nincsenek az Excelben!");
            }
            
            Form1.NevekOszlop = nevO;
            Form1.NevekSor = nevS;

            Form1.BerlapOszlop = blapO;
            Form1.BerlapSor = blapS;

            this.Close();
        }
    }
}
