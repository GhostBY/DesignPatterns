﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Abstract
{
    public abstract class NotebookFactory
    {
        public abstract Notebook GetNotebook();
    }
}
