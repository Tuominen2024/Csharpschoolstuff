using System;
using System. Collections.Generic;
using System.Linq;
using System.Text;
using System. Threading.Tasks;

namespace Luokkaharjoituksia
{
    class Hooman
    {
      // Define properties of Hooman ie. fields
      public string name = "Essi Esimerkki";
      public int age = 30;
      Public string gender = "Emäntä";

      // Default constructor w/o arguments
      // No need to dfine, will be created automatically
      public Hooman()
      {

      }

      // Constructor with one argument
        public Hooman(string name)
        {
            this.name = name;
        }

        // Constructor with 2 arguments
        public Hooman(string name, int age)
        {
          this.name =name;
          this.age = age;
        }
          
          // Constructor with 3 arguments
          public Hooman(String name, int age, string gender)
        {   
            this.name = name;
            this. age = age;
            this. gender = gender;
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
          ( Console.WriteLine("Kissa ovat itsenäisiä ja pitävät hiiret loitolla");
          )
      }

      class DogOwner : Hooman

      {

      }

  internal class Program
  {
      static voi Main(string[] args)
        // Create (instantiate) a hooman object from Hooman class
        Hooman owner = new Hooman("Ossi Omistaja, 35, "isäntä");

        // Call the SayOpinion method
        owner.SayOpinion();


        // Save owners name property to a variable
        string who = owner.name;
