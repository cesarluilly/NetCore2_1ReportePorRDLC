using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiServiceReport_1.Service
{
    public interface IServiceReport
    {
        byte[] CreateReportFile(string pathRdlc);
    }
}
