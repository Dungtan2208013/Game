
   class Program
    {
        static void Main(string[] args)
        {

        GameItem gameItem = new GameItem();
        gameItem.Name = "A phuc";
        gameItem.Level = "luyen khi";
        gameItem.Score = "320";

        Weapon weapon =new Weapon();
        weapon.sword = "fire sword";
        weapon.gun = "AK47 guns";

        Armor armor = new Armor();
        armor.Shield = "ice shield";
        armor.cloak = "night cloak";
        Console.WriteLine("Hello, World!");

        Consumable comsumable = new Consumable
        {
            bomb = "fire bomb"
        };
        Console.WriteLine(gameItem.Name);
        Console.WriteLine(gameItem.Level);
        Console.WriteLine(gameItem.Score);
        Console.WriteLine(weapon.sword);
        Console.WriteLine(armor.Shield);
        Console.WriteLine(comsumable.bomb);
    }
    }
