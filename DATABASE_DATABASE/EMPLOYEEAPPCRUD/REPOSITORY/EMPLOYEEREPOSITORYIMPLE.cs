using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYEEAPPCRUD.REPOSITORY
{
    internal class EMPLOYEEREPOSITORYIMPLE:IEMPLOYEEREPOSITORRY
    {
        //GET DATABASE CONNECTION
        //1 RETRIEVE CONNECTIONSTRING FROM APP.CONFIG
        string WindowconnString = ConfigurationManager.ConnectionStrings["CSHARPWINDOW"].ConnectionString;
    }
}
