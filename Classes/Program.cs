using System;

namespace OOP
{
    class Student
    {
        int Id;
        string Name;
        double AP1, AP2;
        string result;

        Random R = new Random();

        public Student(String name)
        {
            this.Id = R.Next();
            this.Name = name;
        }

        public void StudebtMarks(double ap1, double ap2)
        {
            this.AP1 = ap1;
            this.AP2 = ap2;
            StudantResult();
        }

        public void StudantResult()
        {

            if (((this.AP1 + this.AP2) / 2) > 13.5)
            {

                result = "Passed";
            }
            else
            {

                result = "Failed";
            }

        }

        public void Details()
        {
            Console.WriteLine("Id :" + this.Id);
            Console.WriteLine("Name :" + this.Name);
            Console.WriteLine("Result :" + result);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            //Student f; // Creating Reference
            //f = new Student(); // creating object

            Student F = new Student("Fáusio Luis Matsinhe");
            F.StudebtMarks(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())); // adding the values manual
           
            F.Details();

            Console.ReadKey();
        }
    }
}
