namespace PhoneBook.BL.Entities
{
    public class Department : BaseData
    {
        public Department() : this(0)
        {
        }

        public Department(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int CostCenter { get; set; }
        public bool Status { get; set; }
        public int IdManager { get; set; }
    }
}