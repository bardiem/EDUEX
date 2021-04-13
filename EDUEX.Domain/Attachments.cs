using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace EDUEX.Domain
{
    public class Attachments
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Attachment { get; set; }
        public DateTime DateCreated { get; set; }
    }
}