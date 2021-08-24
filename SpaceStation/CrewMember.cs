namespace SpaceStation
{
    public class CrewMember : ShipPersonnel
    {
        public CrewMember(string firstName, string lastName, int id, int age, string position)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            Age = age;
            Position = position;
        }
    }
}