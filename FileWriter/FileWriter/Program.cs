using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
           
           //Create an instance of StreamWriter to write to a file
           StreamWriter writer = new StreamWriter("..\\..\\numbers.txt");

           //the using statement will auto-close the file for us
           using (writer)
           {
               //loop from 1 through 20 and write the number to a line
               for (int i = 0; i < 20; i++)
               {
                   writer.WriteLine(i);
               }
           }
        


        }
    }
}
