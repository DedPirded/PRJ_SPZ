using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrame
{
    public class NewEventArgs : EventArgs
    {
        public int DeviceNumber
        {
            get;
            set;
        }
    }
}
