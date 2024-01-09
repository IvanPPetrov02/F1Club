using DAL;
using LL;
using LL.Profile_related;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using static DAL.ProfileDAO;
using static LL.Exceptions;
using static LL.Profile_related.ProfileManager;

namespace F1ClubWeb.Pages
{
    public class RegisterModel : PageModel
    {
		ProfileManager profileManager = new ProfileManager(new ProfileDAO());

		[BindProperty]
		public Profile Profile { get; set; }
		[Required(ErrorMessage = "This fieled is required")]
		[BindProperty]
		[DataType(DataType.Password)]
		public string RePassword { get; set; }
		[Required(ErrorMessage = "Please enter your date of birth")]
		[BindProperty]
		[DataType(DataType.Date)]
		public string DateOfBirth { get; set; }

        public string ErrorMessage { get; set; }

        public void OnGet()
		{
		}

		public IActionResult OnPostRegister()
		{
			if (Profile.Password != RePassword)
			{
				ModelState.AddModelError("RePassword", "Passwords do not match.");
			}

            if (ModelState.IsValid)
            {
                DateOnly dateOfBirth = DateOnly.Parse(DateOfBirth);
                try
                {
                    Profile newProfile = new Profile(Profile.ID, Profile.Email, Profile.Password, Profile.FirstName, Profile.LastName, dateOfBirth, Profile.PhoneNumber, UserType.Member);

                    profileManager.CreateProfile(newProfile);

					return RedirectToPage("/Login");
				}
				catch (DataLengthException e)
                {
                    Console.WriteLine("DataLengthException caught: " + e.Message);
                    ErrorMessage = e.Message;
                    return Page();
                }
                catch (DuplicateEmailException e)
                {
                    Console.WriteLine("DuplicateEmailException caught: " + e.Message);
                    ErrorMessage = e.Message;
                    return Page();
                }
                catch (DatabaseNotAccessibleException e)
                {
                    Console.WriteLine("DatabaseNotAccessibleException caught: " + e.Message);
                    ErrorMessage = e.Message;
                    return Page();
                }
				catch (InvalidDateOfBirth e)
				{
					Console.WriteLine("InvalidDateOfBirth caught: " + e.Message);
					ErrorMessage = e.Message;
					return Page();
				}
			}
            else
            {
                return Page();
            }
        }
    }
}
