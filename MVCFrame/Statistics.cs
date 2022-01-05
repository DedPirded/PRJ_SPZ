using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace MVCFrame
{
    class Statistics: INotifyPropertyChanged
    {
     

        public long CommonTime
        {
            get
            {
                return commonTime;
            }
            set
            {
                commonTime = value;
                CpuUtilization = (double)(commonTime - cpuIdleTime) / commonTime;
                SystemPerformance = (double)terminatedProcessesCount / commonTime;
                OnPropertyChanged();
            }
        }
        public long ArrivalProcessesCount
        {
            get
            {
                return arrivalProcessesCount;
            }
            set
            {
                arrivalProcessesCount = value;
                OnPropertyChanged();
            }
        }
        public long RejectedProcessesCount
        {
            get
            {
                return rejectedProcessesCount;
            }
            set
            {
                rejectedProcessesCount = value;
                OnPropertyChanged();
            }
        }
        public long CpuTime
        {
            get
            {
                return cpuIdleTime;
            }
            set
            {
                cpuIdleTime = value;
                OnPropertyChanged();
            }
        }
        public long TerminatedProcessesCount
        {
            get
            {
                return terminatedProcessesCount;
            }
            set
            {
                terminatedProcessesCount = value;
                AvgWaitingTime = (double)commonWaitingTime / terminatedProcessesCount;
                AvgTurnAroundTime = (double)commonTurnAroundTime / terminatedProcessesCount;
                AvgReadyQueueLength = settings.Intensity * AvgWaitingTime;
                OnPropertyChanged();
            }
        }
        public long CommonWaitingTime
        {
            get
            {
                return commonWaitingTime;
            }
            set
            {
                commonWaitingTime = value;
                OnPropertyChanged();
            }
        }
        public long CommonTurnAroundTime
        {
            get
            {
                return commonTurnAroundTime;
            }
            set
            {
                commonTurnAroundTime = value;
                OnPropertyChanged();
            }
        }
        public long MaxReadyQueueLength
        {
            get
            {
                return maxReadyQueueLength;
            }
            set
            {
                maxReadyQueueLength = value;
                OnPropertyChanged();
            }
        }

        public double CpuUtilization
        {
            get
            {
                return ((double)(commonTime - cpuIdleTime) / commonTime).Equals(double.NaN) ? 0 : Math.Round((double)(commonTime - cpuIdleTime) / commonTime, 4);
            }
            set
            {

            }
        }
        public double SystemPerformance
        {
            get
            {
                return ((double)terminatedProcessesCount / commonTime).Equals(double.NaN) ? 0 : Math.Round((double)terminatedProcessesCount / commonTime, 4);
            }
            set
            {

            }

        }
        public double AvgWaitingTime
        {
            get
            {
                return ((double)commonWaitingTime / terminatedProcessesCount).Equals(double.NaN) ? 0 : Math.Round((double)commonWaitingTime / terminatedProcessesCount, 4);
            }
            set
            {

            }
        }
        public double AvgTurnAroundTime
        {
            get
            {
                return ((double)commonTurnAroundTime / terminatedProcessesCount).Equals(double.NaN) ? 0 : Math.Round((double)commonTurnAroundTime / terminatedProcessesCount, 4);
            }
            set
            {

            }
        }
        public double AvgReadyQueueLength
        {
            get
            {
                return (settings.Intensity * AvgWaitingTime).Equals(double.NaN) ? 0 : Math.Round((double)settings.Intensity * AvgWaitingTime, 4);
            }
            set
            {

            }
        }

        public void Save(Settings settings)
        {
            this.settings = settings;
        }

        public void Clear()
        {
            commonTime = 0;
            arrivalProcessesCount = 0;
            rejectedProcessesCount = 0;
            cpuIdleTime = 0;
            terminatedProcessesCount = 0;
            commonWaitingTime = 0;
            commonTurnAroundTime = 0;
            maxReadyQueueLength = 0;
            AvgReadyQueueLength = 0;
            AvgTurnAroundTime = 0;
            AvgWaitingTime = 0;
            SystemPerformance = 0;
            CpuUtilization = 0;
            OnPropertyChanged();
        }

        private Settings settings;
        private long commonTime;
        private long arrivalProcessesCount;
        private long rejectedProcessesCount;
        private long cpuIdleTime;
        private long terminatedProcessesCount;
        private long commonWaitingTime;
        private long commonTurnAroundTime;
        private long maxReadyQueueLength;


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
