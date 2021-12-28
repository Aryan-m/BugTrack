using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackBlazorServerUI.Areas.Identity
{
    public class TokenProvider
    {
        public string xsrfToken { get; set; }
        public string refreshToken { get; set; }
    }
}
