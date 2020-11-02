namespace VisitorPattern
{
    public class EntryC : IEntry
    {
        public void Accept(IEntryVisitor entryVisitor) => entryVisitor.Visit(this);
    }
}
