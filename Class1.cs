using System.ComponentModel.DataAnnotations;

namespace EmpClassLib
{
    public class Person
    {

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;

        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public virtual void PrintData()
        {
            Console.WriteLine($"{this.Name} is {this.Age} old");
        }
        
    }
    public abstract class Phone
    {
        public abstract void ContactDeet();
        
    }
    
}