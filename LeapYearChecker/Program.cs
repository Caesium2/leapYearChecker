Console.WriteLine("Input a year:");

int userYear = Convert.ToInt32(Console.ReadLine());

if ((userYear % 4 == 0) && (userYear % 100 != 0 || userYear % 400 == 0)){ 
    Console.WriteLine($"{userYear} is a leap year.");
}
else
{
    Console.WriteLine($"{userYear} is not a leap year."); 
}