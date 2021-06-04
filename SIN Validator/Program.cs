using System;
using System.Collections.Generic;
using System.Linq;

namespace SIN_Validator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CheckSin checkSin = new CheckSin();
            checkSin.CheckSinValidator();
        }
    }
}