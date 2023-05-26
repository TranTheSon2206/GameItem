using _26_5._1;

class program
{
    static void Main(string[] args)
    {
        Weapon weapon1 = new Weapon("Emeral Spear", 5, 1000, "Red");
        Weapon weapon2 = new Weapon("God Sword", 6, 4000, "Red");
        Console.WriteLine(weapon1.ToString());
        weapon1.ItemColor();
        Console.WriteLine(weapon2.ToString());
        weapon2.ItemColor();
        Console.WriteLine("\n");

        Armor armor1 = new Armor("Steel Sheild", 6, 2500, "steel");
        Console.WriteLine(armor1.ToString());
        armor1.Defence();
        Armor armor2 = new Armor("Gold Sheild", 4, 1500, "gold");
        Console.WriteLine(armor2.ToString());
        armor2.Defence();
        Console.WriteLine("\n");

        Consumable item1 = new Consumable("Silver Ring", 7, 2540, 600);
        Console.WriteLine(item1.ToString());
        item1.manaGain();
        Consumable item2 = new Consumable("Gold Hat", 4, 1550, 200);
        Console.WriteLine(item2.ToString());
        item2.manaGain();


    }
}