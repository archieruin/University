namespace Lab_2_2.BetsFactory.Games
{
    public class CsgoGame : Game
    {
        public CsgoGame()
        {
            Name = "CS:GO";
        }

        protected override bool Roll()
        {
            throw new System.NotImplementedException();
        }

        protected override GameType GetGameType()
        {
            return GameType.Csgo;
        }
    }
}