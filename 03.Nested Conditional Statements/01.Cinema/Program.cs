// Входни данни
string ticketType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());

// Изчисления и преобразувания
double income = 0;
double ticketPrice = 0;

switch (ticketType)
{
    case "Premiere":
        ticketPrice = 12;
        break;
    case "Normal":
        ticketPrice = 7.5;
        break;
    case "Discount":
        ticketPrice = 5;
        break;
}

income = rows * columns * ticketPrice;
Console.WriteLine($"{income:f2} leva");