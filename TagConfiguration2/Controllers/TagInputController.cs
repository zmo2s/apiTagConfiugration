
namespace TagConfiguration2.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MongoDB.Bson;
    using TagConfiguration2.Models;
    using TagConfiguration2.Services;



    [ApiController]
    [Route("api/[controller]")]
    public class TagInputController : ControllerBase
    {
        private readonly TagInputService _tagInputService;

        public TagInputController(TagInputService tagInputService) =>
            _tagInputService = tagInputService;


        /// <summary>
        /// Retrieves all tagInput
        /// </summary>
        /// <remarks>You need to insert the value in database before</remarks>
        /// <response code="200">get result of tag</response>
        /// <response code="400">tagInput table row is missing</response>
        [HttpGet]
        public async Task<List<Config>> Get() =>
            await _tagInputService.GetAsync();

      
        /*
        /// <summary>
        /// Get a specific row who contains the id.
        /// </summary>
        /// <param name="id">ID length must be of 24.</param>
        /// <returns>La colelction spécifique</returns>
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<TagInput>> Get(ObjectId id)
        {
            var tagInput = await _tagInputService.GetAsync(id);

            if (tagInput is null)
            {
                return NotFound("id doesn't exist");
            }

            return tagInput;
        }
        /*
        [HttpPost]
        public async Task<IActionResult> Post(TagInput newTagInput)
        {
            await _tagInputService.CreateAsync(newTagInput);

            return CreatedAtAction(nameof(Get), new { id = newTagInput.Id }, newTagInput);
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(ObjectId id, TagInput updatedTagInput)
        {
            var tagInput = await _tagInputService.GetAsync(id);

            if (tagInput is null)
            {
                return NotFound("id doesn't exist");
            }

            updatedTagInput.Id = tagInput.Id;

            await _tagInputService.UpdateAsync(id, updatedTagInput);

            return NoContent();
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(ObjectId id)
        {
            var tagInput = await _tagInputService.GetAsync(id);

            if (tagInput is null)
            {
                return NotFound("id doesn't exist");
            }

            await _tagInputService.RemoveAsync(id.ToString());

            return NoContent();
        }
        */
    }

}

