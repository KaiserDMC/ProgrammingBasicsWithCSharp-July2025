// Input data
int examHour = int.Parse(Console.ReadLine());
int examMinutes = int.Parse(Console.ReadLine());
int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMinutes = int.Parse(Console.ReadLine());

// Template data
int convertedExamMinutes = examMinutes + examHour * 60; // Часа на изпита само в минути
int convertedArrivalMinutes = arrivalMinutes + arrivalHour * 60; // Часа на пристигане само в минути

string status = "";
int totalDifference = 0;
int hourDifference = 0;
int minuteDifference = 0;

// Calculations & Checks
if (convertedExamMinutes < convertedArrivalMinutes)
{
    status = "Late";
}
else if (convertedExamMinutes - convertedArrivalMinutes <= 30)
{
    status = "On time";
}
else if (convertedExamMinutes - convertedArrivalMinutes > 30)
{
    status = "Early";
}

Console.WriteLine(status); // Display Status on Console

totalDifference = Math.Abs(convertedArrivalMinutes - convertedExamMinutes); // Result in MINUTES only
hourDifference = totalDifference / 60; // Gives us the Hours of arrival
minuteDifference = totalDifference % 60; // Gives us the Minutes of arrival

if (status == "Late" && hourDifference >= 1)
{
    Console.WriteLine($"{hourDifference}:{minuteDifference:D2} hours after the start");

    /*
     *  if (minuteDifference < 10)
                {
                    Console.WriteLine($"{hourDifference}:0{minuteDifference} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{hourDifference}:{minuteDifference} hours after the start");
                }
     */
}
else if (status == "Late")
{
    Console.WriteLine($"{minuteDifference} minutes after the start");
}
else if (status == "On time")
{
    if (convertedExamMinutes != convertedArrivalMinutes)
    {
        Console.WriteLine($"{minuteDifference} minutes before the start");
    }
}
else if (status == "Early")
{
    if (hourDifference >= 1)
    {
        Console.WriteLine($"{hourDifference}:{minuteDifference:D2} hours before the start");
    }
    else
    {
        Console.WriteLine($"{minuteDifference} minutes before the start");
    }
}
