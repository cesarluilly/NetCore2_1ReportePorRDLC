using ApiServiceReport_1.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiServiceReport_1.Controllers
{
    [Route("report")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private IServiceReport IReport;
        public ReportController(IServiceReport iServiceReport, IHostingEnvironment host)
        {
            IReport = iServiceReport;
            _hostingEnvironment = host;

        }

        [HttpGet]
        [Route("Export_Data")]
        public ActionResult Export_Data()
        {
            var byteRes = new byte[] { };
            string path = _hostingEnvironment.ContentRootPath + "\\Report\\Report.rdlc";
            byteRes = IReport.CreateReportFile(path);

            return File(byteRes,
                System.Net.Mime.MediaTypeNames.Application.Octet,
                "ReportName.pdf");
        }
    }
}
