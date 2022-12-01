# MiddleEarthDecorator
This example allow the client to create a character from one of 3 races (Men, Elfs, Dwarves).<br>
In addition you can give it one class or many (Archer, Wizard, Warrior) no matter the order of applience.
<br>
For Example:
```
ICharacter a = new Warrior(new Archer(new Men()));
ICharacter b = new Archer(new Warrior(new Men()));
```
a and b have the same functionallity, power & race.
<br><br>
Another Example:
<br>
```
ICharacter character = new Wizard(new Warrior(new Archer(new Elf())));
```
Now this one above has the greatest power among Elfs because he is wrapped with all of the concrete decorators.
<br>
<br>
## UML 
Componenet:
- ICharacter

Base Decorator:
- Decorator

Concrete Components:
- Men
- Elf
- Dwarf

Concrete Decorators:
- Archer
- Wizard
- Warrior

![Untitled Workspace (3)](https://user-images.githubusercontent.com/46108499/204646307-186d1c4c-52ec-4a42-9f3f-354dca633742.png)
