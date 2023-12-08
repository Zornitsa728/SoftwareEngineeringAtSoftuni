using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.IO.Interfaces;
using LogForU.Core.Layout.Interfaces;
using LogForU.Core.Loggers.Models;

namespace LogForU.Core.Appenders
{
    public class FileAppender : IAppender
    {
        public FileAppender(ILayout layout, ILogFile logFile, ReportLevel reportLevel = ReportLevel.Info)
        {
            Layout = layout;
            LogFile = logFile;
            ReportLevel = reportLevel;
        }
        public ILogFile LogFile { get; private set; }

        public ReportLevel ReportLevel { get; set; }

        public int MessageAppended { get; private set; }

        public ILayout Layout { get; private set; }

        public void Append(Message message)
        {
            string content = string.Format(Layout.Format, message.CreatedTime, message.ReportLevel, message.Text)
                + Environment.NewLine;

            File.AppendAllText(LogFile.FullPath, content);

            MessageAppended++;
        }
    }
}
