using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVCFrame
{
    public class Memory: INotifyPropertyChanged
    {
        public long Size
        {
            get;
            private set;
        }
        public long FreeSize { 
            get
            {
                return Size - occupiedSize;
            }
            private set
            {
            }
        }
        private long occupiedSize;
        public long OccupiedSize { 
            get 
            { 
                return occupiedSize;
            } 
            set {
                occupiedSize = value;
                FreeSize = Size - occupiedSize;
                OnPropertyChanged(); 
            } 
        }     
        public void Save(long size)
        {
            Size = size;
            OccupiedSize = 0;
        }

        public void Clear()
        {
            FreeSize = 0;
            OccupiedSize = 0;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
