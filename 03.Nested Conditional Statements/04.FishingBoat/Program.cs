// Input data
int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int numberFisherman = int.Parse(Console.ReadLine());

// Template data
double costBoat = 0;

// Calculations & Checks
switch (season)
{
    case "Spring":
        costBoat = 3000;
        break;
    case "Summer":
    case "Autumn":
        costBoat = 4200;
        break;
    case "Winter":
        costBoat = 2600;
        break;
}

if (numberFisherman <= 6)
{
    costBoat *= 0.9;
    // costBoat = costBoat * 0.9;
}
else if (numberFisherman >= 7 && numberFisherman <= 11)
{
    costBoat *= 0.85;
}
else if (numberFisherman >= 12)
{
    costBoat *= 0.75;
}

bool extraDiscount = numberFisherman % 2 == 0; // True or False

if (extraDiscount && season != "Autumn")
{
    costBoat = costBoat - (costBoat * 0.05);
    //costBoat *= 0.95;
}

// Разлика
double difference = budget - costBoat; // Positive or Zero -> We have enough; else NOT enough
if (difference >= 0)
{
    Console.WriteLine($"Yes! You have {difference:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva.");
}