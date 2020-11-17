using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Entity
{
    public class EntityAttribute : Attribute
    {
		public string TableName { get; set; }
		public Type[] ChildTable { get; set; }
		public string DBName { get; set; }
		public bool CurrentUserPermission { get; set; }
		public Type InputApi { get; set; }
		public Type OutputApi { get; set; }

	}
}
