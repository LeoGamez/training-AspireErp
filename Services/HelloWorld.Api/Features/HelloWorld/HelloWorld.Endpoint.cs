using Carter;

namespace HelloWorld.Api.Features.HelloWorld;

public class HelloWorld : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("helloworld", () => {
            return Results.Ok("Hello from API");
        })
        .WithName("Helloworld")
        .Produces<string>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Hello World")
        .WithDescription("Hello World")
        .WithOpenApi();
    }
}
