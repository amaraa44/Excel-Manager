using System.Windows.Forms;

namespace Excel_Manager.ProgBar
{
    public class MyProgressBar
    {
        private readonly ProgressBar _progBar;

        public MyProgressBar(ProgressBar progBar)
        {
            _progBar = progBar;
            _progBar.Value = 0;
        }

        public int Value
        {
            get => _progBar.Value;
            set => _progBar.Value = value;
        }

        public bool Increase(int step)
        {
            if (step > 0 && Value + step > _progBar.Maximum)
                return false;
            _progBar.Increment(step);
            return true;
        }

        public bool Decrease(int step)
        {
            if (step > 0 && Value - step < _progBar.Minimum)
            {
                return false;
            }
            _progBar.Increment(-step);
            return true;
        }

        public int CalcSteps(int numberOfSteps, int maximum)
        {
            var diff = maximum - _progBar.Value;
            var step = diff / numberOfSteps;

            return step;
        }

        public void CatchUp()
        {
            _progBar.Value = _progBar.Maximum;
        }
    }
}