using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRGtaak
{
    class user
    {
        private string username;
        private string password;

        public user()
        {

        }
        public user(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public bool login()
        {
            FileHandler fa = new FileHandler();
            List<string> data = fa.ReadData("user.txt");
            foreach (var item in data)
            {
                string[] split = item.Split(',');
                if (split[0].ToLower() == this.username.ToLower() && split[1] == this.password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
