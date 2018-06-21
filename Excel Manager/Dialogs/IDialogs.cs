using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Excel_Manager.Dialogs
{
    interface IDialogs
    {
        string Path { get; set; }

        //Open file and set the path param.
        void Open();
    }
}
