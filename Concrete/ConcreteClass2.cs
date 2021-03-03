﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateMethodPattern.Abstract;

namespace TemplateMethodPattern.Concrete
{
    // Usually, concrete classes override only a fraction of base class'
    // operations.
    public class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass2 says: Implemented Operation1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass2 says: Implemented Operation2");
        }

        protected override void Hook1()
        {
            Console.WriteLine("ConcreteClass2 says: Overridden Hook1");
        }
    }

}
