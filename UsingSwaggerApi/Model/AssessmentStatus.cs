using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsingSwaggerApi.Model
{
    public class AssessmentStatus
    {
        [Key]
        public string AssessmentName { get; set; }
        public DateTime CompletionDate { get; set; }
        public string Status { get; set; }
        public decimal Score { get; set; }
        public int Attempts { get; set; }
        public int Toggle { get; set; }
        public int TimeUtlized { get; set; }
        public int AvgTimeperQue { get; set; }
        public int TotalCorrectAnswer { get; set; }
        public int BeginnerQuestion  { get; set; }
        public int IntermediateQuestion { get; set; }
        public int  AdvancedQuestion  { get; set; }
        public int QuestionAttempted { get; set; }
        public int  QuestionSkipped { get; set; }
        public int QuestionMarkedReview { get; set; }

    }
}
