using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserDTO
    {
        public string fName { get; set; }
        public string  lName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public string country { get; set; }
        public bool isActive { get; set; }
        public string pic { get; set; }
        public string address { get; set; }
        public int Id { get; set; }
        public UserDTO()
        {
            
        }
        public void initialize(int id,string f, string ln, string em, string ph, string pas, string gen, string coun, bool ac, string pic, string add)
        {
            this.Id = id;
            this.fName = f;
            this.lName = ln;
            this.email = em;
            this.phone = ph;
            this.password = pas;
            this.gender = gen;
            this.country = coun;
            this.isActive = ac;
            this.pic = pic;
            this.address = add;
        }
    }
    
}
