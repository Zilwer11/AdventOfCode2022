// See https://aka.ms/new-console-template for more information
using System.Collections;

//Console.WriteLine("Day 1");
//string[] calories = System.IO.File.ReadAllLines(@"D:\OneDrive\Documents\AdventOfCode\1\input.txt");
//int highest = 0;
//int second = 0;
//int third = 0;
//int sum = 0;
//foreach (string line in calories)
//{



//    if (line.Length > 0)
//    {
//        sum += int.Parse(line);

//    }
//    if (line.Length == 0)
//    {

//        if (sum > highest)
//        {
//            if (highest > second)
//            {
//                if (second > third)
//                {
//                    third = second;
//                }
//                second = highest;
//            }
//            highest = sum;
//        }
//        sum = 0;
//    }


//}


//Console.WriteLine("Highest:" + highest);
//Console.WriteLine("Second:" + second);
//Console.WriteLine("Third:" + third);
//int total = highest + second + third;
//Console.WriteLine("Total:" + total);


//Console.WriteLine();
//Console.WriteLine("Day 2");
//string[] rockpaperscissors = System.IO.File.ReadAllLines(@"D:\OneDrive\Documents\AdventOfCode\2\input.txt");
//int score = 0;
//foreach (string line in rockpaperscissors)
//{
//    if (line.StartsWith("A"))
//    {
//        if (line.EndsWith("X"))
//        {
//            score += 3;
//            score += 0;
//        }
//        if (line.EndsWith("Y"))
//        {
//            score += 1;
//            score += 3;
//        }
//        if (line.EndsWith("Z"))
//        {
//            score += 2;
//            score += 6;
//        }
//    }
//    if (line.StartsWith("B"))
//    {
//        if (line.EndsWith("X"))
//        {
//            score += 1;
//            score += 0;
//        }
//        if (line.EndsWith("Y"))
//        {
//            score += 2;
//            score += 3;
//        }
//        if (line.EndsWith("Z"))
//        {
//            score += 3;
//            score += 6;
//        }
//    }
//    if (line.StartsWith("C"))
//    {
//        if (line.EndsWith("X"))
//        {
//            score += 2;
//            score += 0;
//        }
//        if (line.EndsWith("Y"))
//        {
//            score += 3;
//            score += 3;
//        }
//        if (line.EndsWith("Z"))
//        {
//            score += 1;
//            score += 6;
//        }
//    }
//}
//Console.WriteLine(score);






//Console.WriteLine("Day 3");
//string[] rucksacks = File.ReadAllLines(@"D:\OneDrive\Documents\AdventOfCode\3\input.txt");
//List<String> conversion = File.ReadAllLines(@"D:\OneDrive\Documents\AdventOfCode\3\values.txt").ToList();
//int totalpriority = 0;
//for(int i= 0; i < rucksacks.Length;i++)
//{
//    char[] elf1 = rucksacks[i].ToArray();
//    char[] elf2 = rucksacks[++i].ToArray();
//    char[] elf3 = rucksacks[++i].ToArray();



//    char[] possiblebadges = elf1.Where(c => elf2.Contains(c)).ToArray();
//    char badge = possiblebadges.Where(c => elf3.Contains(c)).First();
//    Console.WriteLine(badge);

//    int priority = conversion.IndexOf(badge.ToString()) + 1;
//    totalpriority += priority;

//}


//foreach(string rucksack in rucksacks)
//{
//    string compartment1 = rucksack.Substring(0,rucksack.Length / 2);
//    string compartment2 = rucksack.Substring(rucksack.Length / 2);
//    bool found = false;
//    foreach(char c in compartment1)
//    {
//        if (found)
//        {
//            break;
//        }
//        foreach (char c2 in compartment2)
//        {
//            if (found)
//            {
//                break;
//            }
//            if(c == c2)
//            {


//                int priority = conversion.IndexOf(c.ToString())+1;
//                Console.WriteLine(priority);
//                totalpriority += priority;
//                found = true;
//            }
//        }
//    }

//    Console.WriteLine(compartment1 + " " + compartment2);   
//}
//Console.WriteLine(totalpriority)
//
//DAY4;

//string[] cleaningpairs = File.ReadAllLines(@"D:\OneDrive\Documents\AdventOfCode\4\input.txt");
//int amountOfPairs = 0;

//foreach (string line in cleaningpairs)
//{
//    string elf1 = line.Split(',').First();
//    string elf2 = line.Split(',').Last();
//    int first = Convert.ToInt32(elf1.Split('-').First());
//    int second = Convert.ToInt32(elf1.Split('-').Last());
//    int third = Convert.ToInt32(elf2.Split('-').First());
//    int fourth = Convert.ToInt32(elf2.Split('-').Last());

//    if ((first >= third && second <= fourth) || (first <= third && second >= fourth))
//    {
//        amountOfPairs++;
//    }


//}

//foreach (string line in cleaningpairs)
//{
//    string elf1 = line.Split(',').First();
//    string elf2 = line.Split(',').Last();
//    int first = Convert.ToInt32(elf1.Split('-').First());
//    int second = Convert.ToInt32(elf1.Split('-').Last());
//    int third = Convert.ToInt32(elf2.Split('-').First());
//    int fourth = Convert.ToInt32(elf2.Split('-').Last());

//    if ((first <= third && second >= third) || (first <= fourth && second >= fourth) || (third >= first && fourth <= first) || (third <= first && fourth >= second))
//    {
//        amountOfPairs++;
//    }
//}
//Console.WriteLine(amountOfPairs);


//DAY5
//string[] movinginstructions = File.ReadAllLines(@"D:\OneDrive\Documents\AdventOfCode\5\input.txt");


//List<Stack<char>> stacks = new List<Stack<char>>();
//stacks.Add(new Stack<char>());
//stacks.Add(new Stack<char>());
//stacks.Add(new Stack<char>());
//stacks.Add(new Stack<char>());
//stacks.Add(new Stack<char>());
//stacks.Add(new Stack<char>());
//stacks.Add(new Stack<char>());
//stacks.Add(new Stack<char>());
//stacks.Add(new Stack<char>());
//stacks.Add(new Stack<char>());




//for (int i = 7; i>= 0; i--)
//{

//    int index = 2;
//    foreach (char c in movinginstructions[i])
//    {
//        if (c != ' ' && c!= '[' && c != ']')
//        {
//            stacks[(index/4)+1].Push(c);
//        }
//        index++;


//    }
//}

//foreach(Stack<char> stack in stacks)
//{
//    foreach(char c in stack)
//    {
//        Console.WriteLine( stacks.IndexOf(stack).ToString() + c);
//    }
//}

//foreach(string instruction in movinginstructions)
//{
//    if (instruction.StartsWith("move"))
//    {
//        Console.WriteLine(instruction);
//        string[] instructions = instruction.Split(' ');
//        int amount = Convert.ToInt32(instructions[1]),
//            from = Convert.ToInt32(instructions[3]), 
//            to = Convert.ToInt32(instructions[5]);

//        for (int i = 0; i < amount; i++)
//        {
//            stacks[0].Push(stacks[from].Pop());          
//        }
//        for (int i = 0; i < amount; i++)
//        {
//            stacks[to].Push(stacks[0].Pop());
//        }


//    }
//}
//Console.WriteLine("       ");
//foreach (Stack<char> stack in stacks)
//{
//    if (stack.Count > 0)
//    {
//        Console.Write(stack.Peek());
//    }

//}

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




