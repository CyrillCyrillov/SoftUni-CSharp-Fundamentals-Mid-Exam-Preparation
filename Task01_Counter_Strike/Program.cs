using System;

namespace Task01_Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wins = 0;
            bool isNotEnoughEnergy = false;

            while (true)
            {
                string nextTarget = Console.ReadLine();

                if(nextTarget.ToUpper() == "END OF BATTLE")
                {
                    break;
                }

                int needEnergy = int.Parse(nextTarget);

                if(energy - needEnergy >= 0)
                {
                    energy -= needEnergy;
                    wins += 1;

                    if(wins % 3 == 0)
                    {
                        energy += wins;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    isNotEnoughEnergy = true;
                    break;
                }

            }
            
            if(!isNotEnoughEnergy)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
            }
            
        }
    }
}
