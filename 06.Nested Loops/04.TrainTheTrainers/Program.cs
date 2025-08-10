// Input data
int n = int.Parse(Console.ReadLine()); // Брой журита
string input = Console.ReadLine(); // Вход - команда

// Template data
int taskCounter = 0; // Общ брой задачи
double sumOfAverages = 0; // Сума на всички оценки за отделните презентации

// Calculations
while (input != "Finish")
{
    string nameOfPresentation = input; // Даваме име на презентацията
    double averageGrade = 0;
    // double sumGrade = 0;

    for (int i = 0; i < n; i++)
    {
        double grade = double.Parse(Console.ReadLine()); // Вземаме оценката от всяко жури

        averageGrade += grade; // Сумата на оценките от всички съдии
        //sumGrade += grade;
    }

    averageGrade /= n; // Средната оценка от всички съдии
    //averageGrade = sumGrade / n;
    Console.WriteLine($"{nameOfPresentation} - {averageGrade:f2}.");

    sumOfAverages += averageGrade;
    taskCounter++; // Увеличаваме броя на всички презентации

    input = Console.ReadLine(); // Чакаме нов вход от потребителя
}

Console.WriteLine($"Student's final assessment is {(sumOfAverages / taskCounter):f2}.");