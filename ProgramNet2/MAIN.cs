using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using static FunctiileMele.My;
using static FunctiileMele.TryCatch;
using System.Threading;
using ProgramNet;

namespace ProgramNet2
{
    class MAIN
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Program care monitorizeaza conexiunea la internet");

            VerificaNetul v = new VerificaNetul();  //sender
            VerificNetEventArgs arg = new VerificNetEventArgs();


            int merge = 0;
            int numerge = 0;
            while (true)
            {
                v.AvailabilityChanged(v, arg, ref merge, ref numerge);
                Thread.Sleep(5000);
            }
            Console.ReadLine();
        }
    }
}
