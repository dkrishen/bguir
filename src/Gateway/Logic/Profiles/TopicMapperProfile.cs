using AutoMapper;
using Gateway.Models.Elastic;
using Gateway.Models.Entities;
using Gateway.Models.Post;
using Gateway.Models.Update;
using Gateway.Models.View;

namespace Gateway.Logic.Profiles;

public class TopicMapperProfile : Profile
{
    public TopicMapperProfile()
    {
        CreateMap<TopicPostDto, Topic>()
            .ForMember(dest => dest.Id,
                       opt => opt.MapFrom(src
                            => Guid.NewGuid()))
            .ForMember(dest => dest.SubCategory,
                       opt => opt.MapFrom(src
                            => 0));
            

        CreateMap<TopicUpdateDto, Topic>();

        CreateMap<Topic, TopicViewDto>();

        CreateMap<TopicElasticDto, TopicViewDto>();

        CreateMap<Topic, TopicElasticDto>();
    }
}
