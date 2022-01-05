using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
//using ConsoleApp1;
using Queues;
using Structures;

namespace MVCFrame
{
    class Model: INotifyPropertyChanged
    {
        // операции модели

        public Model() // создание
        {
            // создание компонентов вычислительной системы:

            // 1.   часов - счётчика рабочих тактов;
            Clock = new SystemClock();
            // 2.   процессора;
            Cpu = new Resource();
            // 3.   оперативной памяти;
            Ram = new Memory();
            // 4.   внешнего устройства;
            Device = new Resource();
            Device_2 = new Resource();
            // 5.   генератора идентификаторов процессов;
            idGen = new IdGenerator();
            // 6.   очереди готовых процессов (к процессору);
            readyQueue = new SortedUnsorterQueue<Process>();
            // 7.   очереди к внешнему устройству;
            deviceQueue = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            deviceQueue_2 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            // 8.   планировщика процессора;
            cpuScheduler = new CPUScheduler(Cpu, readyQueue);
            // 9.   планировщика памяти;
            memoryManager = new MemoryManager();
            // 10.  планировщика внешнего устройства;
            deviceScheduler = new DeviceScheduler(Device, deviceQueue);
            deviceScheduler_2 = new DeviceScheduler(Device_2, deviceQueue_2);
            // 11.  настроек модели предметной области; 
            ModelSettings = new Settings();
            // 12. статистики
            statistics = new Statistics();
            // 13.  генератора случайных чисел.
            processRand = new Random();
        }

        public void SaveSettings()
        {
            Ram.Save(ModelSettings.ValueOfRAMSize);
            memoryManager.Save(Ram);
            statistics.Save(ModelSettings);
        }

        public void WorkingCycle() // рабочий такт вычислительной системы
        {
            //рабочий шаг часов
            Clock.WorkingCycle();
            statistics.CommonTime = Clock.Clock;
            double c = processRand.NextDouble();
            //каждые 10 тактов сортирует очередь
            if (Clock.Clock % 10 == 0)
            {
                SortedUnsorterQueue<Process> temp = (SortedUnsorterQueue<Process>)readyQueue;
                ReadyQueue = temp.Sort();
            }
                

            if (Cpu.IsFree())
            {
                statistics.CpuTime++;
            }
            // если на данном шаге процесс должен поступить в систему
            if (c <= ModelSettings.Intensity)
            {
                // создаётся процесс
                Process proc = new Process(idGen.Id, processRand.Next(ModelSettings.MinValueOfAddrSpace, ModelSettings.MaxValueOfAddrSpace + 1));

                statistics.ArrivalProcessesCount++;
                if (memoryManager.Allocate(proc.AddrSpace) != null)
                {
                    // время поступления процесса в вычислительную систему
                    proc.ArrivalTime = Clock.Clock;
                    // генерируется предпологаемый промежуток времени работы процесса на процессоре (BurstTime)
                    proc.BurstTime = processRand.Next(ModelSettings.MinValueOfBurstTime, ModelSettings.MaxValueOfBurstTime + 1);
                    // процесс становится в очередь готовый процессов
                    ReadyQueue = readyQueue.Put(proc);
                    // возможно увеличение максимальной длины очереди
                    if (readyQueue.Count > statistics.MaxReadyQueueLength)
                    {
                        statistics.MaxReadyQueueLength = readyQueue.Count;
                    }
                    // время последней постановки в очередь готовых процессов
                    proc.ReadyQueueArrivalTime = Clock.Clock;

                    // если процессор свободен
                    if (Cpu.IsFree())
                    {
                        putProcessOnResource(Cpu);
                    }                  
                }
                else
                {
                    statistics.RejectedProcessesCount++;
                }
            }
            Cpu.WorkingCycle();
            Device.WorkingCycle();
            Device_2.WorkingCycle();
        }

        public void Clear() // очистка (подготовка вычислительной системы к следующему сеансу работы)
        {
            Unsubscribe(Cpu);
            Unsubscribe(Device);
            Unsubscribe(Device_2);
            // удаление процесса с процессора
            Cpu.Clear();
            // удаление процесса с внешнего устройства
            Device.Clear();
            Device_2.Clear();
            // очистка памяти
            Ram.Clear();
            // очистка очереди готовых процессов
            ReadyQueue = readyQueue.Clear();
            // очистка очереди к устройств
            DeviceQueue = deviceQueue.Clear();
            DeviceQueue_2 = deviceQueue_2.Clear();
            // очистка счётчика тактов
            Clock.Clear();
            // сброс настроек
            idGen.Clear();
        }

        // компоненты модели:

        // 1.   часы;
        public readonly SystemClock Clock;       
        // 2.   центральный процессор;
        public readonly Resource Cpu;
        
        // 3.   внешние устройства;
        public readonly Resource Device;
        public readonly Resource Device_2;
        
