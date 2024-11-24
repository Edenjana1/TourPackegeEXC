using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main 
{
    
    internal class TourPackage
    {
        private int id;
        private int price;
        private int maxTime;
        private int maxData;
        private int extra;

        public TourPackage( int id, int price, int maxTime, int maxData)
        {
            this.id = id;
            this.price = price;
            this.maxTime = maxTime;
            this.maxData = maxData;
            this.extra = 0;
        }
         public int GetExtra()
        {
            return this.extra;
        }

        public void SetExtra(int usage, int minutes)
        {
            int calcExtra = 0;
            if (minutes > this.maxTime) calcExtra = minutes - this.maxTime;
            if (usage > this.maxData) calcExtra += 2 * (usage - this.maxData);
        }





    }
}
