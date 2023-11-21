namespace WebApiLibrary.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public bool Status { get; set; }
        public Member(int id, string name,bool status, string tel="")
        {
            Id = id;
            Name = name;
            Tel = tel;
            Status = status;
        }
    }
}
