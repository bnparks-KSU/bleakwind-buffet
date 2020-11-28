/*
 * Author: Brian Parks
 * Class name: Privacy.cshtml.cs
 * Purpose: This is the data model for the privacy page of the bleakwind buffet website.
 */

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages {

    public class PrivacyModel : PageModel {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger) {
            _logger = logger;
        }

        public void OnGet() {
        }
    }
}