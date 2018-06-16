using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Excel_Manager.ProgBar
{

    public class MyProgressBar
    {
        private ProgressBar progBar;

        public MyProgressBar(ProgressBar _progBar)
        {
            progBar = _progBar;
            progBar.Value = 0;
        }

        public int Value { get => progBar.Value; set => progBar.Value = value; }

        public bool Increase(int step)
        {
            if((step > 0) && ((Value + step) > progBar.Maximum))
            {
                return false;
            }
            else
            {
                progBar.Increment(step);
                return true;
            }
        }

        public bool Decrease(int step)
        {
            if((step > 0) && ((Value - step) < progBar.Minimum))
            {
                return false;
            }
            else
            {
                progBar.Increment(-step);
                return true;
            }
        }

        public int CalcSteps(int numberOfSteps, int maximum)
        {
            int step = 0;

            int diff = maximum - progBar.Value;
            step = diff / numberOfSteps;

            return step;
        }

        public void CatchUp()
        {
            progBar.Value = progBar.Maximum;
        }
    }
}