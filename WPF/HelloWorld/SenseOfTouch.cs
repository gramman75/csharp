using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class SenseOfTouch
    {
        public enum Sense { Hot, Cold }
        public Sense Feel { get; set; }

        public SenseOfTouch()
        {
        }


        public SenseOfTouch(Sense sense)
        {
            this.Feel = sense;
        }

        public override string ToString()
        {
            return this.Feel.ToString();
        }
    }

}
