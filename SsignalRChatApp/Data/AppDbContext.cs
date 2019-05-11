using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SsignalRChatApp
{
    public class AppDbContext : DbContext
    {
        private string mId;

        public String Id
        {
            get => mId;
            set => Guid.NewGuid().ToString("N");
        }

        public DbSet<SettingDataModel> Settings { get; set; }
        public DbSet<MessageViewModel> Message { get; set; }
        public DbSet<MessengerNodeViewModel> Node { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
