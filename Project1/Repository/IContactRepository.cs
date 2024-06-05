using Project1.Models;

namespace Project1.Repository
{
    public interface IContactRepository
    {
        List<ContactModel> GetAll();
        ContactModel Add(ContactModel contact);


    }
}
