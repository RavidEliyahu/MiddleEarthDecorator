using MiddleEarthDecorator;

ICharacter noob = new Men();
ICharacter wizard = new Wizard(new Elf());
ICharacter warrior = new Warrior(new Dwarf());
ICharacter archer = new Archer(new Men());
ICharacter ranger = new Warrior(new Archer(new Elf()));
ICharacter paladin = new Wizard(new Warrior(new Men()));
ICharacter character = new Wizard(new Warrior(new Archer(new Men())));

Console.WriteLine($"The Noob equipment options:\n{noob.Equipment()}\nATK: {noob.GetAttackPower()}\nRace: {noob.GetRaceName()}\n");
Console.WriteLine($"The Archer equipment options:\n{archer.Equipment()}\nATK: {archer.GetAttackPower()}\nRace: {archer.GetRaceName()}\n");
Console.WriteLine($"The Wizard equipment options:\n{wizard.Equipment()}\nATK: {wizard.GetAttackPower()}\nRace: {wizard.GetRaceName()}\n");
Console.WriteLine($"The Warrior equipment options:\n{warrior.Equipment()}\nATK: {warrior.GetAttackPower()}\nRace: {warrior.GetRaceName()}\n");
Console.WriteLine($"The Ranger equipment options:\n{ranger.Equipment()}\nATK: {ranger.GetAttackPower()}\nRace: {ranger.GetRaceName()}\n");
Console.WriteLine($"The Paladin equipment options:\n{paladin.Equipment()}\nATK: {paladin.GetAttackPower()}\nRace: {paladin.GetRaceName()}\n");
Console.WriteLine($"The Hero equipment options:\n{character.Equipment()}\nATK: {character.GetAttackPower()}\nRace: {character.GetRaceName()}\n");