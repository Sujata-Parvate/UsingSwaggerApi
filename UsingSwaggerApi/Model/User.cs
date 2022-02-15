using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsingSwaggerApi.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public string EmailAddress { get; set; }

        public string MobileNumber { get; set; }
        public string ProfileImage { get; set; }
        public int TotalAssessmentsCompleted { get; set; }
        public decimal AverageAssessmentsScore { get; set; }
        public int AssessmentsOverallSkills { get; set; }
        public int SkillAchievedFromAssessments { get; set; }
    }
}
