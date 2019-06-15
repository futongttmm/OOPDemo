using Characters;
using ConsoleApp1.Characters;
using ConsoleApp1.Characters.Melee;
using ConsoleApp1.Characters.Spellcasters;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int curMelee = 0;
            int curSpellcaster = 0;

            List<Character> characters = new List<Character>()
            {
                new Warrior(), new Warrior(), new Warrior(), new Mage(), new Mage(), new Mage(),
                new Warrior(), new Warrior(), new Warrior(), new Mage(), new Mage(), new Mage(),
                new Warrior(), new Warrior(), new Warrior(), new Mage(), new Mage(), new Mage()
            };

            List<Melees> meleeTeam = new List<Melees>();
            List<Spellcasters> spellcasterTeam = new List<Spellcasters>();

            foreach (var chara in characters)
            {
                if(chara is Melees)
                {
                    meleeTeam.Add((Melees)chara);
                }
                else if(chara is Spellcasters)
                {
                    spellcasterTeam.Add((Spellcasters)chara);
                }
            }

            while (true)
            {
                // 1. Take a random melee from the list
                curMelee = rand.Next(0, meleeTeam.Count);

                // 2. Take a random spellcaster from the list
                curSpellcaster = rand.Next(0, spellcasterTeam.Count);

                // 3. Melees attack spellcasters
                spellcasterTeam[curSpellcaster].TakeDamage(meleeTeam[curMelee].Attacking(), meleeTeam[curMelee].Name);
                // 3.1 Check whether the character died or not, and remove it from its team
                // 3.2 If died, get another character from the list
                if(!spellcasterTeam[curSpellcaster].IsAlive)
                {
                    meleeTeam[curMelee].WonBattle();
                    spellcasterTeam.Remove(spellcasterTeam[curSpellcaster]);
                    if (spellcasterTeam.Count <= 0)
                    {
                        Console.WriteLine( "Melees win!");
                        break;
                    }
                    else
                    {
                        curSpellcaster = rand.Next(0, spellcasterTeam.Count);
                    }
                }

                // 4. Spellcaster attack melees
                meleeTeam[curMelee].TakeDamage(spellcasterTeam[curSpellcaster].Attacking(), spellcasterTeam[curSpellcaster].Name);
                // 4.1 Check whether the character died or not, and remove it from its team
                // 4.2 If died, get another character from the list
                if (!meleeTeam[curMelee].IsAlive)
                {
                    spellcasterTeam[curSpellcaster].WonBattle();
                    meleeTeam.Remove(meleeTeam[curMelee]);
                    if (meleeTeam.Count <= 0)
                    {
                        Console.WriteLine("Spellcasters win!");
                        break;
                    }
                    else
                    {
                        curMelee = rand.Next(0, meleeTeam.Count);
                    }
                }

            }
            
        }
    }
}
