
namespace TagConfiguration2.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using TagConfiguration2.Models;
    using TagConfiguration2.Services;

  

        [ApiController]
        [Route("api/[controller]")]
        public class TagInputController : ControllerBase
        {
            private readonly TagInputService _tagInputService;

            public TagInputController(TagInputService tagInputService) =>
                _tagInputService = tagInputService;

            [HttpGet]
            public async Task<List<TagInput>> Get() =>
                await _tagInputService.GetAsync();

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [HttpGet("{id:length(24)}")]
            public async Task<ActionResult<TagInput>> Get(string id)
            {
                var tagInput = await _tagInputService.GetAsync(id);

                if (tagInput is null)
                {
                    return NotFound("toto");
                }

                return tagInput;
            }

            [HttpPost]
            public async Task<IActionResult> Post(TagInput newTagInput)
            {
                await _tagInputService.CreateAsync(newTagInput);

                return CreatedAtAction(nameof(Get), new { id = newTagInput.Id }, newTagInput);
            }

            [HttpPut("{id:length(24)}")]
            public async Task<IActionResult> Update(string id, TagInput updatedTagInput)
            {
                var book = await _tagInputService.GetAsync(id);

                if (book is null)
                {
                    return NotFound();
                }

                updatedTagInput.Id = book.Id;

                await _tagInputService.UpdateAsync(id, updatedTagInput);

                return NoContent();
            }

            [HttpDelete("{id:length(24)}")]
            public async Task<IActionResult> Delete(string id)
            {
                var book = await _tagInputService.GetAsync(id);

                if (book is null)
                {
                    return NotFound();
                }

                await _tagInputService.RemoveAsync(id);

                return NoContent();
            }
        }
    
}

