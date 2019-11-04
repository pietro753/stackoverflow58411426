# ASP.NET Web API Internal server error when client is disconnected

Repo for Stackoverflow [question #58411426](https://stackoverflow.com/questions/58411426/asp-net-web-api-internal-server-error-when-client-is-disconnected)

Steps to reproduce

1. Create an empty WebApi2 Project in VS
2. Create a [controller](ClientDisconnectedDemo/Controllers/HomeController.cs) with non get action
3. Integrate with Application Insights or [extend global.asax.cs](ClientDisconnectedDemo/Global.asax.cs) with Application_EndRequest.
4. Execute a non get request and cancel it after 10ms

