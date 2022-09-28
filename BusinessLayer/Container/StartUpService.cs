using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class StartUpService
    {
        public static void ServicesDependencies(this IServiceCollection services)
        {
            //Services
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IDestinationService, DestinationService>();
            services.AddScoped<IFeature2Service, Feature2Service>();
            services.AddScoped<IFeatureService, FeatureService>();
            services.AddScoped<IGuideService, GuideService>();
            services.AddScoped<INewsLetterService, NewsLetterService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<ISubAboutService, SubAboutService>();
            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<IMessageService, MessageService>();

            //EF
            services.AddScoped<IAboutDal, EfAboutRepository>();
            services.AddScoped<IContactDal, EfContactRepository>();
            services.AddScoped<ICommentDal, EfCommentRepository>();
            services.AddScoped<IDestinationDal, EfDestinationRepository>();
            services.AddScoped<IFeature2Dal, EfFeature2Repository>();
            services.AddScoped<IFeatureDal, EfFeatureRepository>();
            services.AddScoped<IGuideDal, EfGuideRepository>();
            services.AddScoped<INewsLetterDal, EfNewsLetterRepository>();
            services.AddScoped<IReservationDal, EfReservationRepository>();
            services.AddScoped<ISubAboutDal, EfSubAboutRepository>();
            services.AddScoped<ITestimonialDal, EfTestimonialRepository>();
            services.AddScoped<IMessageDal, EfMessageRepository>();
        }
    }
}
