using System.Collections.Generic;
using WebApplication1.Data;
using WebApplication1.DTOs;
using WebApplication1.Models;
using AutoMapper;
using WebApplication1.Profiles;

namespace WebApplication1.Repositories
{
    public class FormRepository: IFormRepository
    {
        private readonly MainContext _context;
        private readonly IMapper _mapper;
        public FormRepository(MainContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        

        public void Add(form form)
        {
            _context.Forms.Add(form);
            _context.SaveChanges();
        }
        public List<form> GetAll()
        {
            return _context.Forms.ToList();
        }

        public bool Update(long id,UpdateFormDtos dto)
        {
            var existingForm = _context.Forms.FirstOrDefault(f => f.Id == id);

            if (existingForm != null)
            {
                
                _mapper.Map(dto, existingForm);
                
                _context.SaveChanges();

                return true;

            }
            else{
                return false;
            }
        }

        public bool Delete(long id)
        {
            var DeleteItem = _context.Forms.FirstOrDefault(f => f.Id == id);
            
            if (DeleteItem == null)
            {
                return false;
            }
            else
            {
                DeleteItem.IsActive = false;
                _context.SaveChanges();
                return true;
            }
        }

        
    }
}
