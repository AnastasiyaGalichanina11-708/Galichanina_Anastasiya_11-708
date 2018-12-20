using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Film3
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public void UserInitialization(string firstName, string lastName)
        {
            Program.Initialization(firstName, lastName);
        }
        [WebMethod]
        public List<string> Test()
        {
            var list = new List<string> { "Z ukeg" };
            return list ;
        }

        [WebMethod]
        public List<string> Photo(string pathToPhoto)
        {
            var list = new List<string> { "Z ukeg" };
            return list;
        }
    }
}
