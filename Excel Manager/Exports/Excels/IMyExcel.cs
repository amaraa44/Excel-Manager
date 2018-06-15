using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Excel = Microsoft.Office.Interop.Excel;

namespace Excel_Manager.Exports.Excels
{
    interface IMyExcel
    {
        Excel.Application App { get; set; }
        Excel.Workbook WB { get; set; }
        Excel.Worksheet WS { get; set; }

        void Open(string path);



        void Close();

    }
}
