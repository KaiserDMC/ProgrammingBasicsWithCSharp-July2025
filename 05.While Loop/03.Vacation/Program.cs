// Input data
double neededMoney = double.Parse(Console.ReadLine()); // Нужни пари за екскурзия
double availableMoney = double.Parse(Console.ReadLine()); // Налични към момента пари

// Template data
int consecutiveDays = 0; // Поредни дни харчене
int days = 0; // Общо изминали дни от началото

// Calculations
while (neededMoney > availableMoney)
{
    string action = Console.ReadLine(); // Дали Джеси save или spend за деня
    double money = double.Parse(Console.ReadLine()); // Парите които тя харчи или спестява за деня
    days++; // Нов ден

    switch (action)
    {
        case "save":
            availableMoney += money;
            consecutiveDays = 0;
            break;
        case "spend":
            availableMoney -= money; // Намаляме спестените пари
            consecutiveDays++; // Пореден ден харчене

            if (availableMoney < 0) // Ако тя се опита да похарчи повече от наличните пари
                availableMoney = 0;
            break;
    }

    if (consecutiveDays == 5) // Ако харчи в 5 последователни дни
    {
        Console.WriteLine($"You can't save the money.");
        Console.WriteLine($"{days}");
        return;
    }
}

Console.WriteLine($"You saved the money for {days} days.");