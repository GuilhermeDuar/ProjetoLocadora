﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class SingleResponse<T> : Response
    {
        public T item { get; set; }
    }
}
