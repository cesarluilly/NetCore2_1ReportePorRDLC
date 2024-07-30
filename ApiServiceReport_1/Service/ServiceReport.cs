using AspNetCore.Reporting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiServiceReport_1.Service
{
    public class ServiceReport : IServiceReport
    {
        public byte[] CreateReportFile(string pathRdlc)
        {

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            List<Class1> l = new List<Class1>();
            l.Add(new Class1
            {
                FirstName = "mathus",
                LastName = "nakpansua",
                Email = "mathus057@gmail.com",
                Phone = "0839999999"
            });

            report.AddDataSource("DataSet1", l);
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }
    }
}
