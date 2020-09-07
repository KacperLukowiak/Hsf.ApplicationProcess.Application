using System.Collections.Generic;
using System.Threading.Tasks;
using Hsf.ApplicationProcess.August2020.Blazor.Data;

namespace Hsf.ApplicationProcess.August2020.Blazor.Services
{
    public interface IApplicantService
    {
        Task<IEnumerable<Applicant>> GetApplicants();
        Task<Applicant> CreateApplicant(Applicant newApplicant);
    }
}
