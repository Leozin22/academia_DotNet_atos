﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Encapsulamento
{
    internal class Temperatura
    {
        private double celsius = 0;

        public double getCelsius()
        {
            return ((celsius*9)/5+32); //converte para fahrenheit
        }

        public void setCelsius(double fahrenheit)
        {
            celsius = ((fahrenheit-32)*5)/9; //converte para celsius
            Console.WriteLine("Celsius: "+ celsius);
        }
    }
}
