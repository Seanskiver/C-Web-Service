using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    /// Namespace will have a unique name to make the service uniquely discoverable
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    // To restrict this service from getting added as a custom too to toolbox
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class MyService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int SumOfNums(int first, int second)
        {
            return first + second;
        }

        // This makes the method uniquely identifiable to the client
        // Allows us to use the same overloaded method with a different Identifier 
        [WebMethod (MessageName="SumOfFloats")]
        public float SumOfNums(float first, float second)
        {
            return first + second;
        }
    }
}
