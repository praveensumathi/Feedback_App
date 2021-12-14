using Feedback.Application.Common.Model;
using Feedback.Application.Features.Event.Models;
using Feedback.Application.Features.Event.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Feedback.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ApiControllerBase
    {
        public EventController()
        {

        }

        [HttpGet("[action]")]
        [ProducesResponseType(typeof(PaginatedModel<EventModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get
            (int offSet,
            int pageSize,
            string sortColumn,
            string sortDirection,
            string title,
            string description,
            string place,
            string date,
            string startTime,
            string endTime,
            string organizedBy
            )
        {
            var getEventsQuery = new GetEventsQuery()
            {
                OffSet = offSet,
                PageSize = pageSize,
                SortColumn = sortColumn,
                SortDirection = sortDirection,
                Title = title,
                Description = description,
                Place = place,
                Date = date,
                StartTime = startTime,
                EndTime = endTime,
                OrganizedBy = organizedBy
            };
            return Ok(await Mediator.Send(getEventsQuery));
        }

    }
}
