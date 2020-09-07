using FluentValidation;
using Hsf.ApplicationProcess.August2020.Domain.Models;
using Hsf.ApplicationProcess.August2020.Data.RestClientBuild;

namespace Hsf.ApplicationProcess.August2020.Domain.Validators
{
    public class ApplicantValidator : AbstractValidator<Applicant>
    {
        public ApplicantValidator(IRestClient restClient)
        {
            RuleFor(applicant => applicant.Name)
                .MinimumLength(5);
            RuleFor(applicant => applicant.FamilyName)
                .MinimumLength(5);
            RuleFor(applicant => applicant.Address)
                .MinimumLength(10);
            RuleFor(applicant => applicant.CountryOfOrigin)
                .MustAsync(async (country, cancellation) =>
                (await restClient.GetAsync($"https://restcountries.eu/rest/v2/name/{country}?fullText=true"))
                .IsSuccessStatusCode)
                .WithMessage("Country name is not valid - the country does not exist.");
            RuleFor(applicant => applicant.EmailAddress)
                .EmailAddress();
            RuleFor(applicant => applicant.Age)
                .InclusiveBetween(20, 60);
            RuleFor(applicant => applicant.Hired)
                .NotNull();
        }

    }
}
