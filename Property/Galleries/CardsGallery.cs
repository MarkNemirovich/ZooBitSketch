﻿using System;
using System.Collections.Generic;
using ZooBitSketch.Enums;
using ZooBitSketch.Property.Actives;

namespace ZooBitSketch.Property.Galleries
{
    internal class CardsGallery : Gallery<Card>
    {
        private Card[] Ordinary()
        {
            return new Card[]
            {
            new Card("Atack1", CardType.Atack, Rareness.Ordinary, Role.Singler,Genre.Rap, RandomStates(Rareness.Ordinary)),
            new Card("Buff1", CardType.Buff, Rareness.Ordinary, Role.Drums,Genre.Rock, RandomStates(Rareness.Ordinary)),
            new Card("Bonus1", CardType.Bonus, Rareness.Ordinary, Role.Guitar,Genre.Pop, RandomStates(Rareness.Ordinary)),
            new Card("Defence1", CardType.Defence, Rareness.Ordinary, Role.Pianist,Genre.Reggae, RandomStates(Rareness.Ordinary)),
            new Card("Growth1", CardType.Growth, Rareness.Ordinary, Role.Pianist,Genre.Reggae, RandomStates(Rareness.Ordinary))
            };
        }
        private Card[] Rare()
        {
            return new Card[]
            {
            new Card("Atack2", CardType.Atack, Rareness.Rare, Role.Singler,Genre.Rap, RandomStates(Rareness.Rare)),
            new Card("Instrument2", CardType.Buff, Rareness.Rare, Role.Drums,Genre.Rock, RandomStates(Rareness.Rare)),
            new Card("Bonus2", CardType.Bonus, Rareness.Rare, Role.Guitar,Genre.Pop, RandomStates(Rareness.Rare)),
            new Card("Defence2", CardType.Defence, Rareness.Rare, Role.Guitar,Genre.Pop, RandomStates(Rareness.Rare)),
            new Card("Growth2", CardType.Growth, Rareness.Rare, Role.Pianist,Genre.Reggae, RandomStates(Rareness.Rare))
         };
        }
        private Card[] Elite()
        {
            return new Card[]
            {
            new Card("Atack3", CardType.Atack, Rareness.Elite, Role.Singler,Genre.Rap, RandomStates(Rareness.Elite)),
            new Card("Buff3", CardType.Buff, Rareness.Elite, Role.Drums,Genre.Rock, RandomStates(Rareness.Elite)),
            new Card("Bonus3", CardType.Bonus, Rareness.Elite, Role.Guitar,Genre.Pop, RandomStates(Rareness.Elite)),
            new Card("Defence3", CardType.Defence, Rareness.Elite, Role.Pianist,Genre.Reggae, RandomStates(Rareness.Elite)),
            new Card("Growth3", CardType.Growth, Rareness.Elite, Role.Pianist,Genre.Reggae, RandomStates(Rareness.Elite))
         };
        }
        private Card[] Epic()
        {
            return new Card[]
            {
            new Card("Atack4", CardType.Atack, Rareness.Epic, Role.Singler,Genre.Rap, RandomStates(Rareness.Epic)),
            new Card("Buff4", CardType.Buff, Rareness.Epic, Role.Drums,Genre.Rock, RandomStates(Rareness.Epic)),
            new Card("Bonus4",CardType.Bonus, Rareness.Epic, Role.Guitar,Genre.Pop, RandomStates(Rareness.Epic)),
            new Card("Defence4", CardType.Defence, Rareness.Epic, Role.Pianist,Genre.Reggae, RandomStates(Rareness.Epic)),
            new Card("Growth4", CardType.Growth, Rareness.Epic, Role.Pianist,Genre.Reggae, RandomStates(Rareness.Epic))
         };
        }
        private Card[] Legendary()
        {
            return new Card[]
            {
            new Card("Atack5", CardType.Atack, Rareness.Legendary, Role.Singler,Genre.Rap, RandomStates(Rareness.Legendary)),
            new Card("Buff5", CardType.Buff, Rareness.Legendary, Role.Drums,Genre.Rock, RandomStates(Rareness.Legendary)),
            new Card("Bonus5", CardType.Bonus, Rareness.Legendary, Role.Guitar,Genre.Pop, RandomStates(Rareness.Legendary)),
            new Card("Defence5", CardType.Defence, Rareness.Legendary, Role.Pianist,Genre.Reggae, RandomStates(Rareness.Legendary)),
            new Card("Growth5", CardType.Growth, Rareness.Legendary, Role.Pianist,Genre.Reggae, RandomStates(Rareness.Legendary))
            };
        }
        public CardsGallery(Rareness rareness) : base()
        {
            allActives.TryAdd(Rareness.Ordinary, Ordinary());
            allActives.TryAdd(Rareness.Rare, Rare());
            allActives.TryAdd(Rareness.Elite, Elite());
            allActives.TryAdd(Rareness.Epic, Epic());
            allActives.TryAdd(Rareness.Legendary, Legendary());
            allActives.TryGetValue(rareness, out Card[] currentPack);
            CurrentPack = currentPack;
        }
    }
}