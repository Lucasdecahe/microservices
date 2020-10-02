using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juros.Calculo.Common
{
    public interface IRepository
    {
        Task<double> GetTaxaAsync();
    }
}
