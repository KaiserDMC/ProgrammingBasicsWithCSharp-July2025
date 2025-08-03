// Input data
string input = Console.ReadLine(); // Стъпки или команда "Going home"

// Template data
int counterSteps = 0;

// Calculations

while (input != "Going home")
{
    counterSteps += int.Parse(input); // Щом сме получили стъпки, а не команда, направи на число и прибави

    if (counterSteps >= 10000)
    {
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{counterSteps - 10000} steps over the goal!"); // Колко над 10000 е извървяла
        return;
    }

    input = Console.ReadLine(); // Получаваме нови стъпки или команда
}

counterSteps += int.Parse(Console.ReadLine()); // Стъпките който Габи извървява докато се прибира

if (counterSteps >= 10000)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{counterSteps - 10000} steps over the goal!"); // Колко над 10000 е извървяла
}
else
{
    Console.WriteLine($"{10000 - counterSteps} more steps to reach goal."); // Ако е под 10000
}
