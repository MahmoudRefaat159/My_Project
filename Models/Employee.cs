using System.ComponentModel.DataAnnotations;

namespace My_Project.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public DateOnly Date { get; set; }
        [Required]
        public int Salary { get; set; }

    }
    public class Stor
    {
        private static List<Employee> My_List = new List<Employee>();

        public static List<Employee> ReturnData()
        {
            return My_List;
        }
        public static void InsertInto(Employee emp)
        {
            My_List.Add(emp);
        }
    }
}