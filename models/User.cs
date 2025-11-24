namespace Models
{
    /*                          ******************** User Class ********************
    *  ***************************************************************************************
    * This class represents a user in the system with properties for Id, Name, Email, Role, UserName and Password
    * The Id property is an integer that uniquely identifies the user. will be used as the pr
    * The FirstName and LastName properties are strings that store the user's first and last 
    * Email is a string that holds the user's email address.
    * Role is a string that defines the user's role within the system (e.g., Admin, User).
    * UserName is a string that represents the user's chosen username for login purposes.
    * Password is a string that stores the user's password for authentication.
    * ***************************************************************************************
    */
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        public string? Email { get; set; }

        public string? Role { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

    }

}

