# MiddleEarthDecorator
This example allow the client to create a character from one of 3 races (Men, Elfs, Dwarves) and give it one class or many (Archer, Wizard, Warrior) no matter the order of applience.<br>
For Example:
```
ICharacter a = new Warrior(new Archer(new Men()));
ICharacter b = new Archer(new Warrior(new Men()));
```
a and b have the same functionallity.

![Untitled Workspace (3)](https://user-images.githubusercontent.com/46108499/204646307-186d1c4c-52ec-4a42-9f3f-354dca633742.png)
