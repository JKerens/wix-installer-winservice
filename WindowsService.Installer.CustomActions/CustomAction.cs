using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using Microsoft.Deployment.WindowsInstaller;

namespace WindowsService.Installer.CustomActions
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult InitializeServer(Session session)
        {
            session.Log("Begin CustomAction1");

            // Uncomment to debug
            // Debugger.Launch();
            session["COMPANY_ID"] = session["COMPANY_ID"] ?? "TestCompany";
            return ActionResult.Success;
        }
    }
}