        // 4.   ОП;
        public readonly Memory Ram;
        // 5.   генератор идентификаторов процессов;
        private IdGenerator idGen;
        // 6.   очередь готовых процессов;
        private IQueueable<Process> readyQueue;
        //private SortedUnsorterQueue<Process> readyQueue;
        // 7.   очередь к внешнему устройству;
        private IQueueable<Process> deviceQueue;
        private IQueueable<Process> deviceQueue_2;
        // 8    планировщик центрального процессора;
        private CPUScheduler cpuScheduler;
        // 9.   планировщик памяти;
        private MemoryManager memoryManager;
        // 10.  планировщик внешнего устройства;
        private DeviceScheduler deviceScheduler;
        private DeviceScheduler deviceScheduler_2;
        // 11.  генератор процессов (генератор случайных чисел);
        private Random processRand;
        // 12.  настройки модели предметной области.
        public readonly Settings ModelSettings;
        // 13. статистика
        public readonly Statistics statistics;
        public IQueueable<Process> ReadyQueue
        {
            get
            {
                return readyQueue;
            }
            set
            {
                readyQueue = value;
                OnPropertyChanged();
            }
        }
        
        public IQueueable<Process> DeviceQueue
        {
            get
            {
                return deviceQueue;
            }
            set
            {
                deviceQueue = value;
                OnPropertyChanged();
            }
        }
        public IQueueable<Process> DeviceQueue_2
        {
            get
            {
                return deviceQueue_2;
            }
            set
            {
                deviceQueue_2 = value;
                OnPropertyChanged();
            }
        }


        // плучатель события
        private void Subscribe(Resource resource)
        {
            if (resource.ActiveProcess != null)
                resource.ActiveProcess.FreeingAResource += FreeingAResourceEventHandler;
        }

        private void Unsubscribe(Resource resource)
        {
            if (resource.ActiveProcess != null)
            {
                resource.ActiveProcess.FreeingAResource -= FreeingAResourceEventHandler;
            }
        }
        private void putProcessOnResource(Resource resource)
        {
            if(resource == Cpu)
            {
                ReadyQueue = cpuScheduler.Session();
                resource.ActiveProcess.CommonWaitingTime += (Clock.Clock - resource.ActiveProcess.ReadyQueueArrivalTime);
            }
            else
            {
                if (resource == Device)
                {
                    DeviceQueue = deviceScheduler.Session();
                }
                else
                {
                    DeviceQueue_2 = deviceScheduler_2.Session();
                }
            }
            Subscribe(resource);
        }
        private void FreeingAResourceEventHandler(object sender, EventArgs e)
        {
            Process resourceFreeingProcess = sender as Process;
            NewEventArgs device = (NewEventArgs)e;

            switch (resourceFreeingProcess.Status)
            {
                case ProcessStatus.terminated:
                    Unsubscribe(Cpu);
                    Cpu.Clear(); 
                    // освободить память занимаемую процессом;
                    memoryManager.Free(resourceFreeingProcess.AddrSpace);
                    if (readyQueue.Count != 0)
                    {
                        putProcessOnResource(Cpu);
                    }                                              
                    statistics.TerminatedProcessesCount++;
                    statistics.CommonWaitingTime += resourceFreeingProcess.CommonWaitingTime;
                    statistics.CommonTurnAroundTime += (Clock.Clock - resourceFreeingProcess.ArrivalTime);
                    break;
                case ProcessStatus.waiting:
                    Unsubscribe(Cpu);
                    Cpu.Clear();
                    if (readyQueue.Count != 0)
                    {
                        putProcessOnResource(Cpu);
                    }                   
                    
                    resourceFreeingProcess.ResetWorkTime();

                    resourceFreeingProcess.BurstTime = processRand.Next(ModelSettings.MinValueOfBurstTime, ModelSettings.MaxValueOfBurstTime + 1);
                    switch (device.DeviceNumber)
                    {
                        case 1:
                            DeviceQueue = DeviceQueue.Put(resourceFreeingProcess);
                            if (Device.IsFree())
                            {
                                putProcessOnResource(Device);
                            }
                            break;
                        case 2:
                            DeviceQueue_2 = DeviceQueue_2.Put(resourceFreeingProcess);
                            if (Device_2.IsFree())
                            {
                                putProcessOnResource(Device_2);
                            }
                            break;
                        default:
                            break;
                    }
                    
                        
                    break;

                case ProcessStatus.ready:
                    switch (device.DeviceNumber)
                    {
                        case 1:
                            Unsubscribe(Device);
                            Device.Clear();
                            if (deviceQueue.Count != 0)
                            {
                                putProcessOnResource(Device);
                            }
                            break;
                        case 2:
                            Unsubscribe(Device_2);
                            Device_2.Clear();
                            if (deviceQueue_2.Count != 0)
                            {
                                putProcessOnResource(Device_2);
                            }
                            break;
                        default:
                            break;
                    }
                    resourceFreeingProcess.ResetWorkTime();
                    resourceFreeingProcess.BurstTime = processRand.Next(ModelSettings.MinValueOfBurstTime, ModelSettings.MaxValueOfBurstTime + 1);
                    ReadyQueue = readyQueue.Put(resourceFreeingProcess);
                    // возможно увеличение максимальной длины очереди
                    if (readyQueue.Count > statistics.MaxReadyQueueLength)
                    {
                        statistics.MaxReadyQueueLength = readyQueue.Count;
                    }
                    // время последней постановки в очередь готовых процессов
                    resourceFreeingProcess.ReadyQueueArrivalTime = Clock.Clock;
                    if (Cpu.IsFree())
                    {
                        putProcessOnResource(Cpu);
                    }
                    break;
                default:
                    throw new Exception("Unknown process status");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}