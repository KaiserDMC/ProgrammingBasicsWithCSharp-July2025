string name = Console.ReadLine();
int grade = 1;
double currentgrade = 0;
double finalGrade = 0;
int excludedStrike = 0;

while (grade <= 12)
{
    currentgrade = double.Parse(Console.ReadLine());

    if (currentgrade < 4)
    {
        excludedStrike++;
        if (excludedStrike == 2)
        {
            Console.WriteLine($"{name} has been excluded at {grade - 1} grade");
            return;
        }
    }

    finalGrade += currentgrade;
    grade++;
}
//Console.WriteLine($"{name} graduated. Average grade: {Math.Round(finalGrade / (12), 2)}");
Console.WriteLine($"{name} graduated. Average grade: {finalGrade / 12:f2}");