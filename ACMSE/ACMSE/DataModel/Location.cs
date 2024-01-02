namespace ACMSE
{
    public class Location
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Location() { }

        public Location(int id, string name)
        {
            Name = name;
            Id = id;
        }

        public override string ToString() => Name;
    }
}
