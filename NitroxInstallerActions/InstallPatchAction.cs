﻿using System.Windows.Forms;
using Microsoft.Deployment.WindowsInstaller;

namespace NitroxInstallerActions
{
    public class InstallPatchAction
    {
        [CustomAction]
        public static ActionResult InstallPatch(Session session)
        {
            session.Log("Begin install");
            MessageBox.Show("Install.", "Install");
            return ActionResult.Success;
        }
    }
}
