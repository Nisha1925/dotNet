// See https://aka.ms/new-console-template for more information

using EmpClassLib;
using System;
class program
{


    static void Main(string[] args)
    {
        //EmpCM();
        //Overriding();
        // UsingAbstract();
        Employee ijk = new Employee("Natasha", 24, "nts@kpmg.com", 20000, 1001);
        ijk.AssignTask();
        ijk.AssignTask(1001, 2003);
    }

    private static void UsingAbstract()
    {
        Phone parent = new PhoneNum() { Number = 7979797 };
        parent.ContactDeet();
    }

    private static void Overriding()
    {
        //Person p = new Person();
        Person parent = new Person("Nisha", 21, "ns@kpmg.com");
        parent.PrintData();


        Console.WriteLine("----Child ch = new Child----");
        Employee child = new Employee("Natasha", 24, "nts@kpmg.com", 20000, 125093);
        child.PrintData();
    }
}

   // public static void EmpCM()
    //{
      //  Person p1 = new Person("Nisha", 21, "ns@kpmg.com");
        //Employee e1 = new Employee("Natasha", 24, "nts@kpmg.com", 20000, 125093);
     //   Employee e2 = new Employee("Jazz", 45, "hfghf@ffcthf.com", 4645, 56477);
       
       // Console.WriteLine($"{p1.Name} of age " +
         //   $"{p1.Age} has a mail id" +
           // $"{p1.Email}");
      //  Console.WriteLine($"{e1.Name} of age {e1.Age} has a salary of {e1.Salary} with emp id {e1.EmpId}");
   // }



