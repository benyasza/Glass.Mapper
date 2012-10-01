﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glass.Mapper.Configuration.Attributes
{
    public abstract class LinkedAttribute : AbstractPropertyAttribute
    {
        public LinkedAttribute()
        {
            IsLazy = true;
        }
        /// <summary>
        /// Indicates if linked items should be loaded lazily. Default value is true. If false linked items will be loaded when the contain object is created.
        /// </summary>
        public bool IsLazy
        {
            get;
            set;
        }
    }
}
