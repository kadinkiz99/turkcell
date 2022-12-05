using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace turkcell.Models
{
    public class Product
    {
        public int id { get; set; }

        [Required(ErrorMessage = "İsim Alanı boş bırakılamaz.")]
		public string Name { get; set; }

		//[Required(ErrorMessage = "Fiyat Alanı boş bırakılamaz.")]
		[Range(1, 1000, ErrorMessage = "Fiyat alanı 1 ile 1000 arasında değerler almalı.")]
		public decimal? Price { get; set; }

		[Required(ErrorMessage="Stok Alanı boş bırakılamaz.")]
		[Range(1,200,ErrorMessage ="Stok alanı 1 ile 200 arasında değerler almalı.")]
		public int? Stock { get; set; }

		public string color  { get; set; }
		//	public int? Width { get; set; }// ? nullable olduğu için eklendş 
		//public int? Height { get; set; }

		public bool? IsPublish { get; set; }

		public int? Expire { get; set; }


		public string  Description { get; set; }



		public DateTime? PublishDate { get; set; }

    }
}