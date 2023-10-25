using System.Collections.Generic;
using System.Xml.Linq;
Hedgehog hedgehog = new Hedgehog();
hedgehog.Name = "Данил";
hedgehog.Age = 20;
hedgehog.Info();
Console.WriteLine(hedgehog);
Animal animal1 = new Fox();
Animal animal2 = new Sheep();
Animal animal3 = new Wolf();
List<Animal> list = new List<Animal>();
list.Add(animal1);
list.Add(new Sheep());
list.Add(new Wolf());

foreach (var i in list)
{
    i.Move();
}

class Wood
{
    public string name;
    public Wood(string name)
    {
        this.name = name;
    }

}

abstract class Animal
{
    public abstract void Move();
    private string _name;
    private int _age;
    private string _view;

    //свойство
    public string Name
    {
        get => _name;
        set { _name = value; }
    }

    public virtual int Age
    {
        get
        {
            return _age;
        }
        set
        {
            _age = value;
        }
    }
    public virtual void Info()
    {
        Console.WriteLine($"ежик 1: мне {Age} годиков и {Name} зовут");
    }
}
class Sheep: Animal
{
    // мы должны реализовать все абстрактные методы и свойства базового класса
    public override void Move()
    {
        Console.WriteLine("козел идет");
    }
}
// класс самолета
class Fox : Animal
{
    public override void Move()
    {
        Console.WriteLine("лиса ест козла!!!!!");
    }
}
// класс машины
class Wolf : Animal
{
    public override void Move()
    {
        Console.WriteLine("волк наблюдает и ждет, когда тоже покушает!!!!");
    }
}


class Hedgehog : Animal
{
    public override int Age
    {
        get => base.Age;
        set { base.Age = value; }
    }
    public override void Move()
    {
        Console.WriteLine($"ежик 2: мне {Age} годиков, меня зовут {Name}");
    }
    public override string ToString()
    {
        return $"Ёжик типа виртуал там чета: {Age}, зовут {Name} ";
    }
}
