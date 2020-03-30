using System;
using System.Collections.Generic;
using System.Text;

namespace latihan4
{
    class CoffeMachine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;
        public CoffeMachine(CoffePowder powder,WaterGalon galon)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
        }
        public String makeEsspresso()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "sorry,the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "sorry,the coffe is empty";
            }
            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yey! your coffe is ready";
        }
        public String checkAvailability()
        {
            return $"the water:{this.waterGalon.getVolume()}and the powder :{this.coffePowder.getNetto()}";
        }
    }
}
