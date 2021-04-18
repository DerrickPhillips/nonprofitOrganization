using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Security.Claims;
using System.Threading.Tasks;

namespace nonprofitOrganization.Services
{
    public class UserEmailSender : IEmailSender
    {
        private readonly UserManager<IdentityUser> _userManager;
        public UserEmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor, UserManager<IdentityUser> userManager)
        {
            Options = optionsAccessor.Value;
            _userManager = userManager;
        }

        public AuthMessageSenderOptions Options { get; } 
        public ClaimsPrincipal User { get; private set; }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Execute(Options.SendGridKey, subject, message, email);
        }

        public Task Execute(string apiKey, string subject, string message, string email)
        {
            ClaimsPrincipal currentUser = this.User;
            var currentUserEmail = currentUser.FindFirst(ClaimTypes.Email).Value;
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(currentUserEmail, Options.SendGridUser),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));
            msg.SetClickTracking(false, false);

            return client.SendEmailAsync(msg);
        }
    }
}
