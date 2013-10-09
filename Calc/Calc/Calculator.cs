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

        private string[] _operations = new string[] {"/","*","+","-"};
        private int _X;
        private int _Y;
        private string _operation;

        #endregion

        #region Methods

        public Calculator()
        {
            Console.WriteLine("Calculator");
        }

        private void ChooseOperation()
        {
            bool _rightOperation = false;
            Console.WriteLine("Please choose operation:");
            Operation = Console.ReadLine();
            foreach (string _str in _operations)
            {
                if (Operation == _str) { _rightOperation = true; break; }
            }
            if (!_rightOperation)
            {
                Console.WriteLine("Wrong operation!!!");
                this.ChooseOperation();
            }
        }

        private void ChooseValues()
        {
            Console.WriteLine("Please enter X:");
            X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Y:");
            Y = Convert.ToInt32(Console.ReadLine());
        }

        public void Calculating()
        {
            this.ChooseOperation();
            this.ChooseValues();
            Console.WriteLine("Result:");
            Console.WriteLine(Calcutate());
            Console.ReadLine();
        }
        
        private string Calcutate()
        {
            Int32 _result;
            switch (Operation)
            {
                case "/":
                    _result = X / Y;
                    break;
                case "*":
                    _result = X * Y;
                    break;
                case "+":
                    _result = X + Y;
                    break;
                case "-":
                    _result = X - Y;
                    break;
                default:
                    _result = 0;
                    break;
            }
            return _result.ToString();
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
