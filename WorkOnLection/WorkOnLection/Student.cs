using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOnLection
{
    class Student
    {
        #region MyRegion
        private string _firstName;
        private string _lastName;
        private string _fatherName;

        private int[][] mas = new int[3][];

        #endregion

        public Student(string firstName,string lastName,string fatherName)
        {
            FirstName = firstName;
            LastName = lastName;
            FatherName = fatherName;

            mas[0] = new int[0];
            mas[1] = new int[0];
            mas[2] = new int[0];
        }

        public void AddProgrammingMark(int a)
        {
            int length = mas[0].Length;
            int[] temp_mas = new int[length + 1];
            for (int i = 0; i < length; i++)
            {
                temp_mas[i] = mas[0][i];
            }
            temp_mas[length] = a;
            mas[0] = temp_mas;
        }

        public void AddAdministratingMark(int a)
        {
            int length = mas[1].Length;
            int[] temp_mas = new int[length + 1];
            for (int i = 0; i < length; i++)
            {
                temp_mas[i] = mas[1][i];
            }
            temp_mas[length] = a;
            mas[1] = temp_mas;
        }

        public void AddDesigningMark(int a)
        {
            int length = mas[2].Length;
            int[] temp_mas = new int[length + 1];
            for (int i = 0; i < length; i++)
            {
                temp_mas[i] = mas[2][i];
            }
            temp_mas[length] = a;
            mas[2] = temp_mas;
        }

        public double GetEverageMark(int a)
        {
            double everage = 0;
            if (mas[a].Length > 0)
            {
                everage = mas[a].Average();
            }
            return everage;
        }

        public string GetTotalStudentInfo()
        {
            string ret = "";
            ret += "First Name: " + FirstName + "\r\nLast Name: " + LastName + "\r\nFather Name: " + FatherName + "\r\n";
            for (int i = 0; i < mas.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        ret += "Programming Marks:\r\n";
                        break;
                    case 1:
                        ret += "Administrating Marks:\r\n";
                        break;
                    case 2:
                        ret += "Designing Marks:\r\n";
                        break;
                }
                for (int j = 0; j < mas[i].Length; j++)
                {
                    ret += mas[i][j].ToString() + " ";
                }

                ret += "\r\nAverage mark:" + GetEverageMark(i).ToString() + "\r\n";

                ret += "\r\n";
            }
            return ret;
        }

        #region MyRegion

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FatherName
        {
            get { return _fatherName; }
            set { _fatherName = value; }
        }

        #endregion


    }
}
