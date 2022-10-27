// Jacob Dekok
// 10/25/2022
// Say Hello Endpoint
// This will take user input in the url bar
// and output saying hello
// Peer Reviewed by: Mark A Ramirez: says hello and then my name.


using Microsoft.AspNetCore.Mvc;

namespace dekokJSayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]

    public string SayHello(string name)
    {
        return $"Hello {name}";
    }
}
