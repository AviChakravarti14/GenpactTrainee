using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppneww
{
    public class Emp
    {
        public string Fullname(string fname, string lname)
        {
            return fname+ "  " +lname;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { Emp emp = new Emp();
            Console.WriteLine(emp.Fullname("Avi", "Chakravarti"));
            Console.ReadKey();
        }
    }
}
