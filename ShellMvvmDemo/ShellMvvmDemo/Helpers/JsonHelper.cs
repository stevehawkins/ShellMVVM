using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShellMvvmDemo.Helpers
{
    public static class JsonHelper
    {

        // serialise object
        public static string SerialiseObject<T>(T dataIn) where T : new()
        {
            var ser = JsonConvert.SerializeObject(dataIn);
            return ser;
        }

        // deserialise object
        public static T DeserialiseObject<T>(string dataIn) where T : new()
        {
            var ser = JsonConvert.DeserializeObject<T>(dataIn);
            return ser;
        }
    }
}
