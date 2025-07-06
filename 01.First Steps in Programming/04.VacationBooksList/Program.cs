int currentBookPages = int.Parse(Console.ReadLine());
int pagesReadPerHour = int.Parse(Console.ReadLine());
int daysToRead = int.Parse(Console.ReadLine());

int timeToReadTheBook = currentBookPages / pagesReadPerHour; // 212 / 20 = 10
int hoursPerDay = timeToReadTheBook / daysToRead; // 10 / 2 = 5

Console.WriteLine(hoursPerDay);
// 5.2 -> 5,2