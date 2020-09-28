using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode {get; set;}
        public string Message {get; set;}
         
        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Ceci est une mauvaise requête",
                401 => "Vous n'êtes pas authorisé",
                404 => "La ressource n'est pas disponible ou n'existe pas",
                500 => "Il y a erreur interne du système",
                _ => null 
            };
        }
    }
}