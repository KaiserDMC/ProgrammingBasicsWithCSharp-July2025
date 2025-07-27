// Input data
int groups = int.Parse(Console.ReadLine()); // Броя на групите от катерачи

// Template data
int totalAmountOfPeople = 0; // Общо хора
int counterMusala = 0; // Брой хора изкачили върха
int counterMonBlan = 0;
int counterKilimandjaro = 0;
int counterK2 = 0;
int counterEverest = 0;

// Calculations
for (int i = 0; i < groups; i++)
{
    int peopleInGroup = int.Parse(Console.ReadLine()); // Брой хора в настоящата група
    totalAmountOfPeople += peopleInGroup; // Прибави хората в групата към общата бройка

    if (peopleInGroup <= 5)
        counterMusala += peopleInGroup; // Прибави хората от групата към хората изкачващи върха
    else if (peopleInGroup > 5 && peopleInGroup <= 12)
        counterMonBlan += peopleInGroup;
    else if (peopleInGroup > 12 && peopleInGroup <= 25)
        counterKilimandjaro += peopleInGroup;
    else if (peopleInGroup > 25 && peopleInGroup <= 40)
        counterK2 += peopleInGroup;
    else counterEverest += peopleInGroup;
}

// Calculate Averages
double averageMusala = counterMusala / (double)totalAmountOfPeople * 100;
double averageMonBlan = counterMonBlan / (double)totalAmountOfPeople * 100;
double averageKilimandjaro = counterKilimandjaro / (double)totalAmountOfPeople * 100;
double averageK2 = counterK2 / (double)totalAmountOfPeople * 100;
double averageEverest = counterEverest / (double)totalAmountOfPeople * 100;

// Output
Console.WriteLine($"{averageMusala:f2}%");
Console.WriteLine($"{averageMonBlan:f2}%");
Console.WriteLine($"{averageKilimandjaro:f2}%");
Console.WriteLine($"{averageK2:f2}%");
Console.WriteLine($"{averageEverest:f2}%");