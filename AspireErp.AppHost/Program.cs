var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.HelloWorld_Api>("helloworld-api");

builder.AddProject<Projects.AspireErp_Customers_Api>("aspireerp-customers-api");

builder.Build().Run();
