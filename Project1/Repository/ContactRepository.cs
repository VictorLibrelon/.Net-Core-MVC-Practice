using Project1.Data;
using Project1.Models;

namespace Project1.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly BancoContext _bancoContext;

        public ContactRepository(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }
        public List<ContactModel> GetAll() {
            return _bancoContext.Contacts.ToList();
        }

        public ContactModel Add(ContactModel contact) 
        {
            //Gravar no banco de dados
            _bancoContext.Contacts.Add(contact);
            _bancoContext.SaveChanges();
            return contact;
        }


    }
}
