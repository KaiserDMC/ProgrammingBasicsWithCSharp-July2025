// Input data
int width = int.Parse(Console.ReadLine()); // Ширина на стая
int length = int.Parse(Console.ReadLine()); // Дължина на стая
int height = int.Parse(Console.ReadLine()); // Височина на стая

// Template data
int availableSpace = width * length * height; // Пространство в стаята на Хосе

// Calculations
while (availableSpace > 0) // Докато има свободно пространство в стаята му
{
    string input = Console.ReadLine(); // Брой кашони или команда "Done"

    if (input == "Done")
    {
        if (availableSpace > 0)
            Console.WriteLine($"{availableSpace} Cubic meters left.");
        return;
    }

    availableSpace -= int.Parse(input); // Изваждаме наненсените кашони от свободното простостранство
}

Console.WriteLine($"No more free space! You need {Math.Abs(availableSpace)} Cubic meters more.");