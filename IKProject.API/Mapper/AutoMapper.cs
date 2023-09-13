using AutoMapper;
using IKProject.EntityLayer.Concrete;
using IKProject.EntityLayer.DTOs;

namespace IKProject.API.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            // Staff to StaffDTO mapping
            CreateMap<Staff, StaffDto>()
                .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Comments))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department))
                .ForMember(dest => dest.Meetings, opt => opt.MapFrom(src => src.StaffMeetings));

            // Comment to CommentDTO mapping
            CreateMap<Comment, CommentDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Staff, opt => opt.MapFrom(src => src.Staff));

            // Gender to GenderDTO mapping
            CreateMap<Gender, GenderDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.GenderName, opt => opt.MapFrom(src => src.GenderName));

            // Department to DepartmentDTO mapping
            CreateMap<Department, DepartmentDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.DeptName));

            // Meeting to MeetingDTO mapping
            CreateMap<Meeting, MeetingDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                // Include other property mappings as needed
                .ForMember(dest => dest.StaffIds, opt => opt.MapFrom(src => src.StaffMeetings.Select(sm => sm.StaffId).ToList()));

            // StaffMeeting to StaffMeetingDTO mapping (if needed)
            CreateMap<StaffMeeting, StaffMeetingDto>()
                .ForMember(dest => dest.StaffId, opt => opt.MapFrom(src => src.StaffId))
                .ForMember(dest => dest.MeetingId, opt => opt.MapFrom(src => src.MeetingId));
        }
    }
}
