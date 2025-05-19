Random rand = new Random();
int score = 0;

while (true)
{
    
int number1 = rand.Next(1, 12);
int number2 = rand.Next(1, 12);

Console.WriteLine($"{number1} _ {number2}");
Console.WriteLine("Skriv inn <, > eller = :");
string input = Console.ReadLine();

if (input != "<" && input != ">" && input != "=")
{
    Console.WriteLine("Spillet Avsluttes.");
    break;
}
if ((input == "<" && number1 < number2) ||
    (input == ">" && number1 > number2) ||
    (input == "=" && number1 == number2))
{
    Console.WriteLine("Riktig!");
    score++;
}
else
{
    Console.WriteLine("Feil!");
    score--;
}

Console.WriteLine($"Poeng: {score}");
Console.WriteLine();
}