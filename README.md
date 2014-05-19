JsonWebApi
==========

A coding exercise to create a Web API that works with JSON format messages
Programming Language: C#.NET

Problem:

It's pretty simple. We'll post some JSON data to the URL you provide. You'll need to filter that data and return a few fields.

Details

From the list of shows in the request payload, return the ones with DRM enabled (drm: true) and at least one episode (episodeCount > 0).

The returned JSON should have a response key with an array of shows. Each element should have the following fields from the request:

image - corresponding to image/showImage from the request payload
slug
title
Error Handling

If we send invalid JSON, You'll need to return a JSON response with HTTP status 400 Bad Request, and with a `error` key containing the string Could not decode request. For example:

{
    "error": "Could not decode request: JSON parsing failed"
}

Solution:
It's a simple ASP.NET Web API project created using Visual Studio 2013. The solution has the API and Service layer.
The logic of filtering the shows has been put into Business layer. The Service is injected into API controller using dependency injection using unity IOC.
There are Two test projects to unit test Services and controllers.


