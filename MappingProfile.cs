using System;
using AutoMapper;
using OnlineConsultationManagementSystem.Models.Domain;
using OnlineConsultationManagementSystem.Models.ViewModel;

namespace OnlineConsultationManagementSystem
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationModel, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
