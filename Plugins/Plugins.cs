using System.Collections.Generic;
using System.Linq;

namespace ds.test.impl
{
    public static class Plugins
    {
        private static List<IPlugin> plugins = new List<IPlugin>();

        /// <summary>
        /// Get plugins count
        /// </summary>
        public static int PluginsCount
        {
            get
            {
                return plugins.Count;
            }
        }

        /// <summary>
        /// Get all plugins name
        /// </summary>
        public static string[] GetPluginNames
        {
            get
            {
                return plugins.Select(e => e.PluginName).ToArray();
            }
        }

        /// <summary>
        /// Get Plugins by name
        /// </summary>
        public static IPlugin GetPlugin(string pluginName)
        {
            return plugins.Find(e => e.PluginName == pluginName);
        }

        /// <summary>
        /// Method installing selected plugin
        /// </summary>
        /// <param name="plugin"></param>
        public static void InstallPlugin(IPlugin plugin)
        {
            if (!plugins.Contains(plugin))
                plugins.Add(plugin);
        }

        /// <summary>
        /// Method uninstalling all selected plugin
        /// </summary>
        /// <param name="plugin"></param>
        public static void UninstallPlugins(IPlugin plugin)
        {
            plugins.RemoveAll(e => e == plugin);
        }
    }
}
