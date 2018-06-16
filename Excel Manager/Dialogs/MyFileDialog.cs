using System.IO;
using System.Windows.Forms;

namespace Excel_Manager.Dialogs
{
    class MyFileDialog : IDialogs
    {

        private string filter;

        public string Path { get; set; }

        public MyFileDialog(string _filter)
        {
            filter = _filter;
        }

        public void open()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = filter;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Path = ofd.FileName;
                }
            }
            catch(IOException error)
            {
                MessageBox.Show("Hiba kód: 1.1\n" + error.Message.ToString());
            }
        }
    }
}