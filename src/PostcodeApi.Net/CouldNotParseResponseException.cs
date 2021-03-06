﻿using System.Runtime.Serialization;

namespace PostcodeApi.Net
{
    [DataContract]
    public class CouldNotParseResponseException
    {
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }
    }
}
