namespace VisitorPattern
{
    public class EntryB : IEntry
    {
        public void Accept(IEntryVisitor entryVisitor) => entryVisitor.Visit(this);
    }
}
