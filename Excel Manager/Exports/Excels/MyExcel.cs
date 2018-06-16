using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace Excel_Manager.Exports.Excels
{
    class MyExcel
    {
        public MyExcel()
        {
        }

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
