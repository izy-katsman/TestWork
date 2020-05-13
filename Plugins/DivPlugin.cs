using ds.test.impl;
using System;

namespace TestWork.Plugins
{
    class DivPlugin : BasePlugin, IPlugin
    {
        public string PluginName { get; } = "SumPlugin";
        public string Version { get; } = "1.0";
        // Image Image { get; }
        public string Description { get; } = "Plugin thst sum 2 int";

        /// <summary>
        /// Div 2 int
        /// </summary>
        public int Run(int input1, int input2)
        {
            if (input2 != 0)
                return input1 / input2;
            else
                return 0;
        }

        internal override void SomeFoo()
        {
            Console.WriteLine("Do something in " + PluginName);
        }
    }
}
