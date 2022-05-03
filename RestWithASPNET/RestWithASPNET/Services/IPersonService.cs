using RestWithASPNET.Model;

namespace RestWithASPNET.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person? GetByID(long id);
        List<Person> GetAll();
        Person? Update(Person person);
        void delete(long id);
    }
}
