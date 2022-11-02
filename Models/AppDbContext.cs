using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace turkcell.Models
{
	public class AppDbContext : DbContext
	{
		public AppDbContext( DbContextOptions <AppDbContext>options):base(options)	
		{
			SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-NEDR1OK\\SQLEXPRESS;Initial Catalog=TurkcellDb;Integrated Security=True");
		}
		DbSet<Product> Products { get; set; }	
	}
}
