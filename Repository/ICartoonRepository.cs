using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICartoonRepository
    {
        public IEnumerable<Cartoon> GetCartoonsList();
        public Cartoon Login(string Email, String Password);
        public void AddCartoon(Cartoon cartoon);
        public void UpdateCartoon(Cartoon cartoon);
        public void DeleteCartoon(int CartoonID);
        public IEnumerable<Cartoon> SearchCartoon(int id);
        public IEnumerable<Cartoon> SearchCartoon(string name);
        public IEnumerable<Cartoon> SearchCartoonByCountry(string country, IEnumerable<Cartoon> searchList);
    }
}
