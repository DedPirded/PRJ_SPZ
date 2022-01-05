using Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrame
{
    class DeviceScheduler
    {
        private Resource resource;
        private IQueueable<Process> queue;

        public DeviceScheduler(Resource resource, IQueueable<Process> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }

        public IQueueable<Process> Session()
        {
            Process tmpProc = queue.Item();
            queue.Remove();
            resource.ActiveProcess = tmpProc;
            return queue;
        }
    }
}
