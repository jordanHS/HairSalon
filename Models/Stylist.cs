using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
    {
        public Stylist()
        {
            this.Clients = new HashSet<Item>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}