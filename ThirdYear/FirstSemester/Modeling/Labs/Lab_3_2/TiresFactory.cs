namespace Lab_3_2
{
    abstract class TiresFactory
    {
        public abstract SummerTire CreateSummerTire();
        public abstract WinterTire CreateWinterTire();
        public abstract AllSeasonTire CreateAllSeasonTire();
    }
    
    class JeepTiresFactory : TiresFactory {
        public override SummerTire CreateSummerTire()
        {
            return new JeepSummerTire();
        }

        public override WinterTire CreateWinterTire()
        {
            return new JeepWinterTire();
        }

        public override AllSeasonTire CreateAllSeasonTire()
        {
            return new JeepAllSeasonTire();
        }
    }
    
    class CoupeTiresFactory : TiresFactory {
        public override SummerTire CreateSummerTire()
        {
            return new CoupeSummerTire();
        }

        public override WinterTire CreateWinterTire()
        {
            return new CoupeWinterTire();
        }

        public override AllSeasonTire CreateAllSeasonTire()
        {
            return new CoupeAllSeasonTire();
        }
    }
    
    class SUVTiresFactory : TiresFactory {
        public override SummerTire CreateSummerTire()
        {
            return new SUVSummerTire();
        }

        public override WinterTire CreateWinterTire()
        {
            return new SUVWinterTire();
        }

        public override AllSeasonTire CreateAllSeasonTire()
        {
            return new SUVAllSeasonTire();
        }
    }

    abstract class SummerTire
    {
        public string season = "Лето";
        public abstract string Name { get; }
        public abstract string GetInfo();
    }

    abstract class WinterTire
    {
        public string season = "Зима";
        public abstract string Name { get; }
        public abstract string GetInfo();
    }

    abstract class AllSeasonTire
    {
        public string season = "Любой сезон";
        public abstract string Name { get; }
        public abstract string GetInfo();
    }
    
    class JeepSummerTire : SummerTire
    {
        public override string Name { get; }

        public JeepSummerTire()
        {
            Name = "Летние шины для джипа";
        }

        public override string GetInfo()
        {
            return "Очень классные летние шины для джипа с 10 годами гарании!!!";
        }
    }

    class JeepWinterTire : WinterTire
    {
        public override string Name { get; }

        public JeepWinterTire()
        {
            Name = "Зимние шины для джипа";
        }

        public override string GetInfo()
        {
            return "Очень классные зимние шины для джипа с 5 годами гарании!!!";
        }
    }
    
    class JeepAllSeasonTire : AllSeasonTire
    {
        public override string Name { get; }
        public JeepAllSeasonTire()
        {
            Name = "Шины на все сезоны для джипа";
        }

        public override string GetInfo()
        {
            return "Очень классные шины на все сезоны для джипа с 2 годами гарании!!!";
        }
    }
    
    class CoupeSummerTire : SummerTire {
        public override string Name { get; }
        public CoupeSummerTire()
        {
            Name = "Шины на лето для купе автомобиля";
        }
        
        public override string GetInfo()
        {
            return "Очень классные шины на лето для купе автомобиля с 3 годами гарании!!!";
        }
    }
    class CoupeWinterTire : WinterTire {
        public override string Name { get; }
        public CoupeWinterTire()
        {
            Name = "Шины на зиму для купе автомобиля";
        }
        public override string GetInfo()
        {
            return "Очень классные шины на зиму для купе автомобиля с 8 годами гарании!!!";
        }
    }
    class CoupeAllSeasonTire : AllSeasonTire {
        public override string Name { get; }
        public CoupeAllSeasonTire()
        {
            Name = "Шины на все сезоны для купе автомобиля";
        }
        public override string GetInfo()
        {
            return "Очень классные шины на все сезоны для купе автомобиля с 4 годами гарании!!!";
        }
    }
    class SUVSummerTire : SummerTire
    {
        public override string Name { get; }
        public SUVSummerTire()
        {
            Name = "Шины на лето для внедорожника";
        }
        public override string GetInfo()
        {
            return "Очень классные шины на лето для внедорожника с 6 годами гарании!!!";
        }
    }
    class SUVWinterTire : WinterTire
    {
        public override string Name { get; }
        public SUVWinterTire()
        {
            Name = "Шины на зиму для внедорожника";
        }
        public override string GetInfo()
        {
            return "Очень классные шины на зиму для внедорожника с 4 годами гарании!!!";
        }
    }
    class SUVAllSeasonTire : AllSeasonTire
    {
        public override string Name { get; }
        public SUVAllSeasonTire()
        {
            Name = "Шины на все сезоны для внедорожника";
        }
        public override string GetInfo()
        {
            return "Очень классные шины на все сезоны для внедорожника с 15 годами гарании!!!";
        }
    }
}