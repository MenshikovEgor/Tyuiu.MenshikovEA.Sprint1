using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MenshikovEA.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string space = " ";



            string[] mass = value.Split(' ');

            string word = "";
            char ch;


            foreach (string s in mass)
            {
                ch = s[s.Length - 1];
                word += ch;
            }

            return word;
        }
    }
}
