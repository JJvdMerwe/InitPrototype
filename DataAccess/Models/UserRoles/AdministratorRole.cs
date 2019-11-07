using DataAccess.Models.Settings;

namespace DataAccess.Models
{
    public class AdministratorRole
    {
        public int AdministratorRoleId { get; set; }
        public AdministratorSettings AdministratorSettings { get; set; }
    }
}