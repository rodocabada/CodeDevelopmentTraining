namespace PhoneBook.BL.Entities
{
    public class Shift : BaseData
    {
        public Shift() : this(0)
        {
        }

        public Shift(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}