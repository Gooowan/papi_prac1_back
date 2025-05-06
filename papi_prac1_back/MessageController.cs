using Microsoft.AspNetCore.Mvc;

namespace papi_prac1_back;

[ApiController]
[Route("messages")]
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
    public IActionResult AddMessage([FromBody] MessageDTO message)
    {
        _messageManager.AddMessage(message);
        return Ok("Message added successfully.");
    }
}