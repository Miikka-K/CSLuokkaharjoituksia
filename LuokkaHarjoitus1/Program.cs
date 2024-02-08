using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuokkaHarjoitus1
{

    class Pet
    {
        // Eats method is explicitly defined to be over written in the subclass with keyword "virtual"
        public virtual void Eats()
        {
            Console.WriteLine("Eats some food");
        }
    }

    class Hare : Pet 
    { 
        // Override allows overwriting base class methods
        public override void Eats()
        {
            Console.WriteLine("Eats some carrots and grass");
        }
    }
    class Hooman
    {
        // Define properties of Hooman ie. fields
        public string name = "Essi Esimerkki";
        public int age = 30;
        public string gender = "Emäntä";

        // Default constructor w/o arguments
        // No need to define, will be created automatically
        public Hooman()
        {

        }

        // Constructor with one argument
        public Hooman(string name)
        {
            this.name = name;
        }

        // Constructor with two arguments
        public Hooman(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Constructor with three arguments
        public Hooman(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;

        }

        // A method to say something
        public void SayOpinion()
        {
            Console.WriteLine("Voi, lemmikit ne on elämän suola");
        }
    }

    class CatOwner : Hooman
    { 
        public new void SayOpinion()
        {
            Console.WriteLine("Kissat ovat itsenäisiä ja pitävät hiiret loitolla");
        }
    }

    class DogOwner : Hooman
    {
        public new void SayOpinion()
        {
            Console.WriteLine("Koirat ovat kyllä mukavempia elukoita kuin kissat");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create (instantiate) a hooman object from Hooman class
            Hooman owner = new Hooman("Ossi Omistaja", 35, "isäntä");

            // Call the SayOpinion method
            owner.SayOpinion();

            //save owners name property to a variable
            string who = owner.name;
            
            // Test it by echoing it to a console
            Console.WriteLine("totesi " + who);

            // Create a new catowner object
            CatOwner catOwner = new CatOwner();

            // Use catowners SayOpinion method
            catOwner.SayOpinion();

            // Create a new dog owner and call sayOpinion method
            DogOwner dogOwner = new DogOwner();
            dogOwner.SayOpinion();



            // Keep the window open until key is pressed
            Console.ReadLine();

            
        }
    }
}
