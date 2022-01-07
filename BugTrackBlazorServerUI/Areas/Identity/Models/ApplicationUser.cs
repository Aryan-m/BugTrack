using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackBlazorServerUI.Areas.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public byte[] ImgDataBytes { get; set; }
        public string ImgDataBase64 { get; set; }
        public string DisplayName { get; set; }
    }
}
