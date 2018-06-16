using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Manager
{
    public abstract class Dialog
    {
        public string Path{ get; set; }

        public virtual void Open() { }
    }
}