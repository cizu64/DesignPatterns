using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XUnitTestProject
{
    public class SearchController
    {
        public string Search(string query)
        {
            return query;
        }
        public List<string> SearchList(List<string> obj, string query)
        {
            var result = obj.Where(s => s == query).ToList();
            return result;
        }
    }
}
