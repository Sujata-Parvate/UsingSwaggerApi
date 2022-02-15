using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsingSwaggerApi.Model
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SkillName { get; set; }
        public int ProficienciesBiginner { get; set; }
        public int ProficienciesAdvanced { get; set; }
        public int ProficienciesIntermediate { get; set; }
        public int QuestionsAttempted { get; set; }
        public int CorrectAnswers { get; set; }
        public decimal Score { get; set; }

    }
}
