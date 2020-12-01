using System.ComponentModel.DataAnnotations;

namespace DndMonsterApp.DataAccess.Sql.Entities
{
    public class ChallengeRating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public int ProficiencyBonus { get; set; }
        [Required]
        public int ArmorClass { get; set; }
        [Required]
        public int MinimumHitPoints { get; set; }
        [Required]
        public int MaximumHitPoints { get; set; }
        [Required]
        public int AttackBonus { get; set; }
        [Required]
        public int MinimumDamage { get; set; }
        [Required]
        public int MaximumDamage { get; set; }
        [Required]
        public int SavingsThrowDc { get; set; }
    }
}
