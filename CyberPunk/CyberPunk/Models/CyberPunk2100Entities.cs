namespace CyberPunk.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CyberPunk2100Entities : DbContext
    {
        public CyberPunk2100Entities()
            : base("name=CyberPunk2100Entities")
        {
        }

        public virtual DbSet<Add_Features> Add_Features { get; set; }
        public virtual DbSet<Add_skills> Add_skills { get; set; }
        public virtual DbSet<Armors> Armors { get; set; }
        public virtual DbSet<Bodies> Bodies { get; set; }
        public virtual DbSet<Bullets> Bullets { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Corporations> Corporations { get; set; }
        public virtual DbSet<Dices> Dices { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<Enumgrades> Enumgrades { get; set; }
        public virtual DbSet<FeatureEnum> FeatureEnum { get; set; }
        public virtual DbSet<Features> Features { get; set; }
        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<PATENTS> PATENTS { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<People_Specialcapacities> People_Specialcapacities { get; set; }
        public virtual DbSet<Places> Places { get; set; }
        public virtual DbSet<Properties> Properties { get; set; }
        public virtual DbSet<Remove_Features> Remove_Features { get; set; }
        public virtual DbSet<Resources> Resources { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Roles_Skills> Roles_Skills { get; set; }
        public virtual DbSet<Roles_Specialabilities> Roles_Specialabilities { get; set; }
        public virtual DbSet<SkillEnum> SkillEnum { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<Specialabilities> Specialabilities { get; set; }
        public virtual DbSet<SpecialabilitiesEnum> SpecialabilitiesEnum { get; set; }
        public virtual DbSet<Spoken> Spoken { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Weaponfamilies> Weaponfamilies { get; set; }
        public virtual DbSet<Weapons> Weapons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Armors>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Armors>()
                .HasMany(e => e.Bodies)
                .WithMany(e => e.Armors)
                .Map(m => m.ToTable("Armors_Bodies").MapLeftKey("IdArmor").MapRightKey("IdBody"));

            modelBuilder.Entity<Bodies>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Bullets>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Bullets>()
                .HasMany(e => e.Weapons)
                .WithMany(e => e.Bullets)
                .Map(m => m.ToTable("Weapons_Bullets").MapLeftKey("IdBullet").MapRightKey("IdWeapon"));

            modelBuilder.Entity<Cities>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Districts)
                .WithRequired(e => e.Cities)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Corporations)
                .WithMany(e => e.Cities)
                .Map(m => m.ToTable("Corpos_Cities").MapLeftKey("IdCity").MapRightKey("IdCorporation"));

            modelBuilder.Entity<Corporations>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Corporations>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<Corporations>()
                .HasMany(e => e.Resources)
                .WithRequired(e => e.Corporations)
                .HasForeignKey(e => e.IdPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dices>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Dices>()
                .HasMany(e => e.Weapons)
                .WithRequired(e => e.Dices)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Districts>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.Properties)
                .WithRequired(e => e.Districts)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Enumgrades>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Enumgrades>()
                .HasMany(e => e.Grades)
                .WithRequired(e => e.Enumgrades)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FeatureEnum>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FeatureEnum>()
                .HasMany(e => e.Features)
                .WithRequired(e => e.FeatureEnum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FeatureEnum>()
                .HasMany(e => e.SkillEnum)
                .WithRequired(e => e.FeatureEnum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Features>()
                .HasMany(e => e.Add_Features)
                .WithRequired(e => e.Features)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Features>()
                .HasMany(e => e.Skills)
                .WithRequired(e => e.Features)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Features>()
                .HasMany(e => e.Remove_Features)
                .WithRequired(e => e.Features)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Features>()
                .HasMany(e => e.People)
                .WithMany(e => e.Features)
                .Map(m => m.ToTable("People_Features").MapLeftKey("IdFeature").MapRightKey("IdPerson"));

            modelBuilder.Entity<Languages>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Languages>()
                .HasMany(e => e.Spoken)
                .WithRequired(e => e.Languages)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PATENTS>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PATENTS>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PATENTS>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PATENTS>()
                .HasMany(e => e.Add_Features)
                .WithRequired(e => e.PATENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PATENTS>()
                .HasMany(e => e.Add_skills)
                .WithRequired(e => e.PATENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PATENTS>()
                .HasMany(e => e.Remove_Features)
                .WithRequired(e => e.PATENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PATENTS>()
                .HasMany(e => e.People)
                .WithMany(e => e.PATENTS)
                .Map(m => m.ToTable("owns").MapLeftKey("idPatent").MapRightKey("IdPerson"));

            modelBuilder.Entity<People>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<People>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Resources)
                .WithOptional(e => e.People)
                .HasForeignKey(e => e.IdAnotherPerson);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Resources1)
                .WithRequired(e => e.People1)
                .HasForeignKey(e => e.IdPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Spoken)
                .WithRequired(e => e.People)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.People_Specialcapacities)
                .WithRequired(e => e.People)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Skills)
                .WithMany(e => e.People)
                .Map(m => m.ToTable("People_Skills").MapLeftKey("IdPerson").MapRightKey("IdSkill"));

            modelBuilder.Entity<Places>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Properties>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Roles>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.People)
                .WithRequired(e => e.Roles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SkillEnum>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SkillEnum>()
                .HasMany(e => e.Skills)
                .WithRequired(e => e.SkillEnum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Skills>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Skills>()
                .HasMany(e => e.Add_skills)
                .WithRequired(e => e.Skills)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialabilitiesEnum>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SpecialabilitiesEnum>()
                .HasMany(e => e.People_Specialcapacities)
                .WithRequired(e => e.SpecialabilitiesEnum)
                .HasForeignKey(e => e.IdSpecialAbility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialabilitiesEnum>()
                .HasMany(e => e.Specialabilities)
                .WithRequired(e => e.SpecialabilitiesEnum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Weaponfamilies>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Weapons>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Weapons>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
