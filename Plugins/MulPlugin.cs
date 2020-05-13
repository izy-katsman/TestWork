using System;

namespace ds.test.impl
{
    class MulPlugin : BasePlugin, IPlugin
    {
        public string PluginName { get; } = "MulPlugin";
        public string Version { get; } = "1.0";
        // Image Image { get; }
        public string Description { get; } = "Plugin that mul 2 int";

        /// <summary>
        /// Mul 2 int
        /// </summary>
        public int Run(int input1, int input2)
        {
            return input1 * input2;
        }

        internal override void SomeFoo()
        {
            Console.WriteLine("Do something in " + PluginName);   
        }
    }
}
