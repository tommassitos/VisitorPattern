namespace VisitorPattern
{
    public class EntryA : IEntry
    {
        public void Accept(IEntryVisitor entryVisitor) => entryVisitor.Visit(this);
    }
}
