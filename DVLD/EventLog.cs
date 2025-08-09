using System;

public class clsEventLog
{
    public void Log(string EntryMessage, EventLogEntryType type, string SourceName = "DVLD", string WindowsLog = "Application")
    {
        if (!EventLog.SourceExists(SourceName))
            EventLog.CreateEventSource(SourceName, WindowsLog);
        EventLog.WriteEntry(SourceName, EntryMessage, type);
    }

}
