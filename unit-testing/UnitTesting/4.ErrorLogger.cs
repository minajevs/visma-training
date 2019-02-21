
using System;

namespace UnitTesting
{
    public class ErrorLogger
    {
        public string LastError { get; set; }
        
        public void Log(string error)
        {
            // null
            // ""
            // " "
            if (String.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();
              
            LastError = error; 
            
            // Write the log to a storage
            // ...
        }
    }
}