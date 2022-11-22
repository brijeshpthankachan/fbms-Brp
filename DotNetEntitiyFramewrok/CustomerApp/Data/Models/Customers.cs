using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CustomerApp.Data.Models
{
    [Index(nameof(Email), IsUnique = true)]
    internal class Customers
    {
        [Key] //primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // auto increment
        public int Id { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Email { get; set; }

        public int PhoneNumber { get; set; }
       
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Country { get; set; }
    }
}
