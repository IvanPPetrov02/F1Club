using DAL;
using LL;
using LL.Profile_related;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace F1ClubWeb.Pages
{
    [Authorize]
    public class ChangePasswordModel : PageModel
    {
        [BindProperty]
        public Profile LoggedUser { get; set; }

        [Required(ErrorMessage = "Please enter your curernt password")]
        [BindProperty]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "Please enter your new password"), MinLength(6, ErrorMessage = "Password too weak")]
        [BindProperty]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Please re-enter your new password")]
        [BindProperty]
        [DataType(DataType.Password)]
        public string RePassword { get; set; }

        ProfileManager profileManager = new ProfileManager(new ProfileDAO());

        public void OnGet()
        {
            LoggedUser = GetUser();
        }
        public Profile GetUser()
        {
            int id = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            return LoggedUser = profileManager.GetProfileByID(id);
        }

        public IActionResult OnPostChangePassword()
        {
            if (ModelState.IsValid)
            {
                if (NewPassword == RePassword)
                {
                    if (profileManager.PasswordMatch(LoggedUser.Email, CurrentPassword))
                    {
                        try
                        {
                            int id = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                            profileManager.ChangePassword(NewPassword, LoggedUser.Password, id);
                            Response.Redirect("/Profile");
                        }
                        catch (Exception ex)
                        {
                            ModelState.AddModelError("", ex.Message);
                        }
                    }
                }
            }
            return Page();
        }

    }
}
