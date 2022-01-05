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
    class ViewStatistics : View
    {
        private FrmStatistics frm;

        public ViewStatistics (Model model, Controller controller, FrmStatistics frm) :base(model, controller)
        {
            this.frm = frm;
        }

        public override void DataBind()
        {
            frm.TbCommonTime.DataBindings.Add(new Binding("Text", model.statistics, "CommonTime"));
            frm.TbCommonTurnAroundTime.DataBindings.Add(new Binding("Text", model.statistics, "CommonTurnAroundTime"));
            frm.TbCommonWaitingTime.DataBindings.Add(new Binding("Text", model.statistics, "CommonWaitingTime"));
            frm.TbCompletedProc.DataBindings.Add(new Binding("Text", model.statistics, "TerminatedProcessesCount"));
            frm.TbCpuTime.DataBindings.Add(new Binding("Text", model.statistics, "CpuTime"));
            frm.TbMaxReadyQueueLength.DataBindings.Add(new Binding("Text", model.statistics, "MaxReadyQueueLength"));
            frm.TbRejectedProc.DataBindings.Add(new Binding("Text", model.statistics, "RejectedProcessesCount"));
            frm.TbArrivalProc.DataBindings.Add(new Binding("Text", model.statistics, "ArrivalProcessesCount"));
            frm.TbCpuUtilization.DataBindings.Add(new Binding("Text", model.statistics, "CpuUtilization"));
            frm.TbSystemPerformance.DataBindings.Add(new Binding("Text", model.statistics, "SystemPerformance"));
            frm.TbAvgWaitingTime.DataBindings.Add(new Binding("Text", model.statistics, "AvgWaitingTime"));
            frm.TbAvgTurnAroundTime.DataBindings.Add(new Binding("Text", model.statistics, "AvgTurnAroundTime"));
            frm.TbAvgReadyQueueLength.DataBindings.Add(new Binding("Text", model.statistics, "AvgReadyQueueLength"));
        }

        public override void DataUnbind()
        {
            frm.TbArrivalProc.DataBindings.RemoveAt(0);
            frm.TbCommonTime.DataBindings.RemoveAt(0);
            frm.TbCommonTurnAroundTime.DataBindings.RemoveAt(0);
            frm.TbCommonWaitingTime.DataBindings.RemoveAt(0);
            frm.TbCompletedProc.DataBindings.RemoveAt(0);
            frm.TbCpuTime.DataBindings.RemoveAt(0);
            frm.TbMaxReadyQueueLength.DataBindings.RemoveAt(0);
            frm.TbRejectedProc.DataBindings.RemoveAt(0);
            frm.TbCpuUtilization.DataBindings.RemoveAt(0);
            frm.TbSystemPerformance.DataBindings.RemoveAt(0);
            frm.TbAvgWaitingTime.DataBindings.RemoveAt(0);
            frm.TbAvgTurnAroundTime.DataBindings.RemoveAt(0);
            frm.TbAvgReadyQueueLength.DataBindings.RemoveAt(0);
        }
    }
}
