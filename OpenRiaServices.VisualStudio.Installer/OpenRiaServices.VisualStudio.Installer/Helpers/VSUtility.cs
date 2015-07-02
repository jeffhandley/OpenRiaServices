﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using EnvDTE;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;

namespace OpenRiaServices.VisualStudio.Installer.Helpers
{
    // The class is also added as a link to VsEvents project
    // Don't add any code in this class that will result in loading of NuGet.VisualStudio.dll from VsEvents
    /// <summary>
    /// 
    /// </summary>
    /// <from>NuGet</from>
    internal static class VsUtility
    {
        // some of thses probably won't ever be seen but let's be safe!
        private static HashSet<string> _unsupportedTypes = new HashSet<string>
        {
            VsConstants.UnloadedProjectTypeGuid, 
            VsConstants.VsProjectItemKindPhysicalFile,
            VsConstants.VsProjectItemKindPhysicalFolder, 
            VsConstants.VsProjectItemKindSolutionFolder,
            VsConstants.VsProjectItemKindSolutionItem,
            VsConstants.VsProjectKindMisc
        };
     

        public static Project GetActiveProject(IVsMonitorSelection vsMonitorSelection)
        {
            IntPtr ppHier = IntPtr.Zero;
            uint pitemid;
            IVsMultiItemSelect ppMIS;
            IntPtr ppSC = IntPtr.Zero;

            try
            {
                vsMonitorSelection.GetCurrentSelection(out ppHier, out pitemid, out ppMIS, out ppSC);

                if (ppHier == IntPtr.Zero)
                {
                    return null;
                }

                // multiple items are selected.
                if (pitemid == (uint) VSConstants.VSITEMID.Selection)
                {
                    return null;
                }

                IVsHierarchy hierarchy =
                    Marshal.GetTypedObjectForIUnknown(ppHier, typeof (IVsHierarchy)) as IVsHierarchy;
                if (hierarchy != null)
                {
                    object project;
                    if (
                        hierarchy.GetProperty(VSConstants.VSITEMID_ROOT, (int) __VSHPROPID.VSHPROPID_ExtObject,
                            out project) >= 0)
                    {
                        return (Project) project;
                    }
                }

                return null;
            }
            finally
            {
                if (ppHier != IntPtr.Zero)
                {
                    Marshal.Release(ppHier);
                }
                if (ppSC != IntPtr.Zero)
                {
                    Marshal.Release(ppSC);
                }
            }
        }


        public static bool IsSupported(this Project project)
        {
            Debug.Assert(project != null);
            try
            {
                // if we can't open it as an MSBuild project, we do anything with it
                var p = project.AsMSBuildProject();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            

            
        }

    }
}
