using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Entity.DomainModels
{
    [JsonObject]
    public class Sys_TableColnumnEntity
    {
        [JsonProperty("columnType")]
        public string ColumnType { get; set; }

        [JsonProperty("columnName")]
        public string ColumnName { get; set; }
    }
}
