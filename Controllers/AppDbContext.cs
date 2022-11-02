using System;
using Microsoft.EntityFrameworkCore;
using turkcell.Models;

namespace turkcell.Controllers
{
	public class AppDbContext :DbContext
	{

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-NEDR1OK\SQLEXPRESS;Initial Catalog=TurkcellDb;Integrated Security=True");


		}

		public DbSet<Product> Products { get; set; }


	}
}
