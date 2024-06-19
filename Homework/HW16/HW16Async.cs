using System;

namespace HW16
{
    public class HW16Async
    {
        static Task PrintEvenNumbers()
        {
            return Task.Run(() =>
            {
                for (int i = 0; i < 20; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }

                    Task.Delay(100).Wait();
                }
            });
        }

        static Task PrintOddNumbers()
        {
            return Task.Run(() =>
            {
                for (int i = 0; i < 20; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }

                    Task.Delay(50).Wait();
                }
            });
        }

        static async Task Main(string[] args)
        {
            Task printEven = PrintEvenNumbers();
            Task printOdd = PrintOddNumbers();

            await printEven;
            await printOdd;
        }
    }
}
