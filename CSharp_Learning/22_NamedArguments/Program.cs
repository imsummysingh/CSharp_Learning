using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Named argument example
namespace _22_NamedArguments
{
    class Program
    {
        string _fname, _mname, _lname;
        public void GetFullName(string fname, string mname, string lname)
        {
            _fname = fname;
            _mname = mname;
            _lname = lname;
            Console.WriteLine(_fname + ' ' + _mname + ' ' + _lname);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetFullName(fname: "Summy", mname: "Kumar", lname: "Singh");    //Passing value to the parameter name (Named arguments)
            Console.ReadLine();
        }
    }
}
