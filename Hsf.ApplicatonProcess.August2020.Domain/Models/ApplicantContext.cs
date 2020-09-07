using Microsoft.EntityFrameworkCore;

namespace Hsf.ApplicationProcess.August2020.Domain.Models
{
    public class ApplicantContext : DbContext
    {
        public ApplicantContext(DbContextOptions<ApplicantContext> options) : base(options)
        {

        }

        public DbSet<Applicant> Applicants { get; set; }
    }
}
