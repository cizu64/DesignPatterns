﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class JsonConverter
    {
        private IEnumerable<Manufacturer> _manufacturers;
        
        public JsonConverter(IEnumerable<Manufacturer> manufacturers)
        {
            _manufacturers = manufacturers;
        }

        public void ConvertToJson()
        {
            var jsonManufacturers = JsonConvert.SerializeObject(_manufacturers, Formatting.Indented);

            Console.WriteLine("\nPrinting JSON list\n");
            Console.WriteLine(jsonManufacturers);
        }
    }
}
