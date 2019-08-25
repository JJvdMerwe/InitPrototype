using InitPrototype.DataAccess.Models.Settings;

namespace InitPrototype.DataAccess.Models
{
    public class AdministratorRole
    {
        public int AdministratorRoleId { get; set; }
        public AdministratorSettings AdministratorSettings { get; set; }
    }
}