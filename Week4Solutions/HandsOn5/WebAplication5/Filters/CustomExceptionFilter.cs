using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class CustomExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        var exception = context.Exception;
        string logPath = Path.Combine(Directory.GetCurrentDirectory(), "error_log.txt");

        File.AppendAllText(logPath, $"{DateTime.Now}: {exception.Message}\n");

        context.Result = new ObjectResult("Something went wrong.")
        {
            StatusCode = 500
        };
    }
}
