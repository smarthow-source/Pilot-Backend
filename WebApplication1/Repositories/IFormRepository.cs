using System.Collections.Generic;
using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IFormRepository
    {
        void Add(form form);
        List<form> GetAll();
        bool Update(long id, UpdateFormDtos dto);
        bool Delete(long Id);
    }
}
