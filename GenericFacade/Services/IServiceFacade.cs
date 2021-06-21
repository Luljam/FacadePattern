using System;
using System.Collections.Generic;
using System.Text;

namespace GenericFacade.Services
{
    public interface IServiceFacade
    {
        Tuple<int, double, string> CallFacade();
    }
}
