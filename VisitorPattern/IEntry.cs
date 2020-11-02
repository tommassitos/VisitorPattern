namespace VisitorPattern
{
    public interface IEntry
    {
        public void Accept(IEntryVisitor entryVisitor);
    }
}
