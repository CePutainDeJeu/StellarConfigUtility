using System;
using System.ComponentModel.DataAnnotations;

namespace StellarConfigUtility.Models
{
	public class Technology
	{
		[Key]
		public int TechnologyId { get; set; }

		[Required]
		[StringLength(30, ErrorMessage = "Name is too long")]
		public string Name { get; set; }

		[Required]
		[Range(1, 999999, ErrorMessage = "Value for {0} must be between {1} and {2}")]
		public int Cost { get; set; }

		[Required]
		[StringLength(30, ErrorMessage = "That's way too many characters!")]
		public string Tree { get; set; }

		[Required]
		[Range(1, 999999, ErrorMessage = "Value for {0} must be between {1} and {2}")]
		public int Tier { get; set; }

		[Required]
		[StringLength(30, ErrorMessage = "That's way too many characters!")]
		public string Category { get; set; }

		[Required]
		[Range(0, 5, ErrorMessage = "Value for {0} must be between {1} and {2}")]
		public double Weight { get; set; }

		[Required]
		[StringLength(99, ErrorMessage = "Too many characters!")]
		public string Prerequisites { get; set; }
	}
}
