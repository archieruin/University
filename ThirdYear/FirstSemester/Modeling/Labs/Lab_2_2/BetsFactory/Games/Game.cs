using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_2.BetsFactory.Games
{
    public abstract class Game
    {
        public string Name { get; set; }

        protected abstract bool Roll();
        protected abstract GameType GetGameType();
    }
}
