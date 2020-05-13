using System;

namespace ds.test.impl
{
    class SumPlugin : BasePlugin, IPlugin
    {
        public string PluginName { get; } = "SumPlugin";
        public string Version { get; } = "1.0";
        // Image Image { get; }
        public string Description { get; } = "Plugin that sum 2 int";

        /// <summary>
        /// Sum 2 integers
        /// </summary>
        public int Run(int input1, int input2)
        {
            return input1 + input2;
        }
        internal override void SomeFoo()
        {
            Console.WriteLine("Do something in " + PluginName);
        }
    }
}
