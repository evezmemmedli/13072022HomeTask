namespace _13072022HomeTask.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ImgUrl { get; set; }

        public string Name { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }


    }
}
