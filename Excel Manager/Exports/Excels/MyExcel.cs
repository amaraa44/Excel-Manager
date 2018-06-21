using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Excel_Manager.Exports.Excels
{
    class MyExcel
    {

        public Excel.Application App { get; set; }
        public Excel.Workbook WB { get; set; }
        public Excel.Worksheet WS { get; set; }

        public void Open(string path)
        {

            App = new Excel.Application();
            WB = App.Workbooks.Open(path);
            WS = App.ActiveSheet as Excel.Worksheet;

        }

        public void Close()
        {
            WB.Close();
            App.Quit();
            Marshal.ReleaseComObject(WS);
            Marshal.ReleaseComObject(WB);
            Marshal.ReleaseComObject(App);
        }
    }
}
