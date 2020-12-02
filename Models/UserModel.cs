using System;

namespace H6_Site
{
    public class UserModel
    {
        private string _userName = "";
        private string _phone = "";

        public string UserName { get { return _userName; } set { _userName = value.Length > 30 ? value[0..30] : value; } }
        public string UserPassword { get; set; }
        public bool Admin { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IP { get; set; }
        public string ProfilePicture { get; set; }
        public string Phone { get { return _phone; } set { _phone = value.Length > 8 ? value[0..8] : value; } }
        public DateTime LastLogin { get; set; }
        public Guid LoginGuid { get; set; }
    }
}
