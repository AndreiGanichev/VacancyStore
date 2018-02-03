using AutoMapper;
using VacancyStore.DataAccess.Common.Models;
using VacancyStore.DataAccess.Models.RemoteVacancy;
using RemoteEmployer = VacancyStore.DataAccess.Models.RemoteVacancy.Employer;
using EmployerModel = VacancyStore.DataAccess.Common.Models.Employer;

namespace VacancyStore.Website.App_Start
{
    public static class ObjectMappingConfigurator
    {
        public static void Configure()
        {
            Mapper.Initialize(
               cfg =>
               {
                   cfg.CreateMap<ShortVacancyInfo, Vacancy>()
                       .ForMember(tgt => tgt.Requirement, opt => opt.MapFrom(src => src.Snippet.Requirement))
                       .ForMember(tgt => tgt.Responsibility, opt => opt.MapFrom(src => src.Snippet.Responsibility));
                   cfg.CreateMap<RemoteEmployer, EmployerModel>()
                       .ForMember(tgt => tgt.LogoPath, opt => opt.MapFrom(src => src.LogoUrl.Size90Url));
               });
        }
    }
}