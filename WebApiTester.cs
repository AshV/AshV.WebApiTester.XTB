using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace AshV.WebApiTester.XTB
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "✈ WebAPI Launcher"),
        ExportMetadata("Description", "Execute and Test Dataverse/Dynamics 365 WebAPIs."),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "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"),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "Purple"),
        ExportMetadata("PrimaryFontColor", "White"),
        ExportMetadata("SecondaryFontColor", "White")]
    public class WebApiTester : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new WebApiTesterControl();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public WebApiTester()
        {
            // If you have external assemblies that you need to load, uncomment the following to
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}