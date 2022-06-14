namespace Car_Renting_System.Data.Models
{
    public class Category
    {
        public int Id { get; init; }

        public string Name { get; set; }

        public IEnumerable<Car> Cars { get; set; } = new List<Car>();
    }
}
