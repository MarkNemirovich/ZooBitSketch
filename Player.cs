﻿using System;

namespace ZooBitSketch
{
    internal class Player
    {
        public readonly string Name;
        public int Lvl { get; private set; }
        public int Exp { get; private set; }
        public Purse Purse { get; private set; }
        public Bag Bag { get; private set; }
        public Deck<Card> Deck { get; private set; }
        public Team<Character> Team { get; private set; }
        public Wardrobe<Clothes> Wardrobe { get; private set; }
        private int _maxTeamSize;
        public Player(string name)
        {
            Name = name;
            Lvl = 1;
            Exp = 0;
            _maxTeamSize = 1000;
            Purse = new Purse();
            Bag= new Bag();
            Deck = new Deck<Card>(_maxTeamSize);
            Team = new Team<Character>(_maxTeamSize);
            Wardrobe = new Wardrobe<Clothes>(_maxTeamSize);
        }
        public void AddExp(int exp)
        {
            Exp+=exp;
            if (Exp > Lvl * 100)
                LvlUP();
        }
        private void LvlUP()
        {
            Exp-= Lvl*100;
            Lvl++;
            if(Lvl%5 == 0)
                _maxTeamSize++;
        }
        public void Info()
        {
            Console.WriteLine($"\nName = {Name}\nLvl = {Lvl}\n\nPress any key for continue...");
            Console.ReadKey();
        }
    }
}
