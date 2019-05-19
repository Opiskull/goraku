using System;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Linq;

namespace Goraku.Web.Models
{
    public class Item
    {
        public Guid Id { get; set; }

        [Column(TypeName="jsonb")]
        public string Data { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}