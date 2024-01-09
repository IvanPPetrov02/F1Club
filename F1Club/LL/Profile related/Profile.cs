using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LL
{
    public class Profile
    {
        
        private int id;
		private string email;
		private string password;
		private string firstName;
		private string lastName;
		private DateOnly dateOfBirth;
		private string phoneNumber;
		private UserType userType;


		[Required]
		[BindProperty]
        public int ID { get => id; set => id = value; }

        [Required]
		[BindProperty]
		[DataType(DataType.EmailAddress)]
        public string Email { get => email; set => email = value; }

		[Required(ErrorMessage = "Please enter a Password"), MinLength(6, ErrorMessage = "Password too weak")]
		[BindProperty]
        [DataType(DataType.Password)]
		public string Password { get => password; set => password = value; }

		[Required(ErrorMessage = "Please enter your first name")]
		[BindProperty]
        public string FirstName { get => firstName; set => firstName = value; }

		[Required(ErrorMessage = "Please enter your last name")]
		[BindProperty]
        public string LastName { get => lastName; set => lastName = value; }

		[BindProperty]
		[DataType(DataType.Date)]
        public DateOnly DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

		[Required(ErrorMessage = "Please enter a phone number")]
		[BindProperty]
		[DataType(DataType.PhoneNumber, ErrorMessage = "Pleasse enter a valid phone number"), MaxLength(13, ErrorMessage = "Pleasse enter a valid phone number"), MinLength(10, ErrorMessage = "Pleasse enter a valid phone number")]
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

		[Required]
		[BindProperty]
        public UserType UserType { get => userType; set => userType = value; }


		public Profile(int iD, string email, string password, string firstName, string lastName, DateOnly dateOfBirth, string phoneNumber, UserType userType)
        {
            ID = iD;
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            UserType = userType;
        }

        public Profile(int iD, string email, string firstName, string lastName, DateOnly dateOfBirth, string phoneNumber, UserType userType)
        {
            ID = iD;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            UserType = userType;
        }

        public Profile()
        {
        }
    }
}