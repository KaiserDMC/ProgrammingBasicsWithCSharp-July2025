// Input
double budget = double.Parse(Console.ReadLine()); // Бюджет на семейство Иванови
int nights = int.Parse(Console.ReadLine()); // Брой нощувки
double pricePerNight = double.Parse(Console.ReadLine()); // Цена за една нощувка
int percentageOfExtraCosts = int.Parse(Console.ReadLine()); // Процент допълнителни разходи

if (nights > 7)
    pricePerNight *= 0.95; // 5% намаление ако нощувките са над 7

double costOfVacation = nights * pricePerNight; // Колко струва цялата екскурзия
double extraExpenses = budget * percentageOfExtraCosts / 100; // Допълнителни разходи (някакъв % от бюджета)

costOfVacation += extraExpenses; // Прибавяме допълнителните разходи към цената на екскурзията

if (budget >= costOfVacation)
    Console.WriteLine($"Ivanovi will be left with {budget - costOfVacation:f2} leva after vacation.");
else
    Console.WriteLine($"{costOfVacation - budget:f2} leva needed.");
// Console.WriteLine($"{Math.Abs(budget - costOfVacation):f2} leva needed.");