var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.HelloWorld_Api>("helloworld-api");

builder.Build().Run();
