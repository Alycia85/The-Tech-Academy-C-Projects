using System;
using System.Collections.Generic;
using System.Text;

namespace _126_interface_polymorph
{
    public abstract class Person
    {
        public string firsName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();

    }
}
