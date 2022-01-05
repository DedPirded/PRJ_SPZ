using Queues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MVCFrame
{
    class ViewDetailed: View
    {
        public ViewDetailed(Model model, Controller controller, FrmDetailed frm) : base(model, controller)
        {
            this.frm = frm;
        }
        public override void DataBind()
        {
            frm.LblTime.DataBindings.Add(new Binding("Text", model.Clock, "Clock"));

            frm.TbCPU.DataBindings.Add(new Binding("Text", model.Cpu, "ActiveProcess"));

            frm.TbDevice.DataBindings.Add(new Binding("Text", model.Device, "ActiveProcess"));

            frm.TbDevice_2.DataBindings.Add(new Binding("Text", model.Device_2, "ActiveProcess"));

            frm.LblOccupateMemSize.DataBindings.Add(new Binding("Text", model.Ram, "OccupiedSize"));

            frm.LblFreeMemSize.DataBindings.Add(new Binding("Text", model.Ram, "FreeSize"));

            Binding intestityBinding = new Binding("Value", model.ModelSettings, "Intensity");
            intestityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudIntesity.DataBindings.Add(intestityBinding);

            Binding minValueOfBurstTimeBinding = new Binding("Value", model.ModelSettings, "MinValueOfBurstTime");
            minValueOfBurstTimeBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudMinValueOfBurstTime.DataBindings.Add(minValueOfBurstTimeBinding);

            Binding maxValueOfBurstTimeBinding = new Binding("Value", model.ModelSettings, "MaxValueOfBurstTime");
            maxValueOfBurstTimeBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudMaxValueOfBurstTime.DataBindings.Add(maxValueOfBurstTimeBinding);

            Binding minValueOfAddrSpaceBinding = new Binding("Value", model.ModelSettings, "MinValueOfAddrSpace");
            minValueOfAddrSpaceBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudMinValueOfAddrSpace.DataBindings.Add(minValueOfAddrSpaceBinding);

            Binding maxValueOfAddrSpaceBinding = new Binding("Value", model.ModelSettings, "MaxValueOfAddrSpace");
            maxValueOfAddrSpaceBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudMaxValueOfAddrSpace.DataBindings.Add(maxValueOfAddrSpaceBinding);

            Binding valueOfRAMSizeBindings = new Binding("SelectedItem", model.ModelSettings, "ValueOfRAMSize", true);
            valueOfRAMSizeBindings.ControlUpdateMode = ControlUpdateMode.Never;
            frm.CbRamSize.DataBindings.Add(valueOfRAMSizeBindings);

            Subscribe();
        }

        public override void DataUnbind()
        {
            frm.NudIntesity.DataBindings.RemoveAt(0);
            frm.NudMinValueOfBurstTime.DataBindings.RemoveAt(0);
            frm.NudMaxValueOfBurstTime.DataBindings.RemoveAt(0);
            frm.NudMinValueOfAddrSpace.DataBindings.RemoveAt(0);
            frm.NudMaxValueOfAddrSpace.DataBindings.RemoveAt(0);
            frm.CbRamSize.DataBindings.RemoveAt(0);

            Unsubscribe();
        }
        private void Subscribe()
        {
            model.PropertyChanged += PropertyChangedHandler;
        }

        private void Unsubscribe()
        {
            model.PropertyChanged -= PropertyChangedHandler;
        }

        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ReadyQueue")
            {
                SortedUnsorterQueue<Process> temp = (SortedUnsorterQueue <Process>)model.ReadyQueue;
                updateListBox(temp.Sorted, frm.LblSortedCPUQueue);
                updateListBox(temp.Unsorted, frm.LblUnsortedCPUQueue);
            }             
            else
            {
                updateListBox(model.DeviceQueue, frm.LblDeviceQueue);
                updateListBox(model.DeviceQueue_2, frm.LblDeviceQueue_2);
            }                       
        }
        private void updateListBox(IQueueable<Process> queue, ListBox lb)
        {
            lb.Items.Clear();
            if(queue.Count != 0)
                lb.Items.AddRange(queue.ToArray());
        }
        private FrmDetailed frm;
    }
}
