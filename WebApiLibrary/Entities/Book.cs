namespace WebApiLibrary.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public bool Status { get; set; }
        public Book(int id, string title,string author, string description="", bool status=true)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            Status = status;
        }
    }
}
