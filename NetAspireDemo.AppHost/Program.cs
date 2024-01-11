var builder = DistributedApplication.CreateBuilder(args);

var backend = builder.AddProject<Projects.Backend>("backend");

builder.AddProject<Projects.Frontend>("frontend").WithReference(backend);

builder.Build().Run();
