using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
