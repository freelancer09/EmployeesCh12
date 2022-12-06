namespace EmployeesCh12.Models
{
    public class DepartmentLocation
    {
        // Composite primary key and foreign key for department
        public int DepartmentID { get; set; }
        // Composite primary key and foreign key for location
        public int LocationID { get; set; }

        // Navigation properties
        public Department Department { get; set; }
        public Location Location { get; set; }
    }
}
