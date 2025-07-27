// Input data
int n = int.Parse(Console.ReadLine());

// Template data
double p1 = 0;
double p2 = 0;
double p3 = 0;
double p4 = 0;
double p5 = 0;

// Calculations
for (int i = 1; i <= n; i++)
{
    int currentNumber = int.Parse((Console.ReadLine())); // Настоящо число

    if (currentNumber < 200)
    {
        p1++;
    }
    else if (currentNumber >= 200 && currentNumber < 400)
    {
        p2++;
    }
    else if (currentNumber >= 400 && currentNumber < 600)
    {
        p3++;
    }
    else if (currentNumber >= 600 && currentNumber < 800)
    {
        p4++;
    }
    else if (currentNumber >= 800)
    {
        p5++;
    }
}

p1 = p1 / n * 100;
p2 = p2 / n * 100;
p3 = p3 / n * 100;
p4 = p4 / n * 100;
p5 = p5 / n * 100;

Console.WriteLine($"{p1:f2}%");
Console.WriteLine($"{p2:f2}%");
Console.WriteLine($"{p3:f2}%");
Console.WriteLine($"{p4:f2}%");
Console.WriteLine($"{p5:f2}%");

