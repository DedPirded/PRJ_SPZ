using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrame
{
    class Controller        
    {        
        public void Execute(ModelOperations operation, Model model, Settings settings = null)
        {
            if (model == null)
                throw new ArgumentNullException("Empty model");
            switch (operation)
            {
                case ModelOperations.SaveSettings:                    
                    model.SaveSettings();
                    break;
                case ModelOperations.WorkingCycle:
                    model.WorkingCycle();
                    break;
                case ModelOperations.Clear:
                    model.Clear();
                    break;
                default:
                    throw new ArgumentException(
                        "Неизвестная операция: " + operation, "operation");
            }
        }
    }
}
