using System;
using System.ComponentModel.DataAnnotations;

namespace NovoNar.Web.Models
{
    public class Table
    {
        public enum TableStatus
        {
            Free = 1,
            Occupied = 2,
            Reserved = 3,
            Blocked = 99
        }
        [Required]
        public int Number { get; set; }
        public TableStatus Status { get; set; }
        public DateTime? OpeningDate { get; set; }

    }
}
