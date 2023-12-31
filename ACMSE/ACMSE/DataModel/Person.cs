namespace ACMSE
{
    public class Person
    {
        public string NSP { get; set; }
        public int Id { get; set; }

        public Person () {}

        public Person (int id, string name, string surname, string patronim)
        {
            NSP = surname + " " + name + " " + patronim;
            Id = id;
        }

        public override string ToString() => NSP;
    }
}
