using AutoMapper;
using WebApplication1.DTOs;
using WebApplication1.Models;


namespace WebApplication1.Profiles
{
    public class FormMappingProfile: Profile
    {
        public FormMappingProfile() {
            CreateMap<UpdateFormDtos, form>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null && srcMember is string str && !string.IsNullOrWhiteSpace(str)));
        }
    }
}
