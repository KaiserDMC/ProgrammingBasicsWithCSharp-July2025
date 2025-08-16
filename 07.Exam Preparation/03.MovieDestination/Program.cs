// Input data
double budget = double.Parse(Console.ReadLine()); // Бюджет на филма
string destination = Console.ReadLine(); // Дестинация
string season = Console.ReadLine(); // Сезон
int days = int.Parse(Console.ReadLine()); // Снимачни дни

// Template data
double costPerDay = 0; // Променлива за единична цена

// Calculations
switch (destination)
{
    case "Dubai":
        if (season == "Summer")
            costPerDay = 40000;
        else if (season == "Winter")
            costPerDay = 45000;
        break;
    case "Sofia":
        if (season == "Summer")
            costPerDay = 12500;
        else if (season == "Winter")
            costPerDay = 17000;
        break;
    case "London":
        if (season == "Summer")
            costPerDay = 20250;
        else if (season == "Winter")
            costPerDay = 24000;
        break;
}

double totalCostOfMovie = days * costPerDay; // Цената на целия филм

if (destination == "Dubai")
    totalCostOfMovie *= 0.7;
else if (destination == "Sofia")
    totalCostOfMovie *= 1.25;

double difference = budget - totalCostOfMovie; // Разлика между бюджета и цената на филма

if (difference >= 0)
    Console.WriteLine($"The budget for the movie is enough! We have {difference:f2} leva left!");
else
    Console.WriteLine($"The director needs {Math.Abs(difference):f2} leva more!");