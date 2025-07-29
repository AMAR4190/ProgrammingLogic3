namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.animalSound();
        Animal tom = new Cat();
        tom.animalSound();
        Animal chibou = new Dog();
        chibou.animalSound();
    }
}

class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}
class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}
