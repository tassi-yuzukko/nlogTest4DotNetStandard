using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace DotNetStandardLogTest
{
    public class NlogTest
    {
		private static Logger _logger = LogManager.GetCurrentClassLogger();

		public NlogTest()
		{
		}

		public void TestLogging()
		{
			_logger.Trace("Sample trace message");
			_logger.Debug("Sample debug message");
			_logger.Info("Sample informational message");
			_logger.Warn("Sample warning message");
			_logger.Error("Sample error message");
			_logger.Fatal("Sample fatal error message");
			_logger.Log(LogLevel.Info, "Sample informational message");

			try
			{
				throw new Exception("これは内部例外だよ");
			}
			catch (Exception e)
			{
				_logger.Error(e, "エラー");
			}
		}
	}
}
