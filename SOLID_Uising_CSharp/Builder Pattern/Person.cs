﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://medium.com/@gustavorestani/the-most-used-design-patterns-in-net-development-80d76f9fb6b
namespace SOLID_Uising_CSharp.Builder_Pattern
{
    //The Builder pattern is used to separate the construction of a complex object from its representation.
    //In .NET, the Builder pattern is implemented using a separate class or method that constructs the object step by step.
    //This pattern is useful when you want to create complex objects that have many components, and you want to separate the construction
    //logic from the representation.
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    public class PersonBuilder
    {
        private readonly Person person;

        public PersonBuilder()
        {
            person = new Person();
        }

        public PersonBuilder WithFirstName(string firstName)
        {
            person.FirstName = firstName;
            return this;
        }

        public PersonBuilder WithLastName(string lastName)
        {
            person.LastName = lastName;
            return this;
        }

        public PersonBuilder WithAge(int age)
        {
            person.Age = age;
            return this;
        }

        public PersonBuilder WithAddress(string address)
        {
            person.Address = address;
            return this;
        }

        public Person Build()
        {
            return person;
        }
    }
}
