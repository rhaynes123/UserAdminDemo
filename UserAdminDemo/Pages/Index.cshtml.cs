using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using UserAdminDemo.Models;

namespace UserAdminDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly UserManager<Profile> _userManager;

        public IndexModel(ILogger<IndexModel> logger
            ,UserManager<Profile> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public IList<Profile> Profiles { get; set; }
        public void OnGet()
        {
            Profiles = _userManager.Users.ToList();
        }
    }
}
