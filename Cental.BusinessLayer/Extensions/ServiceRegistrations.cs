﻿using Cental.BusinessLayer.Abstract;
using Cental.BusinessLayer.Concrete;
using Cental.DataAccessLayer.Abstract;
using Cental.DataAccessLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddServiceRegistrations(this IServiceCollection services)
        {
            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<IAboutService, AboutManager>();
            
            services.AddScoped<IBannerDal, EfBannerDal>();
            services.AddScoped<IBannerService, BannerManager>();
            
            services.AddScoped<IBrandDal, EfBrandDal>();
            services.AddScoped<IBrandService, BrandManager>();

            services.AddScoped<IFeatureDal, EfFeatureDal>();
            services.AddScoped<IFeatureService, FeatureManager>();

            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<IServiceService, ServiceManager>();

            services.AddScoped<IProcessDal, EfProcessDal>();
            services.AddScoped<IProcessService, ProcessManager>();

            services.AddScoped<ICarDal, EfCarDal>();
            services.AddScoped<ICarService, CarManager>();

            services.AddScoped<IImageSurvice, ImageService>();

            services.AddScoped<IUserSocialService, UserSocialManager>();
            services.AddScoped<IUserSocialDal, EfUserSocialDal>();

            services.AddScoped<ISiteSettingsService, SiteSettingsManager>();
            services.AddScoped<ISiteSettingsDal, EfSiteSettingsDal>();

            services.AddScoped<ISiteSettingsAdressService, SiteSettingsAdressManager>();
            services.AddScoped<ISiteSettingsAdressDal, EfSiteSettingsAdressDal>();

            services.AddScoped<ISiteSettingsQuickLinkService, SiteSettingsQuickLinkManager>();
            services.AddScoped<ISiteSettingsQuickLinkDal, EfSiteSettingsQuickLinkDal>();

            services.AddScoped<ISiteSettingsSocialMediaService, SiteSettingsSocialMediaManager>();
            services.AddScoped<ISiteSettingsSocialMediaDal, EfSiteSettingsSocialMediaDal>();

            services.AddScoped<ISiteSettingsTopMenuService, SiteSettingsTopMenuManager>();
            services.AddScoped<ISiteSettingsTopMenuDal, EfSiteSettingsTopMenuDal>();

            services.AddScoped<ITestimonialService,TestimonialManager>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();

            services.AddScoped<IMailListService, MailListManager>();
            services.AddScoped<IMailingListDal, EfMailingListDal>();
        }   
    }
}
