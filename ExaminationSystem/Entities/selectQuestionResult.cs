// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Entities
{
    public partial class selectQuestionResult
    {
        public int Q_ID { get; set; }
        public string Q_Question { get; set; }
        public string Q_Type { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string CourseName { get; set; }
        public string Model_Answer { get; set; }
    }
}
