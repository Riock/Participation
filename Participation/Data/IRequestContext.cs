using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Participation.Classes;

namespace Participation.Data
{
    public interface IRequestContext
    {
        void Cycle(Request request);

        void GetCurrentRequestData();
    }
}
