namespace GraphQLProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public ICollection<Menu>? Menus { get; set; }
    }
}
