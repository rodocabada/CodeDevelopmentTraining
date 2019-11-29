namespace PhoneBook.BL.Entities
{
    public class UserType : BaseData
    {
        public UserType() : this(0)
        {
        }

        public UserType(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}