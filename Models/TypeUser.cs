using System.Collections.Generic;

#nullable disable

namespace TexnoMarket.Models
{
    public partial class TypeUser
    {
        public TypeUser()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
