namespace MathProCorporation.TaskManagerDatabase
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using MathProCorporation.Models;

    // Represents a company's employee
    public class Employee
    {
        [Key]
        public string EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public ApplicationUser User { get; set; }

        // Gets or sets the list of current tasks
        public virtual List<Task> Tasks { get; set; }
    }
}