using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.Layout.Interfaces;
using LogForU.Core.Loggers.Models;

namespace LogForU.Core.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, ReportLevel reportLevel = ReportLevel.Info)
        {
            Layout = layout;
            ReportLevel = reportLevel;
        }
        public ReportLevel ReportLevel { get; set; }

        public int MessageAppended { get; private set; }

        public ILayout Layout { get; private set; }

        public void Append(Message message)
        {
            Console.WriteLine(string.Format(Layout.Format, message.CreatedTime, message.ReportLevel, message.Text));

            MessageAppended++;
        }
    }
}
