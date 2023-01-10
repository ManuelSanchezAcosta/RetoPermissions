﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsWebApi.Application
{
    public interface ICommandHandler<T> where T : class
    {
        CommandResult Execute(T command);
    }
}
