using System;
using System.Collections.Generic;

namespace Classes
{
    public interface ILogger {

        public void LogInfo(string message);
        public void LogError(string message);

    }
}
