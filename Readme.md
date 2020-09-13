# Hsf.ApplicationProcess.Application

This is a WEB API developed in .Net Core 3.1 with a frontend that consumes that API in Blazor.

Web API supports the following HTTP requests:

Endpoint: Create an applicant - Route: "/api/Applicants", Verb: POST

Endpoint: Get all apllicants - /api/Applicants, Verb: GET

Endpoint: Get an applicant by id - /api/Applicants/{id}, Verb: GET

Endpoint: Update a given applicant - /api/Applicants/{id}, Verb: PUT

Endpoint: Delete an applicant by id - /api/Applicants/{id}, Verb: DELETE

Other:

Swagger IU available at /swagger Endpoint
Serlog Log available within a Log folder
FluentValidation on WebAPI end
DataAnnotation validation on the Blazor end


Blazor:
- Get all applicants - display all Applicants in the table
- Post an applicant - send a POST request to WEB API with the form provided.
Sending is only possible when all data is valid. Reset the form with reset button.

How to build and run:
(do it for both Web and Blazor)
- dotnet restore
- dotnet build
----------------------------
- make sure that Multiple Startup Projects is turned on for both Blazor and Web
- dotnet run


In case of connection problem between API and Blazor, make sure the localhost's ports match in Blazor and API,
although they are and should be configured correctly.

Improvements in the future:
- Reset button working only if something is written in the form
- POST success confirmation
- Authentication 
