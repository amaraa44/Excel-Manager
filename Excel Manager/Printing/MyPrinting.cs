using Excel_Manager.Exports.Excels;
using System;

namespace Excel_Manager.Printing
{
    class MyPrinting
    {

        private MyExcel _excel;
        private string _printerName;

        public MyPrinting(MyExcel excel, string printerName)
        {
            _excel = excel;
            _printerName = printerName;
        }

        public void PrintIt()
        {

            _excel.WB.PrintOutEx(Type.Missing, Type.Missing, Type.Missing, false, _printerName, false, false, Type.Missing, false);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            _excel.Close();
        }

    }
}
