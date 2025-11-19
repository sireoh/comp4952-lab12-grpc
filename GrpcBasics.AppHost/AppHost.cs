var builder = DistributedApplication.CreateBuilder(args);

// This goes into AppHost project
var grpc = builder.AddProject<Projects.GrpcStudentsServer>("backend");
builder.AddProject<Projects.BlazorGrpcClient>("frontend")
    .WithReference(grpc);

builder.Build().Run();