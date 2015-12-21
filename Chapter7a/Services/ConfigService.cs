﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;
using Chapter7a.Models;

namespace Chapter7a.Services
{
    public class ConfigService
    {
        public Model LoadJSON()
        {
            string modelContent = File.ReadAllText(@"C:\ArcGISRuntimeBook\JSON\config_sf.json");
            return JsonConvert.DeserializeObject<Model>(modelContent);
        }
    }
}