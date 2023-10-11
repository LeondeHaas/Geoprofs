using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class VerlofModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please select a reason for leave.")]
        public string Reason { get; set; }

        [Required(ErrorMessage = "Please provide a description.")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please select a start date.")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please select an end date.")]
        public DateTime EndDate { get; set; }

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "Please select a start time.")]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "Please select an end time.")]
        public DateTime EndTime { get; set; }
    }
}
