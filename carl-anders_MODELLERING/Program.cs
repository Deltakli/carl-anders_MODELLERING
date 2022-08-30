Slime s1 = new Slime();
Slime s2 = new Slime();
Hero theHero = new Hero();

s1.name = "Martin";
s2.name = "Micke";

s1.hp -= 10;

Console.WriteLine($"{theHero.name} has {theHero.health}");
Console.WriteLine($"{s1.name} has {s1.hp}");

Console.WriteLine("Attack!");
s1.hp -= 10;

Console.WriteLine($"{s1.name} now has {s1.hp} health left");

Console.WriteLine("Press any key to continue");

Console.ReadKey();

//Console.WriteLine(s1.hp);
//Console.WriteLine(s2.hp);



//Console.ReadLine();
