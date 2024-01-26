namespace onlineLibrary.BookEntities
{
    public class BookEntity
    {
        public BookInfo Info { get; set; }
        public List<BookEvaluation>? Evaluations { get; set; }

        public BookEntity(BookInfo info, List<BookEvaluation>? evaluations = null)
        {
            Info = info;
            Evaluations = evaluations;
        }
    }
}
