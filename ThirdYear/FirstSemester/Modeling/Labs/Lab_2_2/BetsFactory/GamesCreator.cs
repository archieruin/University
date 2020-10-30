using Lab_2_2.BetsFactory.Games;

namespace Lab_2_2.BetsFactory
{
    public enum GameType
    {
        BasketBall = 0,
        Csgo = 1
    }

    public class GamesCreator
    {
        public Game CreateGame(GameType gameType)
        {
            switch (gameType)
            {
                case GameType.BasketBall:
                    return new BasketBallGame();
                case GameType.Csgo:
                    return new CsgoGame();
                default:
                    return new BasketBallGame();
            }
        }
    }
}