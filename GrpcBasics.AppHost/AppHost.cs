var builder = DistributedApplication.CreateBuilder(args);

// Add the Blazor frontend
builder.AddProject<Projects.BlazorGrpcClient>("blazorgrpcclient");

// Add the gRPC server
builder.AddProject<Projects.GrpcStudentsServer>("grpcstudentsserver");

builder.Build().Run();