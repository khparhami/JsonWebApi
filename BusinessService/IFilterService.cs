using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService
{
    public interface IFilterService
    {
        Show[] FilterShows(Request request);
    }
}
