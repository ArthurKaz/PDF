using Microsoft.AspNetCore.Mvc;
using PDFOfferCreator.Api.Models;
using PDFOfferCreator.Model;

namespace PDFOfferCreator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferDataController : ControllerBase
    {
        private readonly IOfferDataRepository offerDataRepository;

        public OfferDataController(IOfferDataRepository offerDataRepository)
        {
            this.offerDataRepository = offerDataRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OfferData>>> GetOfferData()
        {
            try
            {
                var offerData = await offerDataRepository.GetAllOfferDataAsync();
                return Ok(offerData);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<OfferData>> GetOfferData(int id)
        {
            try
            {
                var offerData = await offerDataRepository.GetOfferDataByIdAsync(id);

                if (offerData == null)
                {
                    return NotFound();
                }

                return offerData;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<OfferData>> CreateOfferData(OfferData offerData)
        {
            try
            {
                if (offerData == null)
                {
                    return BadRequest();
                }

                var newOfferData = await offerDataRepository.AddOfferDataAsync(offerData);
                return CreatedAtAction(nameof(GetOfferData), new { id = offerData.Id }, offerData); 
               // return CreatedAtAction(nameof(GetOfferData), new { id = newOfferData.Id }, newOfferData);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating data");
            }
        }

        [HttpPut()]
        public async Task<ActionResult<OfferData>> UpdateOfferData( OfferData offerData)
        {
            try
            {

                var existingOfferData = await offerDataRepository.GetOfferDataByIdAsync(offerData.Id);

                if (existingOfferData == null)
                {
                    return NotFound($"OfferData with Id = {offerData.Id} not found");
                }

                var updatedOfferData = await offerDataRepository.UpdateOfferDataAsync(offerData);

                return Ok(updatedOfferData);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating data");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<OfferData>> DeleteOfferData(int id)
        {
            try
            {
                var offerDataToDelete = await offerDataRepository.GetOfferDataByIdAsync(id);

                if (offerDataToDelete == null)
                {
                    return NotFound($"OfferData with Id = {id} not found");
                }

                var deletedOfferData = await offerDataRepository.DeleteOfferDataAsync(id);

                return Ok(deletedOfferData);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting data");
            }
        }
    }
}
