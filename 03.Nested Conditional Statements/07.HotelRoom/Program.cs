// Input data
string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

// Template data
double priceStudio = 0;
double priceApartment = 0;

// Calculations & Checks
switch (month)
{
    case "May":
    case "October":
        priceStudio = 50;
        priceApartment = 65;

        if (nights > 7 && nights <= 14)
        {
            priceStudio *= 0.95;
        }
        else if (nights > 14)
        {
            priceStudio *= 0.7;
        }

        break;
    case "June":
    case "September":
        priceStudio = 75.20;
        priceApartment = 68.70;

        if (nights > 14)
        {
            priceStudio *= 0.8;
        }

        break;
    case "July":
    case "August":
        priceStudio = 76;
        priceApartment = 77;
        break;
}

if (nights > 14)
{
    priceApartment *= 0.9;
}

double costStudio = priceStudio * nights; // Цена на студио за целия престой
double costApartment = priceApartment * nights; // Цена на апартамент за целия престой

Console.WriteLine($"Apartment: {costApartment:f2} lv.");
Console.WriteLine($"Studio: {costStudio:f2} lv.");