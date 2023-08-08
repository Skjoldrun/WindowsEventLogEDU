using WindowsEventLogEDU.Utilities;

namespace WindowsEventLogEDU
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var someMessage = "This is some message to test the EventLogWriter";
            EventLogWriter.WriteApplicationEventEntry(someMessage, System.Diagnostics.EventLogEntryType.Error);
        }
    }
}