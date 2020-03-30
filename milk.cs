using System;
using System.Collections.Generic;
using System.Text;

namespace latihan4
{
    class milk
    {
        private int ML = 0;
        private int oneCupMilk = 25;

        public milk(int ML)
        {
            this.ML = ML;
        }
        public Boolean isAvailable()
        {
            return this.ML >= this.oneCupMilk;
        }
        public void makeOneCup()
        {
            this.ML = this.ML - oneCupMilk;
        }
        public int getML()
        {
            return this.ML;
        }
    }
    }
