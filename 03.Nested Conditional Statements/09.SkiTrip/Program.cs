// Input data
int days = int.Parse(Console.ReadLine());
string roomType = Console.ReadLine();
string hotelGrade = Console.ReadLine();

// Template data
int night = days - 1;
double pricePerNight = 0;
double cost = 0;

// Calculations & Checks
switch (roomType)
{
    case "room for one person":
        pricePerNight = 18;
        break;
    case "apartment":
        pricePerNight = 25;
        if (days < 10)
        {
            pricePerNight *= 0.7;
        }
        else if (days >= 10 && days <= 15)
        {
            pricePerNight *= 0.65;
        }
        else if (days > 15)
        {
            pricePerNight *= 0.5;
        }
        break;
    case "president apartment":
        pricePerNight = 35;
        if (days < 10)
            pricePerNight *= 0.9;
        else if (days >= 10 && days <= 15)
            pricePerNight *= 0.85;
        else if (days > 15)
            pricePerNight *= 0.8;

        break;
}

cost = pricePerNight * night; // Total cost before leaving a REVIEW/GRADE for the hotel

if (hotelGrade == "positive")
{
    cost *= 1.25;
}
else if (hotelGrade == "negative")
{
    cost *= 0.9;
}

Console.WriteLine($"{cost:f2}");