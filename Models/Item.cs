using System;
using System.ComponentModel.DataAnnotations;

namespace projectPurpleCow
{
    public class Item
    {
        [Required]
        public string name { get; set; }

        [Required]
        public int id { get; set; }

        public Item()
        {
        }

        public Item(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
