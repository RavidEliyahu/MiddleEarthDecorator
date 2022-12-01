# MiddleEarthDecorator
![decorator](https://user-images.githubusercontent.com/46108499/205066092-334c3400-c557-41d7-8b0c-86ec3c6d092d.png)
<br>
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
## Structure 
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

![Untitled Workspace (4)](https://user-images.githubusercontent.com/46108499/205107333-7f074a1a-5f90-4091-9ebe-27a917ff0771.png)
Influenced by: [refactoring.guru](https://refactoring.guru/design-patterns/decorator) 
