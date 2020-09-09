using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hsf.ApplicationProcess.August2020.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Hsf.ApplicationProcess.August2020.Web.Controllers
{
    [ApiController] //indicates that the controller responds to web API requests
    [Produces("application/json")]
    [Route("api/Applicants")]
    public class ApplicantsController : ControllerBase
    {
        private readonly ApplicantContext _context;
        private readonly ILogger<ApplicantsController> _logger;

        public ApplicantsController(ApplicantContext context, ILogger<ApplicantsController> logger)
        {
            _context = context; //database context
            _logger = logger; //logger
        }

        // GET: api/Applicants
        /// <summary>
        /// Gets the list of all Applicants.
        /// </summary>
        /// <returns>The list of Applicants</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Applicant>>> GetApplicants()
        {
            _logger.LogInformation("{0} called.", nameof(GetApplicants));

            return await _context.Applicants.ToListAsync();
        }

        // GET: api/Applicants/5
        /// <summary>
        /// Gets a specific Applicant by id.
        /// </summary>
        /// <param name="id">Applicant id</param>
        /// <returns> An Applicant. </returns>
        /// <remarks>
        ///     GET api/Applicants
        ///     {
        ///         "id": 1
        ///     }
        /// </remarks>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Applicant>> GetApplicant(int id)
        {
            _logger.LogInformation("{0} called with id: {1}.", nameof(GetApplicant), id);
            var applicant = await _context.Applicants.FindAsync(id);

            if (applicant == null)
            {
                return NotFound();
            }

            return applicant;
        }

        // PUT: api/Applicants/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        /// <summary>
        /// Puts/Updates a new Applicant by id.
        /// </summary>
        /// <param name="id">Id of the applicant.</param>
        /// <param name="applicant">Updated applicant parameters.</param>
        /// <returns>Updated applicant.</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PutApplicant(int id, Applicant applicant)
        {
            _logger.LogInformation("{0} called with id {1}.", nameof(PutApplicant), id);
            if (id != applicant.Id)
            {
                return BadRequest();
            }

            _context.Entry(applicant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicantExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        /// <summary>
        /// Posts a new Applicant.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Applicant
        ///     {
        ///        "name": "Kacper",
        ///        "familyname": "Łukowiak",
        ///        "address": "Kolejowa 57/9 Poznań",
        ///        "countryoforigin": "Poland",
        ///        "emailaddress": "kacperlukowiak@gmail.com",
        ///        "age": 24,
        ///        "hired": false
        ///     }
        ///
        /// </remarks>
        /// <param name="applicant"></param>
        /// <returns>An Applicant.</returns>
        /// <response code="201">Returns the newly created Applicant</response>
        /// <response code="400">If the item is null</response> 
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Applicant>> PostApplicant(Applicant applicant)
        {
            _logger.LogInformation("{0} called with following parameters:" +
                "Name:{1}  FamilyName:{2}   Address:{3}   CountryOfOrigin:{4}" +
                "   EMailAddress:{5}   Age:{6}    Hired:{7} ",
                nameof(PostApplicant), applicant.Name, applicant.FamilyName,
                applicant.Address, applicant.CountryOfOrigin,
                applicant.EmailAddress, applicant.Age, applicant.Hired);
            _context.Applicants.Add(applicant);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetApplicant), new { id = applicant.Id }, applicant);
        }

        /// <summary>
        /// Deletes an Applicant by id.
        /// </summary>
        /// <returns>Status of deletion</returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Applicant>> DeleteApplicant(int id)
        {
            _logger.LogInformation("{0} called.", nameof(DeleteApplicant));
            var applicant = await _context.Applicants.FindAsync(id);
            if (applicant == null)
            {
                return NotFound();
            }

            _context.Applicants.Remove(applicant);
            await _context.SaveChangesAsync();

            return applicant;
        }

        private bool ApplicantExists(int id)
        {
            _logger.LogInformation("{0} called.", nameof(ApplicantExists));
            return _context.Applicants.Any(e => e.Id == id);
        }
    }
}
