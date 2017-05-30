using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace inheritance {
    class Program {
        static void Main(string[] args) {
            AClass a = new AClass(4);
            BClass b = new BClass();
            AClass ab = b;// new BClass(); // Den mest specialicerade kommer att finnas i AClass om metoder är hidden
            AbstractClass ac = b; //ger endast AbstractClassens metoder

            WriteLine("1");
            WriteLine(a.Override());
            WriteLine(b.Override());
            WriteLine(ab.Override()); 

            WriteLine("\n2");
            WriteLine(a.Hidden());
            WriteLine(b.Hidden());
            WriteLine(ab.Hidden());

            WriteLine("\n3");
            WriteLine(a.Abstract());
            WriteLine(b.Abstract());
            WriteLine(ab.Abstract());

            WriteLine("\n4");
            WriteLine(a.Concrete());
            WriteLine(b.Concrete());

            WriteLine("\n5");
            WriteLine(a.InterfaceString1());
            WriteLine(b.InterfaceString2());
            WriteLine((ab as BClass).InterfaceString2());

            WriteLine("\n6");
            WriteLine(a.InterfaceString1());
            WriteLine(b.InterfaceString1());
            WriteLine(ab.InterfaceString1());
            WriteLine((b as Interface2).InterfaceString1());


            WriteLine("\n");
            WriteLine("\n");

        }
    }
}
