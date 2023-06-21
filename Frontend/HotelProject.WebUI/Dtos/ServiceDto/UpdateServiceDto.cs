﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {

        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Servis icon linki giriniz")]
        public string ServiceIcon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
