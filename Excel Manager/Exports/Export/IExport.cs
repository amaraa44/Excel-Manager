using Excel_Manager.Exports.Excels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Manager.Exports.Export
{
    interface IExport
    {

        List<string> nevekList(MyExcel nevek, int sor, int oszlop);

        Boolean ExportIt(List<string> nevekList, MyExcel berlap, string mentesPath, int sor, int oszlop);

    }
}
