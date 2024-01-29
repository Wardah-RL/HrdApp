using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace HrdApp.DataModels.Entity
{
    public class Coba 
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
