namespace HELPDESK.Models
{
    public class LoginModel
    {
        public int UserId { get; set; }
        public int IdUserType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
