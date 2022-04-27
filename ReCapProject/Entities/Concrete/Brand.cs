using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand :Entity
    {
        public int BrandId { get; set; }
        public String BrandName { get; set; }
    }
}
