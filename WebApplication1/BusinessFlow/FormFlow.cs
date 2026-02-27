using WebApplication1.Models;
using WebApplication1.Repositories;
using WebApplication1.DTOs;

namespace WebApplication1.BusinessFlow
{
    public class FormFlow : IFormFlow
    {
        private readonly IFormRepository _repo;
        
        public FormFlow(IFormRepository repo)
        {
            _repo = repo;
        }

        public List<GetFormDtos> GetForm()
        {
            var form = _repo.GetAll();
            var responseList = form.Where(f => f.IsActive == true).Select(f => new GetFormDtos(
            f.Id,
            f.SourceBranch,
            f.DestinationBranch,
            f.ContractNo,
            f.CustomerName,
            f.CaseDetail,
            f.CaseResult,
            f.CreatedAt
            
        )).ToList();
            return responseList;
        }

        public string PostForm(form form)
        {
            _repo.Add(form);
            return "Form added successfully";
        }

        public string UpdateForm(long id,UpdateFormDtos dto)
        {
            _repo.Update(id,dto);
            if (_repo.Update(id,dto)){
                return "Form updated successfully";
            }
            else
            {
                return "Form updated unsuccessful";
            }
           
        }
        
        public string DeleteForm(long id)
        {
            var result = _repo.Delete(id);
            if (result)
            {
                return "Form Delete Successfully";
            }
            else
            {
                return "Form Delete Unsuccessful";
            }
        }
    }
}
