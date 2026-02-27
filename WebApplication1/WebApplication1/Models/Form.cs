using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("form")]

    public class form
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("source_branch")]
        public string? SourceBranch { get; set; }
        [Column("destination_branch")]
        public string? DestinationBranch { get; set; }
        [Column("contract_no")]
        public string? ContractNo{ get; set; }
        [Column("customer_name")]
        public string? CustomerName { get; set; }
        [Column("case_detail")]
        public string? CaseDetail { get; set; }
        [Column("case_result")]
        public int? CaseResult { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("is_active")]
        public bool IsActive { get; set; } = true;
    }
}
