namespace turkcell.Models
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string color  { get; set; }
	//	public int? Width { get; set; }// ? nullable olduğu için eklendş 
		//public int? Height { get; set; }

        public bool IsPublish { get; set; }
        public int Expire { get; set; }
        public string  Description { get; set; }

    }
}