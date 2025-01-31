﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uising_CSharp.Singleton_Pattern
{
    //The Singleton pattern is used to ensure that a class has only one instance,
    //and it provides a global point of access to that instance. In .NET,
    //the Singleton pattern is implemented using a private constructor and a static field that holds
    //the single instance of the class. This pattern is useful when you want to ensure that only one instance of a class is created,
    //and you want to provide a global point of access to that instance.
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object lockObject = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                lock (lockObject) // use for single thread or prevent multi thread or create a single instance.
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }

                return instance;
            }
        }
    }

    
}
