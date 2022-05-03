using RestWithASPNET.Model;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {

        private List<Person> _people = new List<Person>();

        public Person Create(Person person)
        {
            _people.Add(person);
            return person;
        }

        public void delete(long id)
        {
            var person = GetByID(id);
            if (person != null ) _people.Remove(person);
        }

        public List<Person> GetAll()
        {
            return _people;
        }

        public Person? GetByID(long id)
        {
            return _people.Find(x => x.Id == id);
        }

        public Person? Update(Person person)
        {
            var value = GetByID(person.Id);
            if (value != null)
            {
                value.FirstName = person.FirstName;
                value.LastName = person.LastName;
                value.Address = person.Address;
                value.Gender = person.Gender;
            }

            return value;

        }
    }
}
