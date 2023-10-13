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
                //string role = config["AdminAccount:Role"];
                //Default = new Cartoon
                //{
                //    CartoonID = 1,
                //    Email = email,
                //    Password = password,
                //    Role = role,
                //    Producer = "",
                //    Country = "",
                //    CartoonName = "Admin"
                //};
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
                ShortDescription = "Mèo chuột đuổi nhau nát nhà",
                CartoonType ="Comedy",
                Producer = "Christopher DeFaria",
                Duration = 8200,
                Actors="Tom, Jerry",
                Director="Tim Story",
                Country = "USA"
            },
            new Cartoon
            {
                CartoonID = 2,
                CartoonName = "Phineas and Ferb",
                ShortDescription = "Phương và Phát (và những người bạn)",
                CartoonType ="Comedy",
                Producer = "Dan Povenmire",
                Duration = 2200,
                Actors="Phineas, Ferb",
                Director="Dan Povenmire",
                Country = "USA"
            },
            new Cartoon
            {
                CartoonID = 3,
                CartoonName = "Gravity Falls",
                ShortDescription = "Pines' bizzare adventure",
                CartoonType ="Adventure",
                Producer = "Tobias Conan Trost",
                Duration = 6700,
                Actors="Dipper Pines, Mabel Pines",
                Director="Alex Hirsch",
                Country = "USA"
            },
            new Cartoon
            {
                CartoonID = 4,
                CartoonName = "Mr.Bean",
                ShortDescription = "a child in a grown man's body",
                CartoonType ="British sitcom",
                Producer = "Sue Vertue",
                Duration = 390,
                Actors="Rowan Atkinson",
                Director="Peter Bennett-Jones",
                Country = "US"
            },
            
            new Cartoon
            {
                CartoonID = 5,
                CartoonName = "Trese",
                ShortDescription = "anime-influenced streaming television series",
                CartoonType ="Crime, horror",
                Producer = "BASE Entertainment",
                Duration = 2003,
                Actors="Alexandra Trese",
                Director="Budjette Tan",
                Country = "Singapore"
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

        public Cartoon Login(string providedEmail, string providedPassword)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            string emailFromConfig = config["AdminAccount:Email"];
            string passwordFromConfig = config["AdminAccount:Password"];

            if (providedEmail.Equals(emailFromConfig) && providedPassword.Equals(passwordFromConfig))
            {
                // Login successful, create and return a Cartoon object
                return new Cartoon
                {
                    CartoonID = 1,
                    Email = providedEmail,
                    Password = providedPassword,
                    CartoonName = "Admin"
                    // Add other properties as needed
                };
            }

            // Login failed, return null
            return null;
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

        public IEnumerable<Cartoon> SearchCartoon(int actor)
        {
            IEnumerable<Cartoon> searchResult = null;

            var cartoonSearch = from cartoon in cartoons
                                where cartoon.Actors.ToLower().Contains(actor.ToString())
                                select cartoon;
            searchResult = cartoonSearch;

            return searchResult;
        }
        public IEnumerable<Cartoon> SearchCartoon(string producer)
        {
            IEnumerable<Cartoon> searchResult = null;

            var cartoonSearch = from cartoon in cartoons
                                where cartoon.Producer.ToLower().Contains(producer.ToLower())
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
    }
}