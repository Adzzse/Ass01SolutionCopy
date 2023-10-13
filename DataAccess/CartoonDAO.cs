using BusinessObject;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataAccess
{
    public class CartoonDAO
    {
        // Get default user from appsettings
        private Cartoon GetDefaultCartoon()
        {
            Cartoon Default = null;
            using (StreamReader r = new StreamReader("appsettings.json"))
            {
                string json = r.ReadToEnd();
                IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
                string email = config["AdminAccount:email"];
                string password = config["AdminAccount:password"];
                Default = new Cartoon
                {
                    CartoonID = 0,
                    CartoonName = "",
                    LaunchDate = DateTime.Now,
                    CartoonType = "",
                    ShortDescription = "",
                    Producer = "",
                    Duration = 0,
                    Actors = "",
                    Director = "",
                    Country = ""
                };
            }

            return Default;
        }

        // Initialize CartoonList
        private static List<Cartoon> cartoons = new List<Cartoon>
        {
            new Cartoon
            {
                CartoonID = 1,
                CartoonName = "Tom and Jerry",
                ShortDescription = "meo duoi chuoi",
                CartoonType ="Comedy",
                Producer = "",
                Duration = 0,
                Actors="",
                Director="",
                Country = ""
            },
            new Cartoon
            {
                CartoonID = 2,
                CartoonName = "Phineas and Ferb",
                ShortDescription = "Phuong va Phat",
                CartoonType ="Comedy",
                Producer = "",
                Duration = 0,
                Actors="",
                Director="",
                Country = ""
            },
            new Cartoon
            {
                CartoonID = 3,
                CartoonName = "Gravity Falls",
                ShortDescription = "phong@gmail.com",
                CartoonType ="Comedy",
                Producer = "",
                Duration = 0,
                Actors="",
                Director="",
                Country = ""
            },
            new Cartoon
            {
                CartoonID = 4,
                CartoonName = "Tom and Jerry",
                ShortDescription = "phong@gmail.com",
                CartoonType ="Comedy",
                Producer = "",
                Duration = 0,
                Actors="",
                Director="",
                Country = ""
            },
            new Cartoon
            {
                CartoonID = 5,
                CartoonName = "Tom and Jerry",
                ShortDescription = "phong@gmail.com",
                CartoonType ="Comedy",
                Producer = "",
                Duration = 0,
                Actors="",
                Director="",
                Country = ""
            },
            new Cartoon
            {
                CartoonID = 6,
                CartoonName = "Tom and Jerry",
                ShortDescription = "phong@gmail.com",
                CartoonType ="Comedy",
                Producer = "",
                Duration = 0,
                Actors="",
                Director="",
                Country = ""
            },
            new Cartoon
            {
                CartoonID = 7,
                CartoonName = "Tom and Jerry",
                ShortDescription = "phong@gmail.com",
                CartoonType ="Comedy",
                Producer = "",
                Duration = 0,
                Actors="",
                Director="",
                Country = ""
            }
        };
        private CartoonDAO()
        {
            Cartoon DefaultAdmin = GetDefaultCartoon();
            if (DefaultAdmin != null)
            {
                cartoons.Add(DefaultAdmin);
            }
        }

        // Using Singleton Pattern
        private static CartoonDAO instance = null;
        private static object instanceLook = new object();

        public static CartoonDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new CartoonDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Cartoon> GetCartoonsList => cartoons;

        public Cartoon Login(string Email, string Password)
        {
            Cartoon cartoon = cartoons.SingleOrDefault(mb => mb.Email.Equals(Email) && mb.Password.Equals(Password));
            return cartoon;
        }

        public Cartoon GetCartoon(int CartoonId)
        {
            return cartoons.SingleOrDefault(mb => mb.CartoonID == CartoonId);
        }
        public Cartoon GetCartoon(string ShortDescription)
        {
            return cartoons.SingleOrDefault(mb => mb.ShortDescription.Equals(ShortDescription));
        }
        public void AddCartoon(Cartoon cartoon)
        {
            if (cartoon == null)
            {
                throw new Exception("Cartoon is undefined!!");
            }

            if (GetCartoon(cartoon.CartoonID) == null && GetCartoon(cartoon.ShortDescription) == null)
            {
                cartoons.Add(cartoon);
            }
            else
            {
                throw new Exception("Cartoon is existed!!");
            }
        }
        public void Update(Cartoon cartoon)
        {
            if (cartoon == null)
            {
                throw new Exception("Cartoon is undefined!!");
            }
            Cartoon mem = GetCartoon(cartoon.CartoonID);
            if (mem != null)
            {
                var index = cartoons.IndexOf(mem);
                cartoons[index] = cartoon;
            }
            else
            {
                throw new Exception("Cartoon does not exist!!");
            }
        }
        public void Delete(int CartoonId)
        {
            Cartoon cartoon = GetCartoon(CartoonId);
            if (cartoon != null)
            {
                cartoons.Remove(cartoon);
            }
            else
            {
                throw new Exception("Cartoon does not exist!!");
            }
        }

        public IEnumerable<Cartoon> SearchCartoon(int id)
        {
            IEnumerable<Cartoon> searchResult = null;

            var cartoonSearch = from cartoon in cartoons
                                where cartoon.CartoonID == id
                                select cartoon;
            searchResult = cartoonSearch;

            return searchResult;
        }
        public IEnumerable<Cartoon> SearchCartoon(string name)
        {
            IEnumerable<Cartoon> searchResult = null;

            var cartoonSearch = from cartoon in cartoons
                                where cartoon.CartoonName.ToLower().Contains(name.ToLower())
                                select cartoon;
            searchResult = cartoonSearch;

            return searchResult;
        }

        public IEnumerable<Cartoon> FilterCartoonByCountry(string country, IEnumerable<Cartoon> searchList)
        {
            IEnumerable<Cartoon> searchResult = null;

            var cartoonSearch = from cartoon in searchList
                                where cartoon.Country == country
                                select cartoon;
            if (country.Equals("All"))
            {
                cartoonSearch = from cartoon in searchList
                                select cartoon;
            }
            searchResult = cartoonSearch;

            return searchResult;
        }

        public IEnumerable<Cartoon> FilterCartoonByCity(string country, string city, IEnumerable<Cartoon> searchList)
        {
            IEnumerable<Cartoon> searchResult = null;

            var cartoonSearch = from cartoon in searchList
                                where cartoon.Producer == city
                                select cartoon;
            if (city.Equals("All"))
            {
                cartoonSearch = from cartoon in searchList
                                where cartoon.Country == country
                                select cartoon;
                if (country.Equals("All"))
                {
                    cartoonSearch = from cartoon in searchList
                                    select cartoon;
                }
            }
            searchResult = cartoonSearch;

            return searchResult;
        }
    }
}