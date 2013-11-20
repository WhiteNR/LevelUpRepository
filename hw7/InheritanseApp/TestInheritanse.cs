using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanseApp
{
    public interface IA
    {
        void Print();
    }


    public interface IB
    {
        void Print();
    }

    public class TestInheritanse: IA, IB
    {
        void IA.Print()
        {
            Console.WriteLine("Print IA");
        }

        void IB.Print()
        {
            Console.WriteLine("Print IB");
        }

        public void Print()
        {
            Console.WriteLine("TestInheritanse");
        }

        public void PrintA()
        {
            ((IA)this).Print();

            IA ia = this;
            ia.Print();
        }

        public void PrintB()
        {
            ((IB)this).Print();

            IB ib = this;
            ib.Print();
        }
    }
}
