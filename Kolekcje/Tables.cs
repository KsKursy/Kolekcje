using System;
using System.Collections.Generic;
using System.Text;

namespace Kolekcje
{
    class Tables
    {
        public int[,] Names;
        //public string[] Names;
        public Tables()
        {
            //Names = new string[] { "2", "11" , "1"};
            Names = new int[2, 3] { { 2, 11, 1 }, { 1, 56, 8779789 } };
            //Array.Sort(Names);
        }
        public override string ToString()
        {
            string result = "brzydal";
            //foreach (var item in Names)
            //{
            //    result += $" {item}{Environment.NewLine}";
            //}
            //for (int i = 0; i < Names.Length; i++)
            //{
            //    result += $" {Names[i-1, 0]}{Environment.NewLine}"; 
            //}
            return result;
        }
    }
}
