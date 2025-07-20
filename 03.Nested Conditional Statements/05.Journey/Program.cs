// Input data
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

// Template data
string destination = "";
double cost = 0;
string accommodationType = "";

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        accommodationType = "Camp";
        cost = budget * 0.3;
    }
    else if (season == "winter")
    {
        accommodationType = "Hotel";
        cost = budget * 0.7;
    }
}
else if (budget > 100 && budget <= 1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        accommodationType = "Camp";
        cost = budget * 0.4;
    }
    else if (season == "winter")
    {
        accommodationType = "Hotel";
        cost = budget * 0.8;
    }
}
else if (budget > 1000)
{
    destination = "Europe";
    accommodationType = "Hotel";
    cost = budget * 0.9;
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{accommodationType} - {cost:f2}");