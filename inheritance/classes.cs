using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance {//Så länge som funktioner är abstrakta är det inga problem med att ärva+implementera flera klasser med samma funktionsnamn

    interface Interface1 {
        string InterfaceString1();
    }

    interface Interface2 {
        int InterfaceString1();
        string InterfaceString2();
    }

    abstract class AbstractClass {
        public int AFlag { get; set; }
        public AbstractClass() { AFlag = 1; }
        public AbstractClass(int flag ) { AFlag = flag; }

        public abstract string Abstract();
        public virtual string Concrete() => "Abstract:Concrete";
    }

    class AClass : AbstractClass, Interface1{
//        public AClass() { }
        public AClass(int flag):base(flag) { }//base = refererar basklassens konstruktor här anropas den 3:e konstruktorn
        public virtual string Override()=>"A:Override";
        public string Hidden() => "A:Hidden";
        public override string Abstract() => "A:Abstract()";
        public string InterfaceString1() =>"A:InterfaceString1";
    }

    class BClass :AClass, Interface2 {
        public BClass():base(3){ }//base = refererar basklassens konstruktor

        public override string Override() => "B:Override"; //expressionsyntax, ekvivalent med måsvingar+ return
        public new string Hidden() => "B:Hidden"; //new när det är medvetet hidden annars virtual/override
        public override string Concrete() => "B:Concrete";
        public string InterfaceString2() => "B:InterfaceString2";
        int Interface2.InterfaceString1() => 2; //explisiv interfaceimplementation

    }
}
