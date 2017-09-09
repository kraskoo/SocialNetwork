namespace SocialNetwork.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Common;
    using Common.Extensions;
    using Models.ApplicationEntities;
    using Models.ApplicationEntities.Details;


    public class SocialNetworkContext : IdentityDbContext<User>
    {
        public SocialNetworkContext(
            DbContextOptions<SocialNetworkContext> options) : base(options)
        {
        }

        public DbSet<UserFriend> UserFriends { get; set; }

        public DbSet<Street> Streets { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Continent> Continents { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<UserInformation> UserInformations { get; set; }

        public DbSet<InformationDetail> InformationDetails { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Frame> Frames { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<UserPost> UserPosts { get; set; }

        public DbSet<MachinePost> MachinePosts { get; set; }

        public DbSet<Wall> Walls { get; set; }

        public SocialNetworkContext() : base(GetOptionBuilder().Options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<MachinePost>()
                .HasMany(mp => mp.Comments)
                .WithOne(c => c.MachinePost)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<UserPost>()
                .HasMany(mp => mp.Comments)
                .WithOne(c => c.UserPost)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Comment>()
                .HasOne(c => c.Author)
                .WithMany(a => a.Comments)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Wall>()
                .HasMany(w => w.MachinePosts)
                .WithOne(mp => mp.Wall)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Wall>()
                .HasMany(w => w.UserPosts)
                .WithOne(up => up.Wall)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Wall>()
                .HasOne(w => w.User)
                .WithOne(u => u.Wall)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<User>()
                .HasOne(u => u.Wall)
                .WithOne(w => w.User)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<User>()
                .HasMany(u => u.Comments)
                .WithOne(c => c.Author)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<UserFriend>()
                .HasKey(ur => new { ur.UserId, ur.FriendId });
            builder.Entity<User>()
                .HasMany(u => u.UserFriends)
                .WithOne(u => u.Friend)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Continent>()
                .HasMany(c => c.Countries)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Country>()
                .HasMany(c => c.Cities)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<City>()
                .HasMany(c => c.Streets)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Street>()
                .HasMany(str => str.Addresses)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(GetOptionBuilder(optionsBuilder));
        }

        private static DbContextOptionsBuilder GetOptionBuilder(DbContextOptionsBuilder builder = null)
        {
            if (builder == null)
            {
                builder = new DbContextOptionsBuilder();
            }

            return builder
                .UseSqlServer(
                CommonApplicationStrings.ConnectionString
                    .GetFormattedString(
                        nameof(SocialNetworkContext)
                            .Replace("Context", string.Empty)));
        }
    }
}