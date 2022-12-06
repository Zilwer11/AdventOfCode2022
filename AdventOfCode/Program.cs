// See https://aka.ms/new-console-template for more information
using System.Collections;

















//DAY6

string[] datastream = File.ReadAllLines(@"D:\OneDrive\Documents\AdventOfCode\6\input.txt");


string stream = datastream[0];


List<char> chars = new List<char>();

int index = 0;

foreach (char ch in stream)
{
    if (chars.Count == 14)
    {
        break;
    }
    if (chars.Contains(ch))
    {
        chars.RemoveRange(0, chars.IndexOf(ch) + 1);
    }
    chars.Add(ch);

    index++;
}
Console.WriteLine(index);




