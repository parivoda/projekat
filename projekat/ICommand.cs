﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat
{
    public interface ICommand
    {
        void Execute();
        void Unexecute();
    }
}
