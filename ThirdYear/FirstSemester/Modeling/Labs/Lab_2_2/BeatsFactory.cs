using System;

namespace Lab_2_2
{
    public class BeatsFactory
    {
        public Game CreateGame(GameType gameType, string title, double leftTeamCoef, double rightTeamCoef)
        {
            Game game;

            switch (gameType)
            {
                case GameType.Dota:
                    game = new Dota(title, leftTeamCoef, rightTeamCoef);
                    break;
                case GameType.Csgo:
                    game = new Csgo(title, leftTeamCoef, rightTeamCoef);
                    break;
                case GameType.FootBall:
                    game = new FootBall(title, leftTeamCoef, rightTeamCoef);
                    break;
                case GameType.BasketBall:
                    game = new BasketBall(title, leftTeamCoef, rightTeamCoef);
                    break;
                default:
                    throw new ArgumentException("An invalid Game Type: " + gameType);
            }

            return game;
        }
    }

    public abstract class Game
    {
        protected string Title { get; }
        protected double LeftTeamCoef { get; }
        protected double RightTeamCoef { get; }

        protected Game(string title, double leftTeamCoef, double rightTeamCoef)
        {
            Title = title;
            LeftTeamCoef = leftTeamCoef;
            RightTeamCoef = rightTeamCoef;
        }

        public abstract string GetCoefs();
    }

    public enum GameType
    {
        Dota,
        Csgo,
        FootBall,
        BasketBall
    }

    public class Dota : Game
    {
        public Dota(string title, double leftTeamCoef, double rightTeamCoef) 
            : base(title, leftTeamCoef, rightTeamCoef) { }

        public override string GetCoefs()
        {
            return $"Type: Dota, Title: {Title}, Coefs: {LeftTeamCoef} x {RightTeamCoef}";
        }
    }

    public class Csgo : Game
    {
        public Csgo(string title, double leftTeamCoef, double rightTeamCoef) 
            : base(title, leftTeamCoef, rightTeamCoef) { }

        public override string GetCoefs()
        {
            return $"Type: CS:GO, Title: {Title}, Coefs: {LeftTeamCoef} x {RightTeamCoef}";
        }
    }

    public class FootBall : Game
    {
        public FootBall(string title, double leftTeamCoef, double rightTeamCoef) 
            : base(title, leftTeamCoef, rightTeamCoef) { }

        public override string GetCoefs()
        {
            return $"Type: FootBall, Title: {Title}, Coefs: {LeftTeamCoef} x {RightTeamCoef}";
        }
    }

    public class BasketBall : Game
    {
        public BasketBall(string title, double leftTeamCoef, double rightTeamCoef) 
            : base(title, leftTeamCoef, rightTeamCoef) { }

        public override string GetCoefs()
        {
            return $"Type: BasketBall, Title: {Title}, Coefs: {LeftTeamCoef} x {RightTeamCoef}";
        }
    }
}