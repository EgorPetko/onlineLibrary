namespace onlineLibrary.BookEntities
{
    public class BookInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string>? Authors { get; set; }
        public List<string>? Tags { get; set; }

        public BookInfo(int id, string name, List<string>? authors = null, List<string>? tags = null) 
        { 
            Id = id;
            Name = name;   
            Authors = authors; 
            Tags = tags;
        }

    }

}
