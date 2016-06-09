using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MyFirstASPMvc.Models
{
	public class Order
	{
		public int OrderId { get; set; }
		public DateTime OrderDate { get; set; }
		public string Username { get; set; }
		[Required]
		[StringLength(20, ErrorMessage = "最长20个字符", MinimumLength = 3)]
		public string FirstName { get; set; }
		[Required]
		[StringLength(20, ErrorMessage = "最长20个字符", MinimumLength = 3)]
		public string LastName { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }
		public string Phone { get; set; }
		[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "邮箱格式错误！")]
		public string Email { get; set; }
		[DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:c}")]
		public decimal Total { get; set; }
	}
}
