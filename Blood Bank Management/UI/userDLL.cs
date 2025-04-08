using Blood_Bank_Management.DAL;

namespace Blood_Bank_Management.UI
{
    internal class userDLL
    {
        internal string username;
        internal string email;
        internal String password;
        internal string contact;
        internal string address;
        internal string full_name;
        internal DateTime added_date;
        internal String image;

        public string Email { get; internal set; }

        internal bool Insert(userDAL u)
        {
            throw new NotImplementedException();
        }
    }
}