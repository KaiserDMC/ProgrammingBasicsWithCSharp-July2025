string destination = Console.ReadLine();

while (destination != "End")
{
    string budget = Console.ReadLine();
    if (budget == "End")
    {
        break;
    }
    double budgetValue = double.Parse(budget);
    double savedMoney = 0;
    while (savedMoney < budgetValue)
    {
        double currentMoney = double.Parse(Console.ReadLine());
        savedMoney += currentMoney;
    }
    Console.WriteLine($"Going to {destination}!");
    destination = Console.ReadLine();
}