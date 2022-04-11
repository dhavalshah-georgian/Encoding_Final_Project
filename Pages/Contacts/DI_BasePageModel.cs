using IESFinalProject.DataMigration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IESFinalProject.Pages.Contacts
{
    public class DI_BasePageModel : PageModel
    {
        protected AppDBContext Context { get; }
        protected IAuthorizationService AuthorizationService { get; }
        protected UserManager<IdentityUser> UserManager { get; }

        public DI_BasePageModel(
            AppDBContext context, IAuthorizationService authorizationService,
            UserManager<IdentityUser> userManager
        ) : base()
        {
            Context = context;
            UserManager = userManager;
            AuthorizationService = authorizationService;
        } 
    }
}
