using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVCFrame
{
    abstract class View: IDisposable
    {
        public View(Model model, Controller controller)
        {
            this.model = model;
            this.controller = controller;
        }

        public readonly  Model model;
        public Controller controller
        {
            private get;
            set;            
        }
        public void ReactToUserActions(ModelOperations modelOperation, Settings settings = null)
		{
            controller.Execute(modelOperation, model);
        }
        public void Dispose()
        {
            DataUnbind();
        }
        abstract public void DataBind();
        abstract public void DataUnbind();
    }
}
