// Input data
string actorName = Console.ReadLine(); // Име на актьора
double academyPoints = double.Parse(Console.ReadLine()); // Начални точки от академията
int n = int.Parse(Console.ReadLine()); // Брой оценяващи

// Template data
double totalScore = 0; // Общ брой точки за всеки актьор

// Calculations
for (int i = 1; i <= n; i++)
{
    string judgeName = Console.ReadLine(); // Име на оценяващия
    double judgeScore = double.Parse(Console.ReadLine()); // Точки на оценяващия

    // Общ брой точки от Оценяващия
    totalScore = judgeName.Length * judgeScore / 2;
    academyPoints += totalScore; // Новите точки на актьора -> начални плюс оценка

    if (academyPoints >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:f1}!");
        return; // Приключваме програмата ако е събрал достатъчно точки 
    }
}

Console.WriteLine($"Sorry, {actorName} you need {1250.5 - academyPoints:f1} more!"); // Ще се изпълни само ако не сме приключили програмата предварително, т.е. не сме събрали необходимия брой точки