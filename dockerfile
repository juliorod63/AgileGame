FROM mcr.microsoft.com/dotnet/aspnet:3.1


WORKDIR /agilegameapp

COPY /agilegameapp /agilegameapp


EXPOSE 5000/tcp

ENV ASPNETCORE_URLS http://*:5000

ENTRYPOINT dotnet AgileGame.dll