// Input data
int start = int.Parse(Console.ReadLine()); // Начална стойност на диапазона от баркодове
int end = int.Parse(Console.ReadLine()); // Крайна стойност на диапазона от баркодове

// Calculations
for (int i = start / 1000; i <= end / 1000; i++)
{
    if (i % 2 != 0)
    {
        for (int j = start / 100 % 10; j <= end / 100 % 10; j++)
        {
            if (j % 2 != 0)
            {
                for (int k = start / 10 % 10; k <= end / 10 % 10; k++)
                {
                    if (k % 2 != 0)
                    {
                        for (int m = start % 10; m <= end % 10; m++)
                        {
                            if (m % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{m} ");
                            }
                        }
                    }
                }
            }
        }
    }
}