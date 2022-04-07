using System;
using System.Collections;

char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

Stack usedChars = new Stack();
int hp = 7;

string[] words =
{
    "simple",
    "car",
    "enumerator",
    "shit",
    "border",
    "ready",
    "pollution",
    "recreation",
    "population",
    "world",
    "partisan",
    "senior",
    "officer"
};

var rand = new Random();
for(int i = 0; i < 50; i++)
{
    rand.Next();
}
var w = rand.Next(words.Length);

string word = words[w];

//words[1].Contains('a'))
bool finished = false ;

while (hp > 0)
{
    Console.WriteLine();
    Console.WriteLine($"Lives: {hp}");
    foreach(char c in alphabet)
    {
        if (!usedChars.Contains(c))
        {
            Console.Write($"{c} ");
        }
    }
    Console.WriteLine();
    foreach (char c in word)
    {
        if (usedChars.Contains(c))
        {
            Console.Write(c);
        } else
        {
            Console.Write('_');
        }
    }
    Console.WriteLine();
    Console.Write("Enter character:");
    char ch = Console.ReadKey(false).KeyChar;
    if (usedChars.Contains(ch))
    {
        Console.WriteLine("It has been already used!");
        continue;
    }
    usedChars.Push(ch);
    if (!word.Contains(ch))
    {
        hp--;
    }
    finished = true;
    foreach(var c in word)
    {
        if (!usedChars.Contains(c))
        {
            finished = false;
        }
    }
    if (finished)
    {
        Console.WriteLine("\n=========================");
        Console.WriteLine("      You have won!      ");
        Console.WriteLine("=========================");
        break;
    }
}
if (!finished)
{
    Console.WriteLine("You died!");
}
Console.ReadKey();