﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ZooBitSketch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            do
            {
                Console.Clear();
                Console.WriteLine("Write the name, using only ENG letters.\nNo more than 15 symbols.\nFirst have to be capital.\n");
                name = Console.ReadLine();
            } while (!name.All(char.IsLetter) || (name[0] < 'A' || name[0] > 'Z') || (name.Substring(1).Any(letter => letter >= 'A' && letter <= 'Z')) || (name.Length == 0 || name.Length > 16));
            
            Player player = new Player(name);

            CharacterBox[] boxes = new CharacterBox[6];
            boxes[0] = new CharacterBox("Small box", 100, Currency.Money, BoxSize.Small);
            boxes[1] = new CharacterBox("Middle box", 250, Currency.Money, BoxSize.Middle);
            boxes[2] = new CharacterBox("Large box", 450, Currency.Money, BoxSize.Large);
            boxes[3] = new CharacterBox("Small box", 10, Currency.Diamonds, BoxSize.Small);
            boxes[4] = new CharacterBox("Middle box", 20, Currency.Diamonds, BoxSize.Middle);
            boxes[5] = new CharacterBox("Large box", 45, Currency.Diamonds, BoxSize.Large);
            CharactersShop Shop = new CharactersShop("Characters Shop", boxes);
            string input;
            do
            {
                Console.Clear();
                Console.WriteLine("If you want to get info, choose one of them. For exit write \"exit.\"\n" +
                    "Player\nPurse\nBag\nTeamInfo\nShopInfo\nPurchase\n");
                input = Console.ReadLine();
                switch (input)
                {
                    case "Player": player.Info(); break;
                    case "Purse": player.Purse.Info(); break;
                    case "Bag": player.Bag.Info(); break;
                    case "TeamInfo": player.Team.Info(); break;
                    case "ShopInfo": Shop.Info(player); break;
                    case "Purchase": Shop.Purchase(player); break;
                    default: Console.WriteLine("No such command"); break;
                }
            } while (input != "exit");
        }
    }
}