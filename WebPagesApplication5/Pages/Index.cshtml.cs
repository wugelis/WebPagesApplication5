using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Utility;

namespace WebPagesApplication5.Pages
{
    public class IndexModel : PageModel
    {
        public string HostName { get; set; }

        public void OnGet()
        {
            HostName = Utils.GetHostName();
        }
    }
}