using System;
using System.ComponentModel.DataAnnotations;

namespace Instagram.Models
{
    public class FileModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
