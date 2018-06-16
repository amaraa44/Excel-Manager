using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Excel_Manager.Dialogs
{
    class MyFolderDialog : Dialog
    {


        public override void Open()
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();

                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    Path = fbd.SelectedPath;
                }
            }catch(IOException error)
            {
                MessageBox.Show("Hiba kód: 1.2\n" + error.Message.ToString());
            }
        }
    }
}
