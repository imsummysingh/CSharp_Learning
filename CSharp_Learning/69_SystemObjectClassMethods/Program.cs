using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//System.Object class predefined methods example
namespace _69_SystemObjectClassMethods
{
    //Class Person
    //class Person:System.Object
    class Person
    {
        //properties
        public string PersonName { get; set; }
        public string Email { get; set; }


        //Overriding Equals Method
        public override bool Equals(object obj) //->Object obj is equals too system.object class
        {
            //we are typecasting the obj to the person type
            //and we have to compare the value of parameter and the values of the current object.
            
            Person p = (Person)obj;
            if(this.PersonName==p.PersonName && this.Email == p.Email)
            {
                //value matching
                return true;
            }
            else
            {
                return false;
            }
        }

        //Overriding tostring method.
        public override string ToString()
        {
            return "Person Name:" + this.PersonName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create an Object of Person class
            System.Object obj=new Person() { PersonName = "Ranjeet", Email = "rkumar@gmail.com" };

            //access methods -> Equals, GetType, toString, GetHashCode


            //1.Equals-> WIll compare the object=> objPerson with the new obj we created inside it and will return true/false; 
            //Console.WriteLine(obj.Equals(new Person()));    //->False
            //Console.WriteLine(obj.Equals(new Person() { PersonName = "Ranjeet", Email = "rkumar@gmail.com" })); //False(Because they are different objects.)


            //This is the overriden Equals method we are calling and it will compare the values of the object and not the entire object.
            Console.WriteLine(obj.Equals(new Person() { PersonName = "Ranjeet", Email = "rkumar@gmail.com" }));         //True


            //2.GetHashCode
            Console.WriteLine(obj.GetHashCode());

            //3.toString()
            //Console.WriteLine(obj.ToString());  //_69_SystemObjectClassMethods.Person
            
            //now the overriden toString() method will be called
            Console.WriteLine(obj.ToString());      //->Person Name: Ranjeet


            //4. GetType()
            //we cannot override the GetType method from the class
            Console.WriteLine(obj.GetType());       ////_69_SystemObjectClassMethods.Person
            Console.WriteLine(obj.GetType().ToString()); ////_69_SystemObjectClassMethods.Person


            Console.ReadLine();
        }
    }
}
