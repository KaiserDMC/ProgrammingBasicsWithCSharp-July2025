// Input data
int gradeThreshold = int.Parse(Console.ReadLine()); // Брой позволени незадоволителни оценки
string currentTask = Console.ReadLine(); // Първи път получаваме задачата за решение

// Template data
int totalGrades = 0;
int taskcounter = 0;
int badGrades = 0;
string lastTask = string.Empty;

while (currentTask != "Enough")
{
    int grade = int.Parse(Console.ReadLine()); // Оценка за дадената задача
    totalGrades += grade; // Сумата на всички оценки
    taskcounter++; // Брой изпълнение задачи

    if (grade <= 4)
    {
        badGrades++; // Увеличи брой на незадоволителни оценки
    }

    if (badGrades == gradeThreshold)
    {
        Console.WriteLine($"You need a break, {badGrades} poor grades.");
        return;
    }

    lastTask = currentTask; // Запазваме последно решената задача в променлива
    currentTask = Console.ReadLine(); // Получаваме нова задача
}

Console.WriteLine($"Average score: {(double)totalGrades / taskcounter:f2}");
Console.WriteLine($"Number of problems: {taskcounter}");
Console.WriteLine($"Last problem: {lastTask}");
