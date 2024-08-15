using Microsoft.EntityFrameworkCore;

namespace GiveAID_API.Models.Context
{
    public partial class GiveAIDContext : DbContext
    {
        public GiveAIDContext()
        {
        }

        public GiveAIDContext(DbContextOptions<GiveAIDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }

        public virtual DbSet<Topic> Topics { get; set; }

        public virtual DbSet<Organization_program> Organization_programs { get; set; }

        public virtual DbSet<Donation> Donations { get; set; }

        public virtual DbSet<Gallery> Galleries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=LAPTOP-Q9E21TFO\\MEOMEO;Initial Catalog=GiveAID;Integrated Security=True;TrustServerCertificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("Account");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e=>e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("password");
                entity.Property(e => e.Avt)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("avt");
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");
                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("description");
                entity.Property(e => e.Type_acc).HasColumnName("type_acc");
                entity.Property(e => e.Follower).HasColumnName("follower");
                entity.Property(e => e.Like).HasColumnName("like");
                entity.Property(e => e.Support).HasColumnName("support");
                entity.Property(e => e.Created_at)
                    .HasColumnType("date")
                    .HasColumnName("created_at");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("Topic");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Topic_name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("topic_name");
            });

            modelBuilder.Entity<Organization_program>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("Organization_program");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.O_name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("o_name");
                entity.Property(e => e.O_description)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("o_description");
                entity.Property(e => e.O_image)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("o_image");
                entity.Property(e => e.O_address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("o_address");
                entity.Property(e => e.Day_start)
                    .HasColumnType("date")
                    .HasColumnName("day_start");
                entity.Property(e => e.Day_end)
                    .HasColumnType("date")
                    .HasColumnName("day_end");
                entity.Property(e => e.Target).HasColumnName("target");
                entity.Property(e => e.Current).HasColumnName("current");
                entity.Property(e => e.Status).HasColumnName("status");
                entity.Property(e => e.Outstanding).HasColumnName("outstanding");
                entity.Property(e => e.Topic_id).HasColumnName("topic_id");
                entity.Property(e => e.Id_account).HasColumnName("id_account");

                entity.HasOne(d => d.Topic_idNavigation).WithMany(p => p.Organization_Programs)
                    .HasForeignKey(d => d.Topic_id)
                    .HasConstraintName("fk_org_topic");

                entity.HasOne(d => d.Id_accounttNavigation).WithMany(p => p.Organization_Programs)
                    .HasForeignKey(d => d.Id_account)
                    .HasConstraintName("fk_org_account");
            });

            modelBuilder.Entity<Donation>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.ToTable("Donation");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Donate_money).HasColumnName("donate_money");
                entity.Property(e => e.Donation_date)
                    .HasColumnType("date")
                    .HasColumnName("donation_date");
                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("description");
                entity.Property(e => e.Trade_code).HasColumnName("trade_code");
                entity.Property(e => e.Id_account).HasColumnName("id_account");
                entity.Property(e => e.Id_program).HasColumnName("id_program");

                entity.HasOne(d => d.Id_accountNavigation).WithMany(p => p.Donations)
                    .HasForeignKey(d => d.Id_account)
                    .HasConstraintName("fk_donate_account");

                entity.HasOne(d => d.Id_programtNavigation).WithMany(p => p.Donations)
                    .HasForeignKey(d => d.Id_program)
                    .HasConstraintName("fk_donate_org");
            });

            modelBuilder.Entity<Gallery>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("Gallery");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Image)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("image");
                entity.Property(e => e.Image1)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("image1");
                entity.Property(e => e.Image2)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("image2");
                entity.Property(e => e.G_description)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("g_description");
                entity.Property(e => e.Created_at)
                    .HasColumnType("date")
                    .HasColumnName("created_at");
                entity.Property(e => e.Program_id).HasColumnName("program_id");
                entity.Property(e => e.Account_id).HasColumnName("account_id");

                entity.HasOne(d => d.Program_idNavigation).WithMany(p => p.Galleries)
                    .HasForeignKey(d => d.Program_id)
                    .HasConstraintName("fk_gallery_org");
                entity.HasOne(d => d.Account_idNavigation).WithMany(p => p.Galleries)
                    .HasForeignKey(d => d.Account_id)
                    .HasConstraintName("fk_gallery_acc");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
