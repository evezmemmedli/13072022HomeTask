using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _13072022HomeTask.Models
{
    public class Position
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
