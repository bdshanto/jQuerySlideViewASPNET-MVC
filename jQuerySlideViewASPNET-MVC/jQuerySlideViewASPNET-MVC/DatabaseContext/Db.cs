using System.Data.Entity;
using jQuerySlideViewASPNET_MVC.Models;

namespace jQuerySlideViewASPNET_MVC.DatabaseContext
{
    public class Db:DbContext
    {
        public DbSet<StudentInformation> StudentInformations { get; set; }
        
    }
}