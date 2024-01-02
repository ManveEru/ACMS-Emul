
namespace ACMSE
{
    public class Door
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int LocationId { get; set; }

        public Door() { }

        public Door(int id, string name, int location)
        {
            Name = name;
            Id = id;
            LocationId = location;
        }

        public override string ToString() => Name;
    }
}
