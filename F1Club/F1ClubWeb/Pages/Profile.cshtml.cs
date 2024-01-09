using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using LL;
using LL.Profile_related;
using DAL;

namespace F1ClubWeb.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        [BindProperty]
        public Profile LoggedUser { get; set; }

        ProfileManager profileManager = new ProfileManager(new ProfileDAO());

        public void OnGet()
        {
            var userIdentity = HttpContext.User.Identity as ClaimsIdentity;

            if (userIdentity != null)
            {
                LoggedUser = GetUser();
            }
        }

        public Profile GetUser()
        {
            int id = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            return LoggedUser = profileManager.GetProfileByID(id);
        }


    }
}
