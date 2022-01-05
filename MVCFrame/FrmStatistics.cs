using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCFrame
{
    partial class FrmStatistics : Form
    {

        public ViewStatistics viewStatistic;
        public FrmStatistics()
        {
            InitializeComponent();
        }

        public FrmStatistics (Model model)
        {
            InitializeComponent();
            viewStatistic = new ViewStatistics(model, null, this);
            viewStatistic.DataBind();
        }



        public TextBox TbCommonTime
        {
            get
            {
                return tbCommonTime;
            }
        }

        public TextBox TbArrivalProc
        {
            get
            {
                return tbArrivalProc;
            }
        }

        public TextBox TbCompletedProc
        {
            get
            {
                return tbCompletedProc;
            }
        }

        public TextBox TbRejectedProc
        {
            get
            {
                return tbRejectedProc;
            }
        }
        public TextBox TbCommonTurnAroundTime
        {
            get
            {
                return tbCommonTurnAroundTime;
            }
        }

        public TextBox TbCommonWaitingTime
        {
            get
            {
                return tbCommonWaitingTime;
            }
        }

        public TextBox TbCpuTime
        {
            get
            {
                return tbCpuTime;
            }
        }

        public TextBox TbMaxReadyQueueLength
        {
            get
            {
                return tbMaxReadyQueueLength;
            }
        }

        public TextBox TbCpuUtilization
        {
            get
            {
                return tbCpuUtilization;
            }
        }

        public TextBox TbSystemPerformance
        {
            get
            {
                return tbSystemPerfomance;
            }
        }

        public TextBox TbAvgWaitingTime
        {
            get
            {
                return tbAvgWaitingTime;
            }
        }

        public TextBox TbAvgTurnAroundTime
        {
            get
            {
                return tbAvgTurnAroundTime;
            }
        }

        public TextBox TbAvgReadyQueueLength
        {
            get
            {
                return tbAvgReadyQueueLength;
            }
        }
        
        private void FrmStatistics_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
