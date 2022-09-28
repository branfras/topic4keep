using System;

namespace topic4keep
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int useMin;
            int useMax;
            int ranNum;
            string useLess;
            int die1;
            int die2;
            int dieSum;
            double ranDou;
            double ranDec;
            Console.WriteLine("Enter the min value.");
            useMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the max value.");
            useMax = Convert.ToInt32(Console.ReadLine());
            useMax = useMax + 1;
            ranNum = generator.Next(useMin, useMax);
            Console.Write(ranNum);
            ranNum = generator.Next(useMin, useMax);
            Console.Write(" " + ranNum);
            ranNum = generator.Next(useMin, useMax);
            Console.Write(" " + ranNum);
            ranNum = generator.Next(useMin, useMax);
            Console.Write(" " + ranNum);
            ranNum = generator.Next(useMin, useMax);
            Console.WriteLine(" " + ranNum);

            Console.WriteLine("Press enter to roll the dice.");
            useLess = Console.ReadLine();
            die1 = generator.Next(1, 7);
            die2 = generator.Next(1, 7);
            dieSum = die1 + die2;
            Console.WriteLine($"The first die rolled a {die1}. The second die rolled a {die2}. The total rolled is {dieSum}.");

            Console.WriteLine("Press enter to to make three decimals.");
            useLess = Console.ReadLine();
            ranDou = generator.NextDouble();
            ranNum = generator.Next(useMin, useMax);
            ranDec = ranNum + ranDou;
            Console.Write(Math.Round(ranDec, 2));
            ranDou = generator.NextDouble();
            ranNum = generator.Next(useMin, useMax);
            ranDec = ranNum + ranDou;
            Console.Write(" " + Math.Round(ranDec, 2));
            ranDou = generator.NextDouble();
            ranNum = generator.Next(useMin, useMax);
            ranDec = ranNum + ranDou;
            Console.WriteLine(" " + Math.Round(ranDec, 2));

        }
    }
}
