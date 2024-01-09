using LL;
using LL.Profile_related;
using DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace F1ClubWeb.Pages
{
	public class LoginModel : PageModel
    {
		ProfileManager profileManager = new ProfileManager(new ProfileDAO());

		[BindProperty]
		public Credential credential { get; set; }

		[BindProperty]
		public bool RememberEmail { get; set; }

		public void OnGet()
		{
			if (User.Identity.IsAuthenticated)
			{
				Response.Redirect("/Index");
			}
			if (Request.Cookies.ContainsKey("SavedEmail"))
			{
				var savedEmail = Request.Cookies["SavedEmail"];
				if (!string.IsNullOrEmpty(savedEmail))
				{
					credential = new Credential { Email = savedEmail };
					RememberEmail = true;
				}
			}
		}

		public async Task<IActionResult>OnPost()
		{
			if (ModelState.IsValid)
			{
				if (RememberEmail)
				{
					var options = new CookieOptions
					{
						Expires = DateTime.Now.AddDays(7),
						//HttpOnly = true
					};
					Response.Cookies.Append("SavedEmail", credential.Email, options);
				}
				else
				{
					Response.Cookies.Delete("SavedEmail");
				}

				Profile loggedUser = profileManager.Login(credential.Email, credential.Password);
				if (loggedUser != null)
				{

					List<Claim> claims = new List<Claim>
						{
							new Claim(ClaimTypes.NameIdentifier, loggedUser.ID.ToString()),
							new Claim(ClaimTypes.Name, loggedUser.FirstName.ToString())
						};


					if (loggedUser.UserType == UserType.Admin)
					{
						claims.Add(new Claim(ClaimTypes.Role, "Admin"));
					}

					var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
					await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity), properties: new AuthenticationProperties
					{
						ExpiresUtc = DateTime.UtcNow.AddMinutes(20)
					});

					return new RedirectToPageResult("Index");
				}
				else
				{
					return Page();
				}
			}
			return Page();
		}

		public record Credential
		{
			[Required]
			[DataType(DataType.EmailAddress)]
			public string Email { get; set; }
			[Required]
			[DataType(DataType.Password)]
			public string Password { get; set; }
			public bool RememberEmail { get; set; }
		}

	}


}

