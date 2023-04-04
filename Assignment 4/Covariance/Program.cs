// See https://aka.ms/new-console-template for more information

//Kovaryans, bir nesne türünün alt sınıfının bir üst sınıfının yerine kullanılabileceği durumlarda kullanılır. 

AnimalShelter shelter = new DogShelter();
Animal animal = shelter.GetAnimal();
animal.MakeSound(); //Köpek havlar.

AnimalShelter shelter1 = new CatShelter();
Animal animal1 = shelter1.GetAnimal();
animal.MakeSound(); //Kedi miyavlar. :)


public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Hayvan ses çıkartır.");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Köpek havlar.");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Kedi miyavlar.");
    }
}

public class AnimalShelter
{
    public virtual Animal GetAnimal()
    {
        return new Animal();
    }
}

public class DogShelter : AnimalShelter
{
    public override Animal GetAnimal()
    {
        return new Dog();
    }
}

public class CatShelter : AnimalShelter
{
    public override Animal GetAnimal()
    {
        return new Cat();
    }
}

