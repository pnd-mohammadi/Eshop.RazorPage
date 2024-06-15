namespace Eshop.RazorPage.Models.Users.Commands
{
    public class CreateUserCommand
    {
        public string Name { get; private set; }
        public string Family { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public Gender Gender { get; private set; }
        
    }
}
