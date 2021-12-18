using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackBlazorServerUI.Components
{
    public class DateComponent : ComponentBase
    {
        public string nowStr = DateTime.Now.ToString("MM/dd/yyyy");

        [Parameter]
        public string title { get; set; }
    }
}
