// Input data
string input = Console.ReadLine();

// Template data
int sumPrime = 0;
int sumNotPrime = 0;
int counter = 0;

// Calculations
while (input != "stop")
{
    int number = int.Parse(input); // Превръщаме входа от конзолата в число

    if (number < 0)
    {
        Console.WriteLine("Number is negative."); // Отрицателно число, кажи на потребителя
        input = Console.ReadLine(); // Изчакваме нови входни данни
        continue; // Върни се в началото на цикъла
    }

    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            counter++;
        }
    }

    if (counter == 2) // Тогава числото е ПРОСТО
    {
        sumPrime += number;
    }
    else
    {
        sumNotPrime += number;
    }

    counter = 0;
    input = Console.ReadLine(); // Изчакваме нови входни данни
}

Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
Console.WriteLine($"Sum of all non prime numbers is: {sumNotPrime}");