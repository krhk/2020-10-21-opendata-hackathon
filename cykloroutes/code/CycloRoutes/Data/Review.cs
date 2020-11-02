using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CycloRoutes.Data
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [System.ComponentModel.DisplayName("ID Uživatele")]
        public string UserID { get; set; }
        [System.ComponentModel.DisplayName("ID Stezky")]
        public int TrailID { get; set; }
        [Required]
        [MinLength(15)]
        [System.ComponentModel.DisplayName("Název")]
        public string Title { get; set; }
        [Required]
        [MinLength(15)]
        [System.ComponentModel.DisplayName("Popis")]
        public string Description { get; set; }
        [Required]
        [Range(1,5)]
        [System.ComponentModel.DisplayName("Hodnocení")]
        public int Rating { get; set; }
        [Range(1, 5)]
        [System.ComponentModel.DisplayName("Hodnocení cesty")]
        public string RoadRating { get; set; }
        public DbSet<Image> Images { get; set; }
        [System.ComponentModel.DisplayName("Pozitivní hlasy")]
        public int LikeCount { get; set; }
        [System.ComponentModel.DisplayName("Negativní hlasy")]
        public int DislikeCount { get; set; }
        [System.ComponentModel.DisplayName("Jméno uživatele")]
        public string Username { get; set; }
        [System.ComponentModel.DisplayName("Datum recenze")]
        public DateTime Date { get; set; }
    }
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public int ReviewID { get; set; }
        [Required]
        public string Link { get; set; }
    }
}
