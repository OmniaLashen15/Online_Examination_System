// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Entities2
{
    [Table("Student")]
    public partial class Student
    {
        public Student()
        {
            StudExams = new HashSet<StudExam>();
        }

        [Key]
        [Column("St_ID")]
        public int StId { get; set; }
        [Required]
        [Column("St_FName")]
        [StringLength(50)]
        [Unicode(false)]
        public string StFname { get; set; }
        [Column("St_LName")]
        [StringLength(50)]
        [Unicode(false)]
        public string StLname { get; set; }
        [Column("St_Address")]
        [StringLength(100)]
        [Unicode(false)]
        public string StAddress { get; set; }
        [Column("Dept_ID")]
        public int? DeptId { get; set; }

        [ForeignKey(nameof(DeptId))]
        [InverseProperty(nameof(Department.Students))]
        public virtual Department Dept { get; set; }
        [InverseProperty(nameof(StudExam.St))]
        public virtual ICollection<StudExam> StudExams { get; set; }
    }
}