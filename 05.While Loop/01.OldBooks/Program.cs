// Input data
string favouriteBook = Console.ReadLine();

// Template data
int bookCounter = 0;

// Calculations
while (true)
{
    string currentBook = Console.ReadLine(); // Книгата която Ани изважда от библиотеката

    if (favouriteBook == currentBook)
    {
        Console.WriteLine($"You checked {bookCounter} books and found it.");
        break;
    }
    else if (currentBook == "No More Books")
    {
        Console.WriteLine($"The book you search is not here!");
        Console.WriteLine($"You checked {bookCounter} books.");
        break;
    }

    bookCounter++;
}