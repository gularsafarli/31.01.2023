﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsualiton__Academy_Task
{
    internal class Vehicle
    {
        
        protected double _mileage;
        public double Mileage => _mileage;
        public virtual void Drive(double  km)
        {
            _mileage += km;
        }
    }
}

