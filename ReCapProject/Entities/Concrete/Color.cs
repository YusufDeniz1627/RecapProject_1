using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color : Entity
    {
        public int ColorId { get; set; }
        public String ColorName { get; set; }
    }
}
