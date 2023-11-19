namespace WebApiLibrary.Entities
{
    public class Borrow
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public DateOnly Date { get; set; }
        public Borrow(int id, int memberId, int bookId, DateOnly date)
        {
            Id = id;
            MemberId = memberId;
            BookId = bookId;
            Date = date;
        }
    }
}
