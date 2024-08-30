# .NET HTTP Function

This is an HTTP function template for .NET, which can be used to create serverless functions running on Knative.

## How to use

- Define your function logic in `func.cs`.
- Customize `Startup.cs` to configure services and the request pipeline.
- Build and deploy using the `func` CLI.

## Example

This template responds to HTTP POST requests with a JSON object containing the original input and a greeting message.
