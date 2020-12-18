namespace Lab_3_1
{
    abstract class СuisineFactory
    {
        public abstract Soup CreateSoup();
        public abstract Dumplings CreateDumplings();
        public abstract Cake CreateCake();
        public abstract IceCream CreateIceCream();
    }

    class UkrainianСuisine : СuisineFactory
    {
        public override Soup CreateSoup()
        {
            return new UkrainianSoup();
        }

        public override Dumplings CreateDumplings()
        {
            return new UkrainianDumplings();
        }

        public override Cake CreateCake()
        {
            return new UkrainianCake();
        }

        public override IceCream CreateIceCream()
        {
            return new UkrainianIceCream();
        }
    }

    class EasternСuisine : СuisineFactory
    {
        public override Soup CreateSoup()
        {
            return new EasternSoup();
        }

        public override Dumplings CreateDumplings()
        {
            return new EasternDumplings();
        }

        public override Cake CreateCake()
        {
            return new EasternCake();
        }

        public override IceCream CreateIceCream()
        {
            return new EasternIceCream();
        }
    }
    
    abstract class Soup
    {
        public string category = "Первое блюдо";
        public abstract string Name { get; }
        public abstract string GetIngredients();
    }

    abstract class Dumplings
    {
        public string category = "Второе блюдо";
        public abstract string Name { get; }
        public abstract string GetIngredients();
    }

    abstract class Cake
    {
        public string category = "Десерт";
        public abstract string Name { get; }
        public abstract string GetIngredients();
    }

    abstract class IceCream
    {
        public string category = "Десерт";
        public abstract string Name { get; }
        public abstract string GetIngredients();
    }

    class UkrainianSoup : Soup
    {
        public override string Name { get; }

        public UkrainianSoup()
        {
            Name = "Украинский суп";
        }

        public override string GetIngredients()
        {
            return "Картофель - 3 шт.\n" +
                   "Вода - 1,5-2 л\n" +
                   "Морковь - 1 шт.\n" +
                   "Лук репчатый - 1 шт.\n" +
                   "Масло сливочное - 50 г\n" +
                   "Лавровый лист - 1 шт.\n" +
                   "Перец черный - 1 щепотка\n" +
                   "Зелень укропа - 3 веточки\n" +
                   "Зелень петрушки - 3 веточки\n" +
                   "Соль - 0,5 ч. ложки\n" +
                   "Мука - 100-120 г\n" +
                   "Яйца - 1 шт.";
        }
    }

    class UkrainianDumplings : Dumplings
    {
        public override string Name { get; }

        public UkrainianDumplings()
        {
            Name = "Украинские пельмени";
        }

        public override string GetIngredients()
        {
            return "Для начинки:\n" +
                   "Фарш мясной (курица + свинина) – 700 г\n" +
                   "Лук репчатый – 1 шт.\n" +
                   "Чеснок – 2 зубчика\n" +
                   "Зелень укропа – 1 небольшой пучок\n" +
                   "Перец чёрный молотый – по вкусу\n" +
                   "Соль – по вкусу\n\n" +
                   "Для теста (стакан - 250 мл):\n" +
                   "Мука – 3 стакана\n" +
                   "Яйцо – 1 шт.\n" +
                   "Масло растительное – 3 ст. ложки\n" +
                   "Соли – 0,5 ч. ложки\n" +
                   "Кипяток – 1 стакан";
        }
    }

    class UkrainianCake : Cake
    {
        public override string Name { get; }

        public UkrainianCake()
        {
            Name = "Киевский торт";
        }

        public override string GetIngredients()
        {
            return "Для коржей:\n" +
                   "Белки яичные – 12 шт.\n" +
                   "Мука – 100 г\n" +
                   "Сахар – 500 г\n" +
                   "Орехи – 350 г\n" +
                   "Ванильный сахар – 20 г\n\n" +
                   "Для крема:\n" +
                   "Масло сливочное – 500 г\n" +
                   "Желтки – 12 шт.\n" +
                   "Молоко – 350 г\n" +
                   "Сахар – 300 г\n" +
                   "Какао – 20 г\n" +
                   "Ванильный сахар – 10 г\n" +
                   "Мука – 4 ст. л.\n" +
                   "Коньяк – 2 ст. ложки\n" +
                   "Для украшения:\n" +
                   "Шоколад - 1 плитка";
        }
    }

    class UkrainianIceCream : IceCream
    {
        public override string Name { get; }

        public UkrainianIceCream()
        {
            Name = "Украинский пломбир";
        }

        public override string GetIngredients()
        {
            return "Молоко - 300 мл\n" +
                   "Сливки - 300 мл\n" +
                   "Яйца куриные - 4 шт.\n" +
                   "Сахар - 120 г\n" +
                   "Сахар ванильный - 1/2 ч. ложки\n" +
                   "Шоколад для украшения - 50 г\n";
        }
    }

    class EasternSoup : Soup
    {
        public override string Name { get; }

        public EasternSoup()
        {
            Name = "Суп-лагман";
        }

        public override string GetIngredients()
        {
            return "Мякоть говяжья - 400 г\n" +
                   "Лук - 1 шт.\n" +
                   "Редька - 1 шт.\n" +
                   "Помидоры - 2 шт.\n" +
                   "или томат-паста - 1-2 ст. ложки\n" +
                   "Вода - 2,5 стакана\n" +
                   "Чеснок - 6 зубчиков\n" +
                   "Масло растительное - 30 г\n" +
                   "Соль - по вкусу\n" +
                   "Перец красный молотый - по вкусу\n" +
                   "Зелень - по вкусу\n\n" +
                   "Для лапши:\n" +
                   "Мука - 2 стакана\n" +
                   "Вода - 0,7-1 стакан\n" +
                   "Соль - 1 щепотка\n" +
                   "Масло растительное - 1-2 ч. ложки\n" +
                   "или готовая лапша - 400 г\n";
        }
    }

    class EasternDumplings : Dumplings
    {
        public override string Name { get; }

        public EasternDumplings()
        {
            Name = "Манты";
        }

        public override string GetIngredients()
        {
            return "Телятина - 1 кг\n" +
                   "Лук репчатый - 3 шт.\n" +
                   "Чеснок - 3 зубчика\n" +
                   "Мука - 0,5 кг\n" +
                   "Яйцо – 1 шт.\n" +
                   "Вода - сколько возьмет тесто\n" +
                   "Соль - по вкусу\n" +
                   "Смесь свежемолотых перцев – 1 ч.л. (по вкусу)\n" +
                   "Черный свежемолотый перец – 1 ч.л. (по вкусу)\n";
        }
    }

    class EasternCake : Cake
    {
        public override string Name { get; }

        public EasternCake()
        {
            Name = "Турецкий маковый торт";
        }

        public override string GetIngredients()
        {
            return "Для сиропа\n" +
                   "200 г сахар\n" +
                   "250 мл вода\n" +
                   "несколько капель лимонный сок\n\n" +
                   "Для теста\n" +
                   "4 шт. яйца\n" +
                   "200 г сахар\n" +
                   "200 г манная крупа\n" +
                   "170 г мак\n" +
                   "250 г масло растительное\n\n" +
                   "Для крема\n" +
                   "250 г творог обезжиренный\n" +
                   "6 ч. л. San Apart стабилизатор* (не обязательно)\n" +
                   "400 г сливки охлажденные\n\n" +
                   "Для украшения\n" +
                   "кокосовая стружка\n";
        }
    }

    class EasternIceCream : IceCream
    {
        public override string Name { get; }

        public EasternIceCream()
        {
            Name = "Дондурма";
        }

        public override string GetIngredients()
        {
            return "Молоко (лучше всего козье, но и коровье подойдет) – 500 мл.\n" +
                   "Сахар —  170 гр.\n" +
                   "Салеп – 1,5 чайной ложки.\n" +
                   "Ванильный сахар  — 1 пакетик .";
        }
    }
}