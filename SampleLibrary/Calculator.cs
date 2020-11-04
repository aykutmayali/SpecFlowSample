using System;

namespace SampleLibrary
{
    public class Calculator : ICalculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Result { get; set; }

        public void Add()
        {
            Result = FirstNumber + SecondNumber;
        }

        public void Subtract()
        {
            Result = FirstNumber - SecondNumber;
        }

        public void Multiply()
        {
            Result = FirstNumber * SecondNumber;
        }

        public void Divide()
        {
            Result = FirstNumber / SecondNumber;
        }

        public void CleanAll()
        {
            FirstNumber = SecondNumber = Result = 0;
        }
    }

    public interface ICalculator
    {
        int FirstNumber { get; set; }

        int SecondNumber { get; set; }

        int Result { get; set; }

        void Add();

        void Subtract();

        void Multiply();

        void Divide();

        void CleanAll();
    }
}
