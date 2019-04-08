using System;

namespace ConsoleApp1
{
    abstract class Animal
    {
        protected Boolean isMammal;
        protected Boolean isCarnivorous;

        public Animal(Boolean isMammal, Boolean isCarnivorous)
        {
            this.isMammal = isMammal;
            this.isCarnivorous = isCarnivorous;
        }

        public Boolean getIsMammal()
        {
            return this.isMammal;
        }

        public Boolean getIsCarnivorous()
        {
            return this.isCarnivorous;
        }

        abstract public String getGreeting();

        public void printAnimal(String name)
        {
            Console.WriteLine("A " + name + " says '" + this.getGreeting() + "', is " + (this.getIsCarnivorous() ? "" : "not ")
                    + "carnivorous, and is " + (this.getIsMammal() ? "" : "not ") + "a mammal.");
        }
    }

    class Dog : Animal
    {
        public Dog(Boolean isMammal, Boolean isCarnivorous) : base(isMammal, isCarnivorous)
        {
        }

        public override String getGreeting()
        {
            return "ruff";
        }
    }

    class Cow : Animal
    {
        public Cow(Boolean isMammal, Boolean isCarnivorous) : base(isMammal, isCarnivorous)
        {
        }

        public override String getGreeting()
        {
            return "moo";
        }
    }

    class Duck : Animal
    {

        public Duck(Boolean isMammal, Boolean isCarnivorous) : base(isMammal, isCarnivorous)
        {
        }

        public override String getGreeting()
        {
            return "quack";
        }
    }

    //public class AnimalInheritance
    //{
    //    public static void main(String[] args)
    //    {
    //        Animal dog = new Dog(true, true);
    //        dog.printAnimal("dog");

    //        Animal cow = new Cow(true, false);
    //        cow.printAnimal("cow");

    //        Animal duck = new Duck(false, false);
    //        duck.printAnimal("duck");
    //    }
    //}
    class Program
    {
        public static void Main(String[] args)
        {
            Animal dog = new Dog(true, true);
            dog.printAnimal("dog");

            Animal cow = new Cow(true, false);
            cow.printAnimal("cow");

            Animal duck = new Duck(false, false);
            duck.printAnimal("duck");
            Console.ReadKey();
        }
    }
}
