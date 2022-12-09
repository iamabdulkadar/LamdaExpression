using System;

namespace ActionLamdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string, string> concatAction = (firstName, lastName) =>
            Console.WriteLine($"\n Welcome {firstName + " " + lastName}"); ;
            Action<int, int> sumAction = (firstNum, secondNum) =>
            Console.WriteLine($"\n Sum of {firstNum} and {secondNum} is : {(firstNum + secondNum)}");
            Action<int, int> diffAction = (firstNum, secondNum) =>
            Console.WriteLine($"\n Difference of {firstNum} and {secondNum} is : {firstNum - secondNum}");
            Action<int, int> proAction = (firstNum, secondNum) =>
            Console.WriteLine($"\n Product of {firstNum} and {secondNum} is : {firstNum * secondNum}");
            Action<int, int> divAction = (firstNum, secondNum) =>
            {
                if (secondNum != 0)
                    Console.WriteLine($"\n Reminder of {firstNum} and {secondNum} is : {firstNum / secondNum}");
                else
                    Console.WriteLine($"\n Please enter non zero value for find remainder");

            };

            concatAction("Abdul", "Kadar");
            sumAction(180, 65);
            diffAction(98, 52);
            proAction(82, 4);
            divAction(80, 0);

            Console.ReadKey();
        }

    }
}
