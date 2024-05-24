class LivingBeing {
	public bool isAlive;
}
class Animal : LivingBeing {
	public string name;
	public string age;
	public Animal(string name) {
		$"Animal {name} Created".Dump();
	}

	public void Eat() {
		"Eat".Dump();
	}
}
class Fish : Animal {
	public Fish() : base("fish")
	{
		"Fish Created".Dump();
	}
	public void Swim() {
		"Swim".Dump();
	}
}
class Cat : Animal {
	public Cat(string name) : base(name) {
		$"Cat {name} created".Dump();
		this.name = name;
	}
	public void Meow() {
		"Meow".Dump();
	}
	public void Jump() {
		"Jump".Dump();
	}
}

class Program {
	static void Main() {
		Cat cat = new Cat("cibi");
		cat.name.Dump();
		cat.Eat();
		cat.Meow();
		cat.Jump();
		cat.isAlive.Dump();
		
		Fish fish = new Fish();
		fish.Eat();
		fish.Swim();
		
		Animal animal = new Animal("kucing");
		animal.Eat();
		animal.name.Dump();
	}
}