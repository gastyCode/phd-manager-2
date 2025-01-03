using Microsoft.AspNetCore.Identity;
using PhDManager.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PhDManager.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        // Student
        public string? DisplayName { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }

        public virtual Address? Address { get; set; }
        public virtual StudyProgram? StudyProgram { get; set; }
        public virtual IndividualPlan? IndividualPlan { get; set; }

        // Supervisor
        public virtual List<Thesis> SupervisorTheses { get; set; }

        // Reviewer
        public virtual List<Comment> Comments { get; set; }

        [NotMapped]
        public bool HasInfo => Birthdate is not null && Address is not null && StudyProgram is not null;
    }
}
