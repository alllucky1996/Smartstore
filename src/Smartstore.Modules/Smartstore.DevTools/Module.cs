global using System;
global using System.Collections.Generic;
global using System.ComponentModel.DataAnnotations;
global using System.Linq;
global using System.Threading.Tasks;
global using Smartstore.Web.Modelling;
using System.Data;
using System.IO;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Smartstore.Engine.Modularity;
using Smartstore.Http;
using Smartstore.IO;
using Smartstore.Utilities;

namespace Smartstore.DevTools
{
    internal class Module : ModuleBase, IConfigurable
    {
        public ILogger Logger { get; set; } = NullLogger.Instance;

        public RouteInfo GetConfigurationRoute()
            => new("Configure", "DevTools", new { area = "Admin" });

        public override async Task InstallAsync(ModuleInstallationContext context)
        {
            await TrySaveSettingsAsync<ProfilerSettings>();
            await ImportLanguageResourcesAsync();
             RepLaceViewAsync();
            await base.InstallAsync(context);
        }

        public override async Task UninstallAsync()
        {
            await DeleteSettingsAsync<ProfilerSettings>();
            await DeleteLanguageResourcesAsync();
            await base.UninstallAsync();
        }

        void RepLaceViewAsync()
        {
            var fileReplaces = new Dictionary<string, string>();
            fileReplaces.Add("Views/Shared/Components/Footer/Default.cshtml", "Modules/Smartstore.DevTools/Views/Shared/Components/Footer/Default.cshtml");


            foreach (var dict in fileReplaces)
            {
                var source = dict.Key.SplitSafe("/");
                var desc = dict.Value.SplitSafe("/");
                var arr = source.ToList();
                arr.Insert(0, CommonHelper.ContentRoot.Root);

                var sourceFileName = PathUtility.Combine(arr.ToArray());
                // backup
                {
                    if (File.Exists(sourceFileName))
                    {
                        File.Copy(sourceFileName, sourceFileName + ".old", true);
                    }
                }
                //replace
                {
                    var descArr = desc.ToList();
                    descArr.Insert(0, CommonHelper.ContentRoot.Root);
                    var fileName = PathUtility.Combine(descArr.ToArray());
                    if (File.Exists(fileName))
                    {
                        File.Copy(fileName, sourceFileName, true);
                    }
                    else
                    {
                        File.Copy(sourceFileName + ".old", sourceFileName, true);
                    }
                }
            }
        }
    }
}
