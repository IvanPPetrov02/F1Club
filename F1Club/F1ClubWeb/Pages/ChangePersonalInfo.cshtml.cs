using DAL;
using LL;
using LL.Profile_related;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Security.Claims;
using static LL.Profile_related.ProfileManager;

namespace F1ClubWeb.Pages
{
    [Authorize]
    public class ChangePersonalInfoModel : PageModel
    {
        [BindProperty]
        public Profile LoggedUser { get; set; }

        [BindProperty]
        public Profile ChangedUser { get; set; }

        [Required(ErrorMessage = "Please enter your date of birth")]
        [BindProperty]
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }

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

        public IActionResult OnPostSaveData()
        {
            if (ModelState.IsValid)
            {
                DateOnly data = DateOnly.Parse(DateOfBirth);
                if (data > new DateOnly(1900, 1, 1))
                {
                    try
                    {
                        int id = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                        profileManager.UpdateProfile(new Profile(id, ChangedUser.Email, ChangedUser.FirstName, ChangedUser.LastName, DateOnly.Parse(DateOfBirth), ChangedUser.PhoneNumber, ChangedUser.UserType), LoggedUser.Email);
                        Response.Redirect("/Profile");
                    }
                    catch (Exception ex)
                    {
                        if (ex is DuplicateEmailException)
                        {
                            ModelState.AddModelError("Email", ex.Message);
                        }
                        else if (ex is InvalidDateOfBirth)
                        {
                            ModelState.AddModelError("DateOfBirth", ex.Message);
                        }
                        else
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
