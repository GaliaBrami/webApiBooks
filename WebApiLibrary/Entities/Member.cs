namespace WebApiLibrary.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public Member(int id, string name, string tel="")
        {
            Id = id;
            Name = name;
            Tel = tel;
        }
    }
}
