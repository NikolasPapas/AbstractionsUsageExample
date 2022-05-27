using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAbstractionsApplication.Common.Interfaces;
using TestAbstractionsApplication.CompanyImplementation;
using TestAbstractionsApplication.CustomerImplementation;
using TestAbstractionsApplication.EmployerImplementation;

namespace TestAbstractionsApplication.Common.Implementations
{
    public class HandlerFactory : IHandlerFactory
    {
        private readonly IServiceProvider _provider;
        public HandlerFactory(IServiceProvider provider)
        {
            _provider = provider;
        }

        public IHandler Create(string applicationType)
        {
            if (string.Equals(applicationType, CompanyHandler.Type))
                return (IHandler)ActivatorUtilities.CreateInstance(_provider, Type.GetType("TestAbstractionsApplication.CompanyImplementation.CompanyHandler, TestAbstractionsApplication.CompanyImplementation")); //<CompanyHandler>
            else if (string.Equals(applicationType, EmployerHandler.Type))
                return (IHandler)ActivatorUtilities.CreateInstance(_provider, Type.GetType("TestAbstractionsApplication.EmployerImplementation.EmployerHandler, TestAbstractionsApplication.EmployerImplementation")); //<EmployerHandler>
            else if (string.Equals(applicationType, CustomerHandler.Type))
                return (IHandler)ActivatorUtilities.CreateInstance(_provider, Type.GetType("TestAbstractionsApplication.CustomerImplementation.CustomerHandler, TestAbstractionsApplication.CustomerImplementation")); //<CustomerHandler>
            return null;
        }
    }
}
