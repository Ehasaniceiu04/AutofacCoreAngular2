using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Web.CoreApp.Model;

namespace CoreMVCApp.Migrations
{
    [DbContext(typeof(EngineerContext))]
    [Migration("20161201211933_firstmigration")]
    partial class firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Web.CoreApp.Model.Engineer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FatherName");

                    b.Property<string>("MotherName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Engineers");
                });

            modelBuilder.Entity("Web.CoreApp.Model.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("EngineerId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("EngineerId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("Web.CoreApp.Model.Experience", b =>
                {
                    b.HasOne("Web.CoreApp.Model.Engineer")
                        .WithMany("Experiences")
                        .HasForeignKey("EngineerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
