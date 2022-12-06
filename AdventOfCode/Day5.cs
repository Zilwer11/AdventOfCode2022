using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day5
    {
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
    }
}
