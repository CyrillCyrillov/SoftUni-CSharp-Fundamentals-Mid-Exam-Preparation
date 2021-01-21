using System;
using System.Linq;

namespace Task02_Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int shootTargetsCount = 0;

            while(true)
            {
                string comand = Console.ReadLine();
                if(comand.ToUpper() == "END")
                {
                    break;
                }

                int nextTarget = int.Parse(comand);

                if(nextTarget < 0 || nextTarget > targets.Length - 1 || targets[nextTarget] < 0)
                {
                    continue;
                }
                else
                {
                    int helpVarCurentTarget = targets[nextTarget];
                    targets[nextTarget] = -1;
                    shootTargetsCount += 1;

                    for (int i = 0; i <= targets.Length - 1; i++)
                    {
                        if(targets[i] == -1)
                        {
                            continue;
                        }
                        
                        else if(targets[i] > helpVarCurentTarget)
                        {
                            targets[i] -= helpVarCurentTarget;
                        }
                        
                        else if(targets[i] <= helpVarCurentTarget)
                        {
                            targets[i] += helpVarCurentTarget;
                        }
                    }
                }
            }
            
            Console.Write($"Shot targets: {shootTargetsCount} -> ");
            Console.WriteLine(string.Join(' ', targets));
        }
    }
}
