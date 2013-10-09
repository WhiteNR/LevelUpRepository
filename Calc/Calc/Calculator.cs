using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calculator
    {
        #region Fields

        private int _X;
        private int _Y;
        private string _operation;

        #endregion

        #region Methods
        
        public void Initialaze()
        {
            Console.WriteLine("Calculator");
            this.ChooseOperation();
        }

        private void ChooseValues()
        {
            Console.WriteLine("Please enter X:");
            X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Y:");
            Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result:");
        }

        private void ChooseOperation()
        {
            Console.WriteLine("Please choose operation:");
            Operation = Console.ReadLine();
            switch (Operation)
            {
                case "/":
                    this.ChooseValues();
                    Console.WriteLine((X / Y).ToString());
                    break;
                case "*":
                    this.ChooseValues();
                    Console.WriteLine((X * Y).ToString());
                    break;
                case "+":
                    this.ChooseValues();
                    Console.WriteLine((X + Y).ToString());
                    break;
                case "-":
                    this.ChooseValues();
                    Console.WriteLine((X - Y).ToString());
                    break;
                default:
                    Console.WriteLine("Wrong operation.");
                    break;
            }
            Console.ReadLine();
        }

        #endregion

        #region Properties

        public int X
        {
            get { return _X; }
            set { _X = value; }
        }

        public int Y
        {
            get { return _Y; }
            set { _Y = value; }
        }

        public string Operation
        {
            get { return _operation; }
            set { _operation = value; }
        }

        #endregion 
    }
}
