using System;
using System.Linq;
using System.Collections.Generic;

namespace Task03_Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int index = -1;

            while(true)
            {
                string[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                if(comand[0].ToUpper() == "END")
                {
                    break;
                }
                
                else if(comand[0].ToUpper() == "SHOOT")
                {
                    index = int.Parse(comand[1]);
                    if(index >= 0 && index <= targets.Count - 1)
                    {
                        int power = int.Parse(comand[2]);
                        targets[index] -= power;
                        if(targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }

                else if (comand[0].ToUpper() == "ADD")
                {
                    index = int.Parse(comand[1]);
                    if (index >= 0 && index <= targets.Count - 1)
                    {
                        int value = int.Parse(comand[2]);
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }

                else if (comand[0].ToUpper() == "STRIKE")
                {
                    index = int.Parse(comand[1]);
                    int radius = int.Parse(comand[2]);
                    int helpValueLeft = index - radius;
                    int helpValueRight = index + radius;
                    if (helpValueLeft >= 0 && helpValueRight <= targets.Count - 1)
                    {
                        for (int i = helpValueRight; i >= helpValueLeft; i--)
                        {
                            targets.RemoveAt(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }

                }

            }
            
            Console.WriteLine(string.Join('|', targets));
        }
    }
}
