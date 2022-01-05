using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrame
{
    public enum ProcessStatus
    {
        ready,
        running,
        waiting,
        terminated
    }

    public class Process: IComparable<Process>
    {
        public Process(long pid, long addrSpace)
        {
            id = pid;
            AddrSpace = addrSpace;           
            name = "P" + pid.ToString();

            Status = ProcessStatus.ready;
        }

        public void IncreaseWorkTime()
        {
            workTime++;
            if (workTime==BurstTime)
            {
                if (Status == ProcessStatus.running)
                {
                    Status = random.Next(0, 2) == 0 ? ProcessStatus.terminated : ProcessStatus.waiting;
                    if (Status == ProcessStatus.waiting)
                    {                    
                        smth.DeviceNumber = (int)random.Next(1, 3);
                        OnFreeingAResource(smth);
                        return;
                    }
                  
                }
                else
                {
                    Status = ProcessStatus.ready;
                }
                OnFreeingAResource(smth);
            }
            else
            {
                //workTime++;
            }
            
        }
        public void ResetWorkTime()
        {
            workTime = 0;
        }

        public override string ToString()
        {
            string result = "Id: " + id.ToString() + " Name: " + name + " Status: " + Status + " BurstTime: " + BurstTime + " AddrSpace: " + AddrSpace;
            return result;
        }

        public int CompareTo(Process other)
        {
            if (other == null) return 1;
            return other.BurstTime.CompareTo(this.BurstTime);
        }
        public void OnFreeingAResource(EventArgs e = null)
        {
            if (FreeingAResource != null)
            {
                FreeingAResource(this, e);
            }
        }

        private long id;
        private string name;
        private long workTime;
        public long BurstTime { get; set; }
        public ProcessStatus Status { get; set; }    
        public long ReadyQueueArrivalTime { get; set; }
        public long AddrSpace { get; private set; }
        public long ArrivalTime { get; set; }
        public long CommonWaitingTime { get; set; }
        NewEventArgs smth = new NewEventArgs();
        public event EventHandler FreeingAResource;
        private Random random = new Random();
    }
}
