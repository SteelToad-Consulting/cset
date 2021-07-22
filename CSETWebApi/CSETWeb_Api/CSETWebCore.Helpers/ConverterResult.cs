﻿using System.Collections.Generic;
using CSETWebCore.Interfaces;

namespace CSETWebCore.Helpers
{
    public class ConverterResult<T> where T : class, new()
    {
        private ILogger logger;
        private ICollection<string> errorMessages;
        public bool IsSuccess
        {
            get
            {

                return errorMessages.Count == 0;
            }
        }
        public IEnumerable<string> ErrorMessages
        {
            get
            {
                return errorMessages;
            }
        }
        public void LogError(string error)
        {
            this.logger.Log(error);
            errorMessages.Add(error);
        }
        public T Result { get; set; }
        public ConverterResult(ILogger logger)
        {
            this.logger = logger;
            errorMessages = new List<string>();
            Result = new T();
        }
    }
}