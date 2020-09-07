using Microsoft.AspNetCore.Components;
using Hsf.ApplicationProcess.August2020.Blazor.Services;
using System.Collections.Generic;
using Hsf.ApplicationProcess.August2020.Blazor.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Hsf.ApplicationProcess.August2020.Blazor.Pages
{
    public class ApplicantListBase : ComponentBase
    {
        [Inject]
        public IApplicantService ApplicantService { get; set; }
        public IEnumerable<Applicant> Applicants { get; set; } = new List<Applicant>();
        protected override async Task OnInitializedAsync()
        {
            Applicants = (await ApplicantService.GetApplicants()).ToList();
        }
    }
}
