using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace papi_prac1_back;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private readonly MessageManager _messageManager;

    public MessageController(MessageManager messageManager)
    {
        _messageManager = messageManager;
    }

    [HttpGet]
    public IActionResult GetMessages()
    {
        var messages = _messageManager.GetMessages();
        return Ok(messages);
    }

    [HttpGet("{id}")]
    public IActionResult GetMessage(int id)
    {
        var message = _messageManager.GetMessage(id);
        if (message == null)
        {
            return NotFound();
        }
        return Ok(message);
    }

    [HttpPost]
    public IActionResult AddMessage([FromBody] Message message)
    {
        _messageManager.AddMessage(message);
        return CreatedAtAction(nameof(GetMessage), new { id = message.id }, message);
    }
}