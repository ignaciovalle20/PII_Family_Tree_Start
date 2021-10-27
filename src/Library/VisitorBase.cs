using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public abstract class VisitorBase 
    {
        public abstract void Visit(Node node);
    }
}
