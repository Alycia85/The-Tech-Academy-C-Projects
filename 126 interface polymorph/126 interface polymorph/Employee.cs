﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _126_interface_polymorph
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine(firsName + " " + lastName);
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
