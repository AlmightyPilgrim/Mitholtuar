using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mitholtuar.Domain.WhatMakesASoldier.MeleeSubClasses;
using Mitholtuar.Domain.WhatMakesASoldier.RangedSubClasses;

namespace MitholtuarWarfare
{
    class Program
    {
        static void Main(string[] args)
        {
            Axe axeSoldier = new Axe();
            Sword swordSoldier = new Sword();
            Spear spearSoldier = new Spear();

            Bow bowSoldier = new Bow();
            Crossbow cbSoldier = new Crossbow();
            Javelin javelinSoldier = new Javelin();

            string choice = "y";

            while (choice == "y")
            {
                Console.WriteLine("Which Unit of your army do you wish to view:" +
                    "\nMelee \tRanged\nPlease select one to view");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "Melee":
                        Console.Clear();
                        Console.WriteLine("There are 3 types of melee units in this army:" +
                            "\nSword \tAxe \tSpear\nSelect one");
                        answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "Sword":
                                swordSoldier.Health();
                                swordSoldier.Armor();
                                swordSoldier.Attack();
                                swordSoldier.speed();
                                break;
                            case "Axe":
                                axeSoldier.Health();
                                axeSoldier.Armor();
                                axeSoldier.Attack();
                                axeSoldier.speed();
                                break;
                            case "Spear":
                                spearSoldier.Health();
                                spearSoldier.Armor();
                                spearSoldier.Attack();
                                spearSoldier.speed();
                                break;
                            default:
                                Console.WriteLine($"{answer} is not a feature of this army.");
                                break;
                        }
                        break;
                    case "Ranged":
                        Console.Clear();
                        Console.WriteLine("There are 3 types of melee units in this army:" +
                            "\nBow \tCrossbow \tJavelin\nSelect one");
                        answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "Bow":
                                bowSoldier.Health();
                                bowSoldier.Armor();
                                bowSoldier.Attack();
                                bowSoldier.speed();
                                break;
                            case "Crossbow":
                                cbSoldier.Health();
                                cbSoldier.Armor();
                                cbSoldier.Attack();
                                cbSoldier.speed();
                                break;
                            case "Javelin":
                                javelinSoldier.Health();
                                javelinSoldier.Armor();
                                javelinSoldier.Attack();
                                javelinSoldier.speed();
                                break;
                            default:
                                Console.WriteLine($"{answer} is not a feature of this army.");
                                break;
                        }
                        break;
                }
                Console.WriteLine("Do you wish to continue viewing your army? y/n");
                choice = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
