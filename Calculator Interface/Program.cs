using System;

namespace Calculator_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Input();

            Console.WriteLine("Enter The Operations 1.Add 2.Division 3.Multiplication 4.Subtraction 5.Exponential 6.LogOperations 7.MatrixOperations");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    calculator.Addition();
                    break;

                case 2:
                    calculator.Division();
                    break;

                case 3:
                    calculator.Multiplication(); 
                    break;

                case 4:
                    calculator.Subtraction();
                    break;

                case 5:
                    calculator.Exponential();
                    break;

                case 6:
                    calculator.LogOpertions();
                    break;

                case 7:
                    calculator.MatrixOperations();
                    break;

                default:

                    Console.WriteLine("INVALID RESPONSE");
                    break;

            }
        }
    }
    interface IBasicCalculator
    {
        void Addition();
        void Multiplication();
        void Subtraction();
        void Division();
    }

    interface IScientificcalculator
    {
        void MatrixOperations();
        void LogOpertions();
        void Exponential();
    }

    class Calculator : IBasicCalculator,IScientificcalculator
    {
        float firstnumber;
        float secondnumber;
        public void Input()
        {
            Console.WriteLine("Enter the Firstnumber");
            firstnumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Secondnumber");
            secondnumber = float.Parse(Console.ReadLine());

        }
        public void Addition()
        {
            float add = firstnumber + secondnumber;
            Console.WriteLine("Result :" + add );
        }

        public void Division()
        {
            float division = firstnumber / secondnumber;
            Console.WriteLine("Result :" + division);
        }

        public void Multiplication()
        {
            float multiplication = firstnumber * secondnumber;
            Console.WriteLine("Result :" + multiplication);
        }

        public void Subtraction()
        {
            float subtraction = firstnumber - secondnumber;
            Console.WriteLine("Result :" + subtraction);

        }
        public void Exponential()
        {
            Console.WriteLine("Can Perform Exponential ");
        }
        public void LogOpertions()
        {
            Console.WriteLine("Can Perform LogOperations ");
        }
        public void MatrixOperations()
        {
            Console.WriteLine("Can Perform MatrixOperations ");
        }
    }   
}

