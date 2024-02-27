using System;

internal class Program
{
    private static int loopCount;

    private static void Main(string[] args)
    {
        int startingVariable = 20;
        Random random = new Random();

        loopCount = 1;

        while (startingVariable > 0 && startingVariable < 50)
        {
            int randomNumber = random.Next(0, 10);
            if (randomNumber % 2 == 0)
            {
                startingVariable -= 5;
            }
            else
            {
                startingVariable += 2;
            }

            Console.WriteLine($"LoopCount: {loopCount}, Random Number: {randomNumber}, Current Value: {startingVariable}");
            loopCount++;
        }
    }
}
