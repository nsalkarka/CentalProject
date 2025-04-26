using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccessLayer.Context
{
    public class CentalContext : IdentityDbContext<AppUser,AppRole,int>
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LDFLC27\\SQLEXPRESS;database=CentalDb;integrated security=true;trustServerCertificate=true");
            optionsBuilder.UseLazyLoadingProxies(); 
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<UserSocial> UserSocials { get; set; }
        public DbSet<SiteSettings> SiteSettings{ get; set; }
        public DbSet<SiteSettingsAdress> SiteSettingsAdresses{ get; set; }
        public DbSet<SiteSettingsQuickLink> SiteSettingsQuickLinks{ get; set; }
        public DbSet<SiteSettingsSocialMedia> SiteSettingsSocialMedias{ get; set; }
        public DbSet<SiteSettingsTopMenu> SiteSettingsTopMenus{ get; set; }
        public DbSet<MailingList> MailingLists{ get; set; }

    }
}
