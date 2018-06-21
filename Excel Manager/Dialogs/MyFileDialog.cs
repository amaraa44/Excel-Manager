using System.IO;
using System.Windows.Forms;

namespace Excel_Manager.Dialogs
{
    class MyFileDialog : IDialogs
    {

        private string _filter;

        public string Path { get; set; }

        public MyFileDialog(string filter)
        {
            _filter = filter;
        }

        public void Open()
        {
            try
            {
                var ofd = new OpenFileDialog {Filter = _filter};

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Path = ofd.FileName;
                }
            }
            catch(IOException error)
            {
                MessageBox.Show("Hiba kód: 1.1\n" + error.Message);
            }
        }
    }
}