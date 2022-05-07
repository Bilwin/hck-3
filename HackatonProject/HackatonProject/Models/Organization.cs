namespace HackatonProject.Models
{
    public class Organization
    {
        public Organization(int id, string image, string title, string text, int viewsCount)
        {
            Id = id;
            Image = image;
            Title = title;
            Text = text;
            ViewsCount = viewsCount;
        }

        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int ViewsCount { get; set; }
    }
}