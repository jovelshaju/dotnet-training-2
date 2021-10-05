using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegeateExcercise
{
    class Participant
    {
        int energyLvl;
        int wProb;
        int spins;
        string name;

        public Participant()
        {
            energyLvl = 1;
            wProb = 100;
            spins = 5;
        }
        public void Start()
        {
            int n;
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            while (this.spins > 0)
            {
                Console.Write("Enter a number between 1 and 10: ");
                n = int.Parse(Console.ReadLine());
                Spin(n);
                spins--;
                Console.WriteLine("Spins left: "+spins);
            }
        }

        public void Spin(int n)
        {
            switch (n)
            {
                case 1:
                    this.energyLvl += 1;
                    this.wProb += 10;
                    break;
                case 2:
                    this.energyLvl += 2;
                    this.wProb += 20;
                    break;
                case 3:
                    this.energyLvl -= 3;
                    this.wProb -= 30;
                    break;
                case 4:
                    this.energyLvl += 4;
                    this.wProb += 40;
                    break;
                case 5:
                    this.energyLvl += 5;
                    this.wProb += 50;
                    break;
                case 6:
                    this.energyLvl -= 1;
                    this.wProb -= 60;
                    break;
                case 7:
                    this.energyLvl += 1;
                    this.wProb += 70;
                    break;
                case 8:
                    this.energyLvl -= 2;
                    this.wProb -= 20;
                    break;
                case 9:
                    this.energyLvl -= 3;
                    this.wProb -= 30;
                    break;
                case 10:
                    this.energyLvl += 10;
                    this.wProb += 100;
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
        }
        public void IsWinner()
        {
            if(this.energyLvl>=4 && this.wProb >= 100)
            {
                Console.WriteLine("You are Winner!");
            }
            else if(this.energyLvl>=1 && this.wProb >= 50)
            {
                Console.WriteLine("You are Runner-up!");
            }
            else
            {
                Console.WriteLine("Sorry you have lost");
            }
        }
    }
}
