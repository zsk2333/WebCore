﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore.Fileters
{
    public class MyTypeFilterAttribute : TypeFilterAttribute
    {
        public MyTypeFilterAttribute(Type type) : base(type)
        {
        }
    }
}
