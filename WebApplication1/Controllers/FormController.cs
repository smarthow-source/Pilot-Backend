using WebApplication1.Repositories;
using WebApplication1.Models;
using WebApplication1.BusinessFlow;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;
namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormController : ControllerBase
    {
        private readonly IFormFlow _flow;

        public FormController(IFormFlow flow)
        {
            _flow = flow;
        }
        [HttpGet("all-form")]
        public IActionResult Get()
        {
            var result = _flow.GetForm();
            return Ok(result);
        }

        [HttpPost("create")]
        public IActionResult Post(CreateFormDtos form)
        {
            var newForm = new form
            {
                SourceBranch = form.SourceBranch,
                DestinationBranch = form.DestinationBranch,
                ContractNo = form.ContractNo,
                CustomerName = form.CustomerName,
                CaseDetail = form.CaseDetail,
                CaseResult = form.CaseResult,
                CreatedAt = DateTime.UtcNow,
                IsActive = true
            };
            var result = _flow.PostForm(newForm);
            return Ok(result);
        }

        [HttpPut("update/{id}")]
        public IActionResult Put(long id, UpdateFormDtos dto)
        {
           
            var result = _flow.UpdateForm(id,dto);
            return Ok(result);
        }

        [HttpPut("delete/{id}")]
        public IActionResult Delete(long id)
        {
            var result = _flow.DeleteForm(id);
            return Ok(result);
        }
    }
}
