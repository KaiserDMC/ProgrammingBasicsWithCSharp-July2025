// Input data
int width = int.Parse(Console.ReadLine()); // Ширина на торта
int length = int.Parse(Console.ReadLine()); // Дължина на торта

// Template data
int cake = width * length; // Парчета торта

// Calculations
while (cake > 0) // Докато имаме парчета торта
{
    string input = Console.ReadLine(); // Взети парчета торта или команда "STOP"

    if (input == "STOP")
    {
        if (cake > 0)
        {
            Console.WriteLine($"{cake} pieces are left.");
            return;
        }
    }

    cake -= int.Parse(input); // Вадим взетите парчета торта от общия брой
}

Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");