namespace LogForU.Core.Layout.Interfaces
{
    public class SimpleLayout : ILayout
    {
        private const string SimpleFormat = "{0} - {1} - {2}";
        public string Format => SimpleFormat;
    }
}
