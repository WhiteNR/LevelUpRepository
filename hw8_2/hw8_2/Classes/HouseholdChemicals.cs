﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw8_2.AbstaractClasses;
using hw8_2.Interfaces;

namespace hw8_2.Classes
{
    public class HouseholdChemicals : Product, IFlammableProduct
    {
        public HouseholdChemicals(string name, int number, Decimal price)
            : base(name, number, price)
        {

        }
    }
}
