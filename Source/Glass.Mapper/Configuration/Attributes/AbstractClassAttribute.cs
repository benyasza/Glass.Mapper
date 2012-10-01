﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glass.Mapper.Configuration.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public abstract class AbstractClassAttribute : Attribute
    {
        public AbstractClassAttribute()
        { }
    }
}
