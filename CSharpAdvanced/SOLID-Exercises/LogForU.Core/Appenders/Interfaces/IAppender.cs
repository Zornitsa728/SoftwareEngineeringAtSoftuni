using LogForU.Core.Enums;
using LogForU.Core.Layout.Interfaces;
using LogForU.Core.Loggers.Models;

namespace LogForU.Core.Appenders.Interfaces
{
    public interface IAppender
    {
        ILayout Layout { get; }
        ReportLevel ReportLevel { get; set; }

        int MessageAppended { get; }
        void Append(Message message);
    }
}
