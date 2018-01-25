using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortLink
{
    public class UrlKey : TableEntity 
    {
        public int Id { get; set; }
    }
}
