using AutoMapper;
using WeLearnAPI.Models.Domain;
using WeLearnAPI.Models.DTO.RequestDto;
using WeLearnAPI.Models.DTO.ResponeDto;
using WeLearnAPI.Models.DTOs;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        CreateMap<Admin, AdminResponseDTO>()
            .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender == 1 ? "male" : src.Gender == 0 ? "female" : "other"));

        CreateMap<Users, UserResponseDTO>();
    
        CreateMap<News, NewsReponeDTO>();
        CreateMap<Admin, AdminLoginResponeDTO>();
        CreateMap<Users, UserLoginResponeDTO>();


        CreateMap<RegisterRequestDTO, Users>()
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.PasswordHash, opt => opt.Ignore()) 
            .ForMember(dest => dest.PhoneNumber, opt => opt.Ignore()) 
            .ForMember(dest => dest.SecurityStamp, opt => opt.Ignore())
            .ForMember(dest => dest.ConcurrencyStamp, opt => opt.Ignore())
            .ForMember(dest => dest.LockoutEnabled, opt => opt.Ignore())
            .ForMember(dest => dest.AccessFailedCount, opt => opt.Ignore());

        // Mapping RegisterRequestDTO to Admin domain model
        CreateMap<RegisterRequestDTO, Admin>()
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.PasswordHash, opt => opt.Ignore()) 
            .ForMember(dest => dest.PhoneNumber, opt => opt.Ignore()) 
            .ForMember(dest => dest.SecurityStamp, opt => opt.Ignore())
            .ForMember(dest => dest.ConcurrencyStamp, opt => opt.Ignore())
            .ForMember(dest => dest.LockoutEnabled, opt => opt.Ignore())
            .ForMember(dest => dest.AccessFailedCount, opt => opt.Ignore());

        // Add mapping for AddAdminRequestDTO to Admin
        CreateMap<AddAdminRequestDTO, Admin>()
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
            .ForMember(dest => dest.Birthday, opt => opt.MapFrom(src => src.Birthday))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.TelephoneNumber))
            .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
            .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender == "male" ? 1 : src.Gender == "female" ? 0 : 2));

        CreateMap<AddNewsRequestDTO, News>();
        CreateMap<UpdateNewsRequestDTO, News>();
    }
}
