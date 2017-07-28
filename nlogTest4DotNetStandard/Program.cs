using System;
using DotNetStandardLogTest;

namespace nlogTest4DotNetStandard
{
    class Program
    {
        static void Main(string[] args)
        {
			var logtest = new NlogTest();

			logtest.TestLogging();
        }
    }
}