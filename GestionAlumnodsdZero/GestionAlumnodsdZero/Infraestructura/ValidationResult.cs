﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAlumnodsdZero.Infraestructura
{
    public class ValidationResult
    {

        public bool IsSuccess { get; set; }
        public List<string> Errors { get; set; } = new List<string>();

        public string AllErrors
        {
            get
            {
                var output = string.Empty;

                foreach (var error in Errors)
                    output += error + "\n\r";

                return output;
            }
        }
    }

    public class ValidationResult<T> : ValidationResult
    {
        public T ValidatedResult { get; set; }
    }
}

