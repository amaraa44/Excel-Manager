using System.IO;
using System.Windows.Forms;

namespace Excel_Manager.Dialogs
{
    class MyFileDialog : Dialog
    {

        private string _filter;

        public MyFileDialog(string filter)
        {
            _filter = filter;
        }

        public override void Open()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = _filter;

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