using HeroesDecorator;

IHero noob = new Men();
IHero wizard = new Wizard(new Elf());
IHero warrior = new Warrior(new Dwarf());
IHero archer = new Archer(new Men());
IHero ranger = new Warrior(new Archer(new Elf()));
IHero paladin = new Wizard(new Warrior(new Men()));
IHero hero = new Wizard(new Warrior(new Archer(new Men())));

Console.WriteLine($"The Noob equipment options:\n{noob.Equipment()}\nATK: {noob.GetAttackPower()}\nRace: {noob.GetRaceName()}\n");
Console.WriteLine($"The Archer equipment options:\n{archer.Equipment()}\nATK: {archer.GetAttackPower()}\nRace: {archer.GetRaceName()}\n");
Console.WriteLine($"The Wizard equipment options:\n{wizard.Equipment()}\nATK: {wizard.GetAttackPower()}\nRace: {wizard.GetRaceName()}\n");
Console.WriteLine($"The Warrior equipment options:\n{warrior.Equipment()}\nATK: {warrior.GetAttackPower()}\nRace: {warrior.GetRaceName()}\n");
Console.WriteLine($"The Ranger equipment options:\n{ranger.Equipment()}\nATK: {ranger.GetAttackPower()}\nRace: {ranger.GetRaceName()}\n");
Console.WriteLine($"The Paladin equipment options:\n{paladin.Equipment()}\nATK: {paladin.GetAttackPower()}\nRace: {paladin.GetRaceName()}\n");
Console.WriteLine($"The Hero equipment options:\n{hero.Equipment()}\nATK: {hero.GetAttackPower()}\nRace: {hero.GetRaceName()}\n");