﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains.Core.Presentation.Commands
{
    public interface ICommand
    {
        CommandResult Execute();
    }
}
