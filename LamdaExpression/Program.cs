using System;

namespace FuncLamdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string> concatFunc = (firstName, lastName) =>
            firstName + " " + lastName;
            Func<int, int, int> sumFunc = (firstNum, secondNum) =>
            firstNum + secondNum;
            Func<int, int, int> difFunc = (firstNum, secondNum) =>
            firstNum - secondNum;
            Func<int, int, int> proFunc = (firstNum, secondNum) =>
            firstNum * secondNum;
            Func<int, int, int> divFunc = (firstNum, secondNum) =>
            firstNum / secondNum;

            Console.WriteLine($"\n Welcome {concatFunc("Abdul", "Kadar")}");
            CalculateAdd(sumFunc, difFunc, proFunc, divFunc, 180, 95);

            //CalculateSub(difFunc, 56, 19);
            //CalculateMul(proFunc, 65, 8);
            //CalculateDiv(divFunc, 400, 4);

            Console.ReadKey();

        }
        static void CalculateAdd(Func<int, int, int> addfunc, Func<int, int, int> subFunc, Func<int, int, int> mulFunc, Func<int, int, int> divFunc, int firstNum, int secondNum)
        {
            Console.WriteLine($"\n Sum of {firstNum} and {secondNum} is : {addfunc(firstNum, secondNum)}");
            Console.WriteLine($"\n Difference of {firstNum} and {secondNum} is : {subFunc(firstNum, secondNum)}");
            Console.WriteLine($"\n Product of {firstNum} and {secondNum} is : {mulFunc(firstNum, secondNum)}");
            Console.WriteLine($"\n Reminder of {firstNum} and {secondNum} is : {divFunc(firstNum, secondNum)}");
        }
        //static void CalculateSub(Func<int, int, int> subFunc, int firstNum, int secondNum)
        //{
        //    Console.WriteLine($"\n Difference of {firstNum} and {secondNum} is : {subFunc(firstNum, secondNum)}");
        //}
        //static void CalculateMul(Func<int, int, int> mulFunc, int firstNum, int secondNum)
        //{
        //    Console.WriteLine($"\n Product of {firstNum} and {secondNum} is : {mulFunc(firstNum, secondNum)}");
        //}
        //static void CalculateDiv(Func<int, int, int> divFunc, int firstNum, int secondNum)
        //{
        //    Console.WriteLine($"\n Reminder of {firstNum} and {secondNum} is : {divFunc(firstNum, secondNum)}");
        //}
    }
}
