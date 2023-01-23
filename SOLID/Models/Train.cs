using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Models
{
    public class Train
    {
        public enum SizeOfTheTrain 
        { 
            Mini, 
            Maxi
        }

        private SizeOfTheTrain size;

        private int Capacity = Constants.ZERO_NUMB;
 

        public Train(SizeOfTheTrain size)
        {
            this.size = size;
            if (size == SizeOfTheTrain.Maxi)
            {
                Capacity = Constants.MAXI_TRAIN_S;
            }
            else 
            {
                Capacity = Constants.MINI_TRAIN_S;
            }
        }

        public int GetCapacity()
        {
           return Capacity;
        }
        public void SetCapacity()
        {
             Capacity--;
        }

        public SizeOfTheTrain GetSize()
        {
            return size;
        }
    }
}
