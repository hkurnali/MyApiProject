using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProjectWepApiConsume.Mapping
{
    public class AutoMappingConfing:Profile
    {
        public AutoMappingConfing()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room,RoomAddDto > ();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
