﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.CoisasAFazer.Services.Handlers
{
    public class CommandResult
    {

        public CommandResult(bool sucess)
        {
            IsSucess = sucess;
        }

        public bool IsSucess { get; }

    }
}
