using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDbApp
{
    class Program
    {
        static void Main(string[] args)
        {

            DatabaseConnector dc = new DatabaseConnector();

            dc.getPets();
        }
    }
}
