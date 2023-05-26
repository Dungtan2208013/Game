
   class Program
    {
        static void Main(string[] args)
        {

        GameItem gameItem = new GameItem();
        gameItem.Name = "Test";
        gameItem.Level = "luyen khi";
        gameItem.Score = "320";

        Weapon weapon =new Weapon();
        weapon.sword = "fire sword";
        weapon.guns ="AK47 guns";

        Armor armor = new Armor();
        armor.shield = "ice shield";
        armor.cloak = "night cloak";
        Console.WriteLine("Hello, World!");

        Consumable comsumable = new Consumable
        {
            bomb = "fire bomb"
        };
        Console.WriteLine(gameItem.Name);
        Console.WriteLine(gameItem.Level);
        Console.WriteLine(gameItem.Score);
        Console.WriteLine(weapon);
        Console.WriteLine(armor);
        Console.WriteLine(comsumable);
    }
    }
