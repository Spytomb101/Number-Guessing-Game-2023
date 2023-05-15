//random - makes random numbers - in which I assigned it to 'R'
Random r = new Random();

int wiNum = r.Next(0, 100);
// r.Next chooses a random number between 0 and 100 and assign it to 'win num' 
bool win = false;
// too see if we have won or not, win will tell us false so you have not won. 
do
{
    Console.WriteLine("Guess a number between 0 and 100: ");
    string s = Console.ReadLine();


    int i = int.Parse(s);
    // Converts int as string can't do maths. - Suggestion to move this out of the do/while loop. 
    if (i > wiNum)
    {
        Console.WriteLine("Too High! Guess lower...");
    }
    else if (i < wiNum)
    {
        Console.WriteLine("Too Low! Guess Higher...");
    }
    else if (i == wiNum)
    {
        Console.WriteLine("YOU WIN!");
        win = true;
    }
    Console.WriteLine();
} while (win == false);
Console.WriteLine("Thank you for playing my game!");
Console.Write("Press any key to finish.");
Console.ReadKey(true); 
// What this does is interrupt our key input and not display it. 