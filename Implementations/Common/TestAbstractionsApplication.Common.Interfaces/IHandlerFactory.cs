using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstractionsApplication.Common.Interfaces
{
    public interface IHandlerFactory
    {
        IHandler Create(string handlerType);

    }
}
