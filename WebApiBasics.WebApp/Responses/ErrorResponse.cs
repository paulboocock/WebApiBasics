using System;
using System.Collections.Generic;

namespace WebApiBasics.WebApp.Responses
{
    public class ErrorResponse
    {
        public IList<Error> Errors { get; set; }
    }

    public class Error
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public ErrorSource Source { get; set; }
        public IDictionary<string, string> Meta { get; set; }
    }

    public class ErrorSource
    {
        public string Pointer { get; set; }
        public string Parameter { get; set; }
    }
}