namespace Lab_2_2.BetsFactory.Games
{
    public class BasketBallGame : Game
    {
        public BasketBallGame()
        {
            Name = "BasketBall";
        }

        protected override bool Roll()
        {
            throw new System.NotImplementedException();
        }

        protected override GameType GetGameType()
        {
            return GameType.BasketBall;
        }
    }
}