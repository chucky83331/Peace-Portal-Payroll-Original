
using System;
using System.ComponentModel.DataAnnotations;


// ADDED JANUARY 17TH 2022 FROM TIM CORREY UTUBE "USING SQLITE IN C#"

namespace Peace_Portal_Payroll
{
    public class PPModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime WorkDate { get; set; }
        public string ShiftType { get; set; }
        public string ShiftTime { get; set; }
        public decimal Rate { get; set; }
        public decimal HrsWork { get; set; }
        public decimal Diff { get; set; }
        public decimal Total => ((Rate + Diff) * HrsWork);
        public decimal GrandTotal => (Total + Total);
    }
}
