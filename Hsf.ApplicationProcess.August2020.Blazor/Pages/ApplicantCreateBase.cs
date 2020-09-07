using AutoMapper;
using Hsf.ApplicationProcess.August2020.Blazor.Data;
using Hsf.ApplicationProcess.August2020.Blazor.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hsf.ApplicationProcess.August2020.Blazor.Pages
{
    public class ApplicantCreateBase : ComponentBase
    {
        [Inject]
        public IApplicantService ApplicantService { get; set; }

        public Applicant Applicant { get; set; } = new Applicant();

        protected ConfirmBase ResetConfirmation { get; set; }


        protected void Reset_Click()
        {
            ResetConfirmation.Show();
        }

        protected void ConfirmReset_Click(bool resetConfirmed)
        {
            if (resetConfirmed)
            {
                Applicant.Name = "";
                Applicant.FamilyName = "";
                Applicant.Address = "";
                Applicant.CountryOfOrigin = "";
                Applicant.EmailAddress = "";
                Applicant.Age = 0;
                Applicant.Hired = false;
            }
        }

        protected async Task SendValid()
        {
            var result = await ApplicantService.CreateApplicant(Applicant);
            //if (result != null)

        }

        public List<Country> Countries { get; set; }

        protected override Task OnInitializedAsync()
        {
            Countries = new List<Country>()
            {
                new Country{Title="Afghanistan"},
                new Country{Title="Albania"},
                new Country{Title="Algeria"},
                new Country{Title="Andorra"},
                new Country{Title="Angola"},
                new Country{Title="Antigua and Barbuda"},
                new Country{Title="Argentina"},
                new Country{Title="Armenia"},
                new Country{Title="Australia"},
                new Country{Title="Austria"},
                new Country{Title="Azerbaijan"},
                new Country{Title="Bahamas"},
                new Country{Title="Bahrain"},
                new Country{Title="Bangladesh"},
                new Country{Title="Barbados"},
                new Country{Title="Belarus"},
                new Country{Title="Belgium"},
                new Country{Title="Belize"},
                new Country{Title="Benin"},
                new Country{Title="Bhutan"},
                new Country{Title="Bolivia"},
                new Country{Title="Bosnia and Herzegovina"},
                new Country{Title="Botswana"},
                new Country{Title="Brazil"},
                new Country{Title="Brunei"},
                new Country{Title="Bulgaria"},
                new Country{Title="Burkina Faso"},
                new Country{Title="Burundi"},
                new Country{Title="Cabo Verde"},
                new Country{Title="Cambodia"},
                new Country{Title="Cameroon"},
                new Country{Title="Central African Republic"},
                new Country{Title="Chad"},
                new Country{Title="Chile"},
                new Country{Title="China"},
                new Country{Title="Colombia"},
                new Country{Title="Comoros"},
                new Country{Title="Congo, Democratic Republic of the"},
                new Country{Title="Congo, Republic of the"},
                new Country{Title="Costa Rica"},
                new Country{Title="Cote d'Ivoire"},
                new Country{Title="Croatia"},
                new Country{Title="Cuba"},
                new Country{Title="Cyprus"},
                new Country{Title="Czechia"},
                new Country{Title="Denmark"},
                new Country{Title="Djibouti"},
                new Country{Title="Dominica"},
                new Country{Title="Dominican Republic"},
                new Country{Title="Ecuador"},
                new Country{Title="Egypt"},
                new Country{Title="El Salvador"},
                new Country{Title="Equatorial Guinea"},
                new Country{Title="Eritrea"},
                new Country{Title="Estonia"},
                new Country{Title="Eswatini"},
                new Country{Title="Ethiopia"},
                new Country{Title="Fiji"},
                new Country{Title="Finland"},
                new Country{Title="France"},
                new Country{Title="Gabon"},
                new Country{Title="Gambia"},
                new Country{Title="Georgia"},
                new Country{Title="Germany"},
                new Country{Title="Ghana"},
                new Country{Title="Greece"},
                new Country{Title="Grenada"},
                new Country{Title="Guatemala"},
                new Country{Title="Guinea"},
                new Country{Title="Guinea-Bissau"},
                new Country{Title="Guyana"},
                new Country{Title="Haiti"},
                new Country{Title="Honduras"},
                new Country{Title="Hungary"},
                new Country{Title="Iceland"},
                new Country{Title="India"},
                new Country{Title="Indonesia"},
                new Country{Title="Iran"},
                new Country{Title="Iraq"},
                new Country{Title="Ireland"},
                new Country{Title="Israel"},
                new Country{Title="Italy"},
                new Country{Title="Jamaica"},
                new Country{Title="Japan"},
                new Country{Title="Jordan"},
                new Country{Title="Kazakhstan"},
                new Country{Title="Kenya"},
                new Country{Title="Kiribati"},
                new Country{Title="Kosovo"},
                new Country{Title="Kuwait"},
                new Country{Title="Kyrgyzstan"},
                new Country{Title="Laos"},
                new Country{Title="Latvia"},
                new Country{Title="Lebanon"},
                new Country{Title="Lesotho"},
                new Country{Title="Liberia"},
                new Country{Title="Libya"},
                new Country{Title="Liechtenstein"},
                new Country{Title="Lithuania"},
                new Country{Title="Luxembourg"},
                new Country{Title="Madagascar"},
                new Country{Title="Malawi"},
                new Country{Title="Malaysia"},
                new Country{Title="Maldives"},
                new Country{Title="Mali"},
                new Country{Title="Malta"},
                new Country{Title="Marshall Islands"},
                new Country{Title="Mauritania"},
                new Country{Title="Mauritius"},
                new Country{Title="Mexico"},
                new Country{Title="Micronesia"},
                new Country{Title="Moldova"},
                new Country{Title="Monaco"},
                new Country{Title="Mongolia"},
                new Country{Title="Montenegro"},
                new Country{Title="Morocco"},
                new Country{Title="Mozambique"},
                new Country{Title="Myanmar"},
                new Country{Title="Namibia"},
                new Country{Title="Nauru"},
                new Country{Title="Nepal"},
                new Country{Title="Netherlands"},
                new Country{Title="New Zealand"},
                new Country{Title="Nicaragua"},
                new Country{Title="Niger"},
                new Country{Title="Nigeria"},
                new Country{Title="North Korea"},
                new Country{Title="North Macedonia"},
                new Country{Title="Norway"},
                new Country{Title="Oman"},
                new Country{Title="Pakistan"},
                new Country{Title="Palau"},
                new Country{Title="Palestine"},
                new Country{Title="Panama"},
                new Country{Title="Papua New Guinea"},
                new Country{Title="Paraguay"},
                new Country{Title="Peru"},
                new Country{Title="Poland"},
                new Country{Title="Portugal"},
                new Country{Title="Qatar"},
                new Country{Title="Romania"},
                new Country{Title="Russia"},
                new Country{Title="Rwanda"},
                new Country{Title="Saint Kitts and Nevis"},
                new Country{Title="Saint Lucia"},
                new Country{Title="Saint Vincent and the Grenadines"},
                new Country{Title="Samoa"},
                new Country{Title="San Marino"},
                new Country{Title="Sao Tome and Principe"},
                new Country{Title="Saudi Arabia"},
                new Country{Title="Senegal"},
                new Country{Title="Serbia"},
                new Country{Title="Seychelles"},
                new Country{Title="Sierra Leone"},
                new Country{Title="Singapore"},
                new Country{Title="Slovakia"},
                new Country{Title="Slovenia"},
                new Country{Title="Solomon Islands"},
                new Country{Title="Somalia"},
                new Country{Title="South Africa"},
                new Country{Title="South Korea"},
                new Country{Title="South Sudan"},
                new Country{Title="Spain"},
                new Country{Title="Sri Lanka"},
                new Country{Title="Sudan"},
                new Country{Title="Suriname"},
                new Country{Title="Sweden"},
                new Country{Title="Switzerland"},
                new Country{Title="Syria"},
                new Country{Title="Taiwan"},
                new Country{Title="Tajikistan"},
                new Country{Title="Tanzania"},
                new Country{Title="Thailand"},
                new Country{Title="Timor-Leste"},
                new Country{Title="Togo"},
                new Country{Title="Tonga"},
                new Country{Title="Trinidad and Tobago"},
                new Country{Title="Tunisia"},
                new Country{Title="Turkey"},
                new Country{Title="Turkmenistan"},
                new Country{Title="Tuvalu"},
                new Country{Title="Uganda"},
                new Country{Title="Ukraine"},
                new Country{Title="United Arab Emirates"},
                new Country{Title="United Kingdom"},
                new Country{Title="United States of America"},
                new Country{Title="Uruguay"},
                new Country{Title="Uzbekistan"},
                new Country{Title="Vanuatu"},
                new Country{Title="Vatican City"},
                new Country{Title="Venezuela"},
                new Country{Title="Vietnam"},
                new Country{Title="Yemen"},
                new Country{Title="Zambia"},
                new Country{Title="Zimbabwe"}
            };


            return base.OnInitializedAsync();
        }
    }
}
