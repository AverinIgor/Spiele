using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiele
{
    class voen
    {
        public int chislo;
        public int zdorovje = 3;
        public int moguschestvo = 1;
    }

    class mag
    {
        public int chislo;
        public int zdorovje = 1;
        public int moguschestvo = 3;
    }

    class drakon
    {
        public int chislo;
        public int zdorovje = 2;
        public int moguschestvo = 2;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int chislo;
            Console.WriteLine("выберите число от 1 до 9 - ");
           
            chislo= int.Parse(Console.ReadKey());
            
            
        }
    }
}
