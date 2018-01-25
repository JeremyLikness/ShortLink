using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortLink
{
    public class UrlData : TableEntity 
    {
        public string Url { get; set; }
        public int Count { get; set; }
    }
}
