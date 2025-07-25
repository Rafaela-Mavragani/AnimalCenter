﻿namespace AnimalCenterAPI.Exceptions
{
    public abstract class AppException : Exception
    {
        public string Code { get; set; }
        public AppException(string code, string message) : base(message)
        {
            Code = code;
        }
    }
}

// This code defines an abstract class `AppException` that inherits from `Exception`.
