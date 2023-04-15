﻿using System.ComponentModel.DataAnnotations;

namespace ASPNET_FP.Models
{
	public class Image
	{
		// properties
		[Key]
		public int ImgId { get; set; }
		public int ListingId { get; set; }
		public string image { get; set; }
		public int DisplayOrder { get; set; }

		// constructor
		public Image()
		{
		}
	}
}
