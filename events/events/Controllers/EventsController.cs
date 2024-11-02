using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace events.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
       public static List<Event> eventsList = new List<Event>();
 
        // GET: api/<eventsController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return eventsList;
        }


        // POST api/<eventsController>
        [HttpPost]
        public void Post([FromBody] Event e)
        {
       
            eventsList.Add(e);
        }

        // PUT api/<eventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event e)
        {
            foreach (Event e1 in eventsList)
            {
                if (e1.Id == id)
                {
                    e1.Id = e.Id;
                    e1.Title= e.Title;
                    e1.Start= e.Start;
                    e1.End= e.End;
                    break;
                }
            }
        }

        // DELETE api/<eventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (Event e1 in eventsList)
            {
                if(e1.Id == id)
                {
                    eventsList.Remove(e1);
                    break;
                }
            }
        }
    }
}
