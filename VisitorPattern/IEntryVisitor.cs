namespace VisitorPattern
{
    public interface IEntryVisitor
    {
        void Visit(EntryA entry);
        void Visit(EntryB entry);
        void Visit(EntryC entry);
    }
}