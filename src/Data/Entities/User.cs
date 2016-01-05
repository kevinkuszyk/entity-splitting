using System;

namespace Data.Entities
{
    public class User
    {
        // From table TM_USER
        public int Id { get; set; }
        public string Username { get; set; }
        public string Key { get; set; }

        // From table TM_USER_DETAIL
        public string Forename { get; set; }
        public string Surname { get; set; }

        // From table TM_MEMBERSHIP_USERS
        public bool IsApproved { get; set; }
    }
}
