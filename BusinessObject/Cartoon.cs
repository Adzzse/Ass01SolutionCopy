using System;
using DataValidation;

namespace BusinessObject
{
    public class Cartoon
    {
        public int CartoonID { get; set; }
        public string CartoonName { get; set; }

        public string CartoonType { get; set; }
        public string ShortDescription { get; set; }
        public string Producer { get; set; }
        public int Duration { get; set; }
        public string Actors { get; set; }
        public string Director { get; set; }
        public string Country { get; set; }

        public string LaunchDate { get; set; }


        private string email;
        
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (Validation.IsEmail(value))
                {
                    email = value;
                }
                else
                {
                    throw new Exception("Wrong format for Email!!");
                }
            }
        }

        public string Password { get; set; }
        
    }
}
