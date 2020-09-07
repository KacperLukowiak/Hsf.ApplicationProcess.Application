using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Hsf.ApplicationProcess.August2020.Blazor.Data;


namespace Hsf.ApplicationProcess.August2020.Blazor.Services
{
    public class ApplicantService : IApplicantService
    {
        private readonly HttpClient httpClient;

        public ApplicantService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Applicant>> GetApplicants()
        {
            return await httpClient.GetJsonAsync<Applicant[]>("api/Applicants");
        }

        public async Task<Applicant> CreateApplicant (Applicant newApplicant)
        {
            return await httpClient.PostJsonAsync<Applicant>("api/Applicants", newApplicant);
        }
    }
}
