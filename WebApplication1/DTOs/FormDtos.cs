using System.ComponentModel.DataAnnotations;


namespace WebApplication1.DTOs
{
    public record GetFormDtos
     (
        long Id,
        string SourceBranch,
        string DestinationBranch,
        string ContractNo,
        string CustomerName,
        string CaseDetail,
        int? CaseResult,
        DateTime CreatedAt
     );

    public record CreateFormDtos
    (
      string SourceBranch,
        string DestinationBranch,
        string ContractNo,
        string CustomerName,
        string CaseDetail,
        int CaseResult
    );

    public class UpdateFormDtos
    {
        
        [MaxLength(50, ErrorMessage = "Source Branch cannot exceed 50 characters.")]
        public string? SourceBranch { get; set; }
       
        [MaxLength(50, ErrorMessage = "Destination Branch cannot exceed 50 characters.")]
        public string? DestinationBranch { get; set; }
       
        public string? ContractNo { get; set; }

        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long.")]
        public string? CustomerName { get; set; }
        public string? CaseDetail { get; set; }
        public int? CaseResult { get; set; }
    }



}
