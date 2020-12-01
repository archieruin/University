using System;
using System.Windows.Forms;

/*
Factories:
    abstract classes:
        - TiresFactory
        
    classes:
        - JeepTiresFactory : TiresFactory
        - CoupeTiresFactory : TiresFactory
        - SUVTiresFactory : TiresFactory
    
Products:
    abstract classes:
        - SummerTire
        - WinterTire
        - AllSeasonTire

    classes:
        - JeepSummerTire : SummerTire
        - JeepWinterTire : WinterTire
        - JeepAllSeasonTire : AllSeasonTire
        
        - CoupeSummerTire : SummerTire
        - CoupeWinterTire : WinterTire
        - CoupeAllSeasonTire : AllSeasonTire
        
        - SUVSummerTire : SummerTire
        - SUVWinterTire : WinterTire
        - SUVAllSeasonTire : AllSeasonTire
*/

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
    
    public partial class Form1 : Form
    {
        TiresFactory _tiresFactory;
        public Form1()
        {
            InitializeComponent();
            carTypeBox.Items.Add("Джип");
            carTypeBox.Items.Add("Купе");
            carTypeBox.Items.Add("Внедорожник");
            carTypeBox.SelectedIndex = 0;
        }

        private void carTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tiresFactory = carTypeBox.SelectedIndex switch
            {
                0 => new JeepTiresFactory(),
                1 => new CoupeTiresFactory(),
                2 => new SUVTiresFactory(),
                _ => new JeepTiresFactory()
            };
            FillTiresTypeBox(_tiresFactory);
        }

        private void tiresTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = "";
            switch (tiresTypeBox.SelectedIndex)
            {
                case 0:
                    var summerTires = _tiresFactory.CreateSummerTire();
                    text = $"Название: {summerTires.Name}\n\n";
                    text += $"Категория: {summerTires.season}\n\n";
                    text += $"Информация:\n{summerTires.GetInfo()}";
                    break;
                case 1:
                    var winterTires = _tiresFactory.CreateWinterTire();
                    text = $"Название: {winterTires.Name}\n\n";
                    text += $"Категория: {winterTires.season}\n\n";
                    text += $"Информация:\n{winterTires.GetInfo()}";
                    break;
                case 2:
                    var allSeasonTires = _tiresFactory.CreateAllSeasonTire();
                    text = $"Название: {allSeasonTires.Name}\n\n";
                    text += $"Категория: {allSeasonTires.season}\n\n";
                    text += $"Информация:\n{allSeasonTires.GetInfo()}";
                    break;
            }
            resultTextBox.Text = text;
        }

        private void FillTiresTypeBox(TiresFactory tiresFactory)
        {
            tiresTypeBox.Items.Clear();
            tiresTypeBox.Items.Add(tiresFactory.CreateSummerTire().Name);
            tiresTypeBox.Items.Add(tiresFactory.CreateWinterTire().Name);
            tiresTypeBox.Items.Add(tiresFactory.CreateAllSeasonTire().Name);
            tiresTypeBox.Enabled = true;
            tiresTypeBox.SelectedIndex = 0;
        }
    }
}