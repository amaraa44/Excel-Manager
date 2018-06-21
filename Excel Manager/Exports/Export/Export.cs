using Excel_Manager.Exports.Excels;
using Excel_Manager.ProgBar;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;

namespace Excel_Manager.Exports.Export
{
    class Export
    {
        private MyProgressBar _progBar;

        public Export()
        {
        }

        public Export(MyProgressBar progBar)
        {
            _progBar = progBar;
        }

        public List<string> NevekList(MyExcel nevek, int sor, int oszlop)
        {
            var list = new List<string>();

            var utolsoSor = sor;
            var currentSor = sor;
            while (!string.IsNullOrEmpty((string) ((Range) nevek.WS.Cells[currentSor, oszlop]).Value))
            {
                currentSor++;
                utolsoSor++;
            }
            //Microsoft.Office.Interop.Excel.Range usedRange = nevek.WS.UsedRange;
            //utolsoSor = usedRange.Rows.Count + 1;

            for (int i = sor; i < utolsoSor; i++)
            {
                list.Add((string) ((Range) nevek.WS.Cells[i, oszlop]).Value);
            }
            return list;
        }

        public bool ExportIt(List<string> list, MyExcel berlap, string mentesPath, int sor, int oszlop)
        {
            if (list.Count == 0) return false;
            foreach (var nev in list)
            {
                ((Range) berlap.WS.Cells[sor, oszlop]).Value = nev;
                berlap.WB.SaveAs(mentesPath + "/" + nev + ".xlsx");
                var step = _progBar.CalcSteps(nev.Length, 95);
                _progBar.Increase(step);
            }

            return true;
        }
    }
}