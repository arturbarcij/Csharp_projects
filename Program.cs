using System;
class MAINCLASS {
static void Main () {
//Switch expression with Tuples 
static string RockPaperScissors(string first, string second)
 
        { 
           return (first, second) switch
            { 
                ("rock", "paper") => "Paper wins.",
                ("rock", "scissors") => "Rock wins.", 
                ("paper", "rock") => "Paper wins.",
                ("paper", "scissors") => "Scissors wins.", 
                ("scissors", "rock") => "Rock wins.", 
                ("scissors", "paper") => "Scissors wins.", 
                (_, _) => "Tie.",
            }; 
        }
    Console.WriteLine(RockPaperScissors("rock", "paper"));

    }
}

// Troelsen, Andrew; Japikse, Phillip. Pro C# 9 with .NET 5 (p. 272). Apress. Kindle Edition.