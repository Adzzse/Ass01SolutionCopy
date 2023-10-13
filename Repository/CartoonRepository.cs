using BusinessObject;
using System;
using System.Collections.Generic;
namespace DataAccess.Repository
{
    public class CartoonRepository : ICartoonRepository
    {
        public void AddCartoon(Cartoon cartoon) => CartoonDAO.Instance.AddCartoon(cartoon);

        public void DeleteCartoon(int CartoonID) => CartoonDAO.Instance.Delete(CartoonID);

        public IEnumerable<Cartoon> GetCartoonsList()
        {
            return CartoonDAO.Instance.GetCartoonsList;
        }
        public IEnumerable<Cartoon> SearchCartoon(int id)
        {
            return CartoonDAO.Instance.SearchCartoon(id);
        }

        public IEnumerable<Cartoon> SearchCartoon(string name)
        {
            return CartoonDAO.Instance.SearchCartoon(name);
        }
        public Cartoon Login(string Email, string Password)
        {
            return CartoonDAO.Instance.Login(Email, Password);
        }

        public void UpdateCartoon(Cartoon cartoon) => CartoonDAO.Instance.Update(cartoon);

        public IEnumerable<Cartoon> SearchCartoonByCountry(string country, IEnumerable<Cartoon> searchList)
        {
            return CartoonDAO.Instance.FilterCartoonByCountry(country, searchList);
        }
    }
}
