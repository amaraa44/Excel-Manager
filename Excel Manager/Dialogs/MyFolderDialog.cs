using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Excel_Manager.Dialogs
{
    class MyFolderDialog : IDialogs
    {

        public string Path { get; set; }

        public void open()
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
