using System;

namespace Shuttle.Core.Logging
{
    public class NullLog : ILog
    {
        public static ILog Instance = new NullLog();

        private NullLog()
        {
        }

        public void AtLevel(LogLevel level, string message)
        {
        }

        public void Verbose(string message)
        {
        }

        public void Trace(string message)
        {
        }

        public void Debug(string message)
        {
        }

        public void Information(string message)
        {
        }

        public void Warning(string message)
        {
        }

        public void Error(string message)
        {
        }

        public void Fatal(string message)
        {
        }

        public void Verbose(bool condition, string message)
        {
        }

        public void Trace(bool condition, string message)
        {
        }

        public void Debug(bool condition, string message)
        {
        }

        public void Information(bool condition, string message)
        {
        }

        public void Warning(bool condition, string message)
        {
        }

        public void Error(bool condition, string message)
        {
        }

        public void Fatal(bool condition, string message)
        {
        }

        public void Verbose(Func<bool> condition, string message)
        {
        }

        public void Trace(Func<bool> condition, string message)
        {
        }

        public void Debug(Func<bool> condition, string message)
        {
        }

        public void Information(Func<bool> condition, string message)
        {
        }

        public void Warning(Func<bool> condition, string message)
        {
        }

        public void Error(Func<bool> condition, string message)
        {
        }

        public void Fatal(Func<bool> condition, string message)
        {
        }

        public LogLevel LogLevel => LogLevel.Off;

        public bool IsEnabled(LogLevel level)
        {
            return false;
        }

        public bool IsVerboseEnabled => false;

        public bool IsTraceEnabled => false;

        public bool IsDebugEnabled => false;

        public bool IsInformationEnabled => false;

        public bool IsWarningEnabled => false;

        public bool IsErrorEnabled => false;

        public bool IsFatalEnabled => false;

        public ILog For(Type type)
        {
            return this;
        }

        public ILog For(object instance)
        {
            return this;
        }
    }
}