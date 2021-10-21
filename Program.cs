using Microsoft.Extensions.Logging;
using System.Text.Encodings.Web;
using System.Text.Json;

ILoggerFactory loggerFactory = LoggerFactory.Create(loggingBuilder =>
{
    loggingBuilder.ClearProviders();
    //loggingBuilder.AddConsole();
    loggingBuilder.AddJsonConsole(jsonConsoleFormatterOptions =>
    {
        jsonConsoleFormatterOptions.IncludeScopes = true;
        jsonConsoleFormatterOptions.UseUtcTimestamp = false;
        jsonConsoleFormatterOptions.JsonWriterOptions = new JsonWriterOptions
        {
            Indented = false,
        };
    });
});

ILogger<Program> logger = loggerFactory.CreateLogger<Program>();
logger.LogInformation(new EventId(10, "Issue Ticket"), "Issuing Ticket, Ticket Number: {TicketNumber}, PNR: {PNR}", 4911004983137, "JFFB3");

