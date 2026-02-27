using WebApplication1.Models;
using WebApplication1.DTOs;
namespace WebApplication1.BusinessFlow
{
    public interface IFormFlow
    {
        List<GetFormDtos> GetForm();
        string PostForm(form form);
        string UpdateForm(long id,UpdateFormDtos dto);
        string DeleteForm(long id);
    }
}
