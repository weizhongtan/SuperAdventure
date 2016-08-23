using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class MaxHealthIncreaser : Item
    {
        public int IncreaseHealthAmount { get; set; }

        public MaxHealthIncreaser(int id, string name, string namePlural, int increaseHealthAmount) : base(id, name, namePlural)
        {
            IncreaseHealthAmount = increaseHealthAmount;
        }
    }
}
