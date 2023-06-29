using System.ComponentModel.DataAnnotations;

namespace Back_end.Models
{
    public class __EFMigrationsHistory
    {
        [Key]
        public string MigrationId { get; private set; } = "";
        public string ProductVersion { get; private set; } = "";
    }
}