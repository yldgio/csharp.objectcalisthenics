using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OnelevelOfIndentationPerMethod;

public class Cache
{
    public List<object> CachedObjects { get; } = new();
    public void BuildCache()
    {
        var dataTable = new DataTable("thetable");
        var cache = new List<object>();
        foreach (DataRow row in dataTable.Rows)
        {

            if (row.HasErrors)
            {
                continue;
            }
            foreach (DataColumn column in dataTable.Columns)
            {
                var cellValue = (string)row[column];
                if (cellValue != "dontaddme")
                {
                    cache.Add(cellValue);
                }
            }
        }
        CachedObjects.AddRange(cache);  
    }
}
