// Input data
string input = Console.ReadLine(); // Начален вход

// Template data
int counterTotalSeatsTaken = 0;
int counterStudentTicketSold = 0;
int counterStandardTicketSold = 0;
int counterKidTicketSold = 0;
bool end = false;
int totalTicketsSold = 0;
bool finish = false;

// Calculations
while (input != "Finish")
{
    string movieName = input; // Име на филма
    int availableSeats = int.Parse(Console.ReadLine()); // Бройка седалки за прожекцията

    for (int i = 1; i <= availableSeats; i++)
    {
        string soldTicketType = Console.ReadLine(); // Вземаме типа на продадения билет

        switch (soldTicketType)
        {
            case "student":
                counterStudentTicketSold++; // Увеличаваме броя на продадените студентски билети
                counterTotalSeatsTaken++; // Увеличаваме броя на заетите седалки
                break;
            case "standard":
                counterStandardTicketSold++; // Увеличаваме броя на продадените стандартни билети
                counterTotalSeatsTaken++;
                break;
            case "kid":
                counterKidTicketSold++; // Увеличаваме броя на продадените детски билети
                counterTotalSeatsTaken++;
                break;
            case "End":
                end = true; // Достигнали сме края на дадената прожекция
                break;
            case "Finish":
                finish = true;
                break;
        }

        if (end || finish)
        {
            break;
        }
    }

    double percentageFull = (double)counterTotalSeatsTaken / availableSeats * 100.0;

    Console.WriteLine($"{movieName} - {percentageFull:f2}% full.");

    if (finish)
    {
        break;
    }

    input = Console.ReadLine(); // Нов вход от потребителя
    totalTicketsSold += counterTotalSeatsTaken;
    counterTotalSeatsTaken = 0;
    end = false;
}

double percentageStudentTickets = (double)counterStudentTicketSold / totalTicketsSold * 100.0;
double percentageStandardTickets = (double)counterStandardTicketSold / totalTicketsSold * 100.0;
double percentageKidTickets = (double)counterKidTicketSold / totalTicketsSold * 100.0;

Console.WriteLine($"Total tickets: {totalTicketsSold}");
Console.WriteLine($"{percentageStudentTickets:f2}% student tickets.");
Console.WriteLine($"{percentageStandardTickets:f2}% standard tickets.");
Console.WriteLine($"{percentageKidTickets:f2}% kids tickets.");