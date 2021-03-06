﻿using System.Web.Mvc;
using System.IO;
using System.Text;

namespace BuildOurOwnBabylonJSServer.Controllers
{
    public class BuildOurOwnBabylonJSController : Controller
    {
        public const string GetFileContentActionName = "GetFileContent";
        
        [ActionName(BuildOurOwnBabylonJSController.GetFileContentActionName)]
        public ActionResult GetFileContent(string rootPath, string relPath, string type)
        {
            var babylonJSPath = Path.Combine(Server.MapPath("~"), rootPath);

            var absPath = Path.Combine(babylonJSPath, relPath);

            var streamReader = new StreamReader(absPath, Encoding.UTF8);
            var text = streamReader.ReadToEnd();
            streamReader.Close();

            return Content(text, type);
        }
    }
}
