using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel_Manager.Exports.Excels;

namespace Excel_Manager.Exports.Export
{
    class Export : IExport
    {

        public Export()
        {
        }

        public List<string> nevekList(MyExcel nevek, int sor, int oszlop)
        {
            List<string> list = new List<string>();

            int utolsoSor = sor;
            int currentSor = sor;
            while (!String.IsNullOrEmpty((string)(nevek.WS.Cells[currentSor, oszlop] as Microsoft.Office.Interop.Excel.Range).Value))
            {
                currentSor++;
                utolsoSor++;
            }
            //Microsoft.Office.Interop.Excel.Range usedRange = nevek.WS.UsedRange;
            //utolsoSor = usedRange.Rows.Count + 1;

            for(int i = sor; i < utolsoSor; i++)
            {
                list.Add((string)(nevek.WS.Cells[i, oszlop] as Microsoft.Office.Interop.Excel.Range).Value);
            }
            return list;
        }

        public Boolean ExportIt(List<string> list, MyExcel berlap, string mentesPath, int sor, int oszlop)
        {
            if(list.Count != 0)
            {
                foreach(string nev in list)
                {
                    (berlap.WS.Cells[sor, oszlop] as Microsoft.Office.Interop.Excel.Range).Value = nev;
                    berlap.WB.SaveAs(mentesPath + "/" + nev + ".xlsx");
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
