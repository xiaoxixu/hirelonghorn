﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hirelonghorn.DAL;

namespace hirelonghorn.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("hirelonghorn.Models.Application", b =>
                {
                    b.Property<int>("ApplicationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("AppUserId");

                    b.Property<DateTime>("ApplicationDate");

                    b.Property<int?>("PositionID");

                    b.Property<string>("StatusType")
                        .IsRequired();

                    b.HasKey("ApplicationID");

                    b.HasIndex("AppUserId");

                    b.HasIndex("PositionID");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("hirelonghorn.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<bool>("Active");

                    b.Property<int?>("CompanyID");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<decimal>("GPA");

                    b.Property<int>("GraduationDate");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<int?>("MajorID");

                    b.Property<string>("MiddleInitial");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PositionType");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CompanyID");

                    b.HasIndex("MajorID");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("hirelonghorn.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyEmail")
                        .IsRequired();

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Industry")
                        .IsRequired();

                    b.HasKey("CompanyID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("hirelonghorn.Models.Interview", b =>
                {
                    b.Property<int>("InterviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InterviewTime");

                    b.Property<string>("IntervieweeId");

                    b.Property<string>("InterviewerId");

                    b.Property<int?>("PositionID");

                    b.Property<string>("RoomNumber")
                        .IsRequired();

                    b.HasKey("InterviewId");

                    b.HasIndex("IntervieweeId");

                    b.HasIndex("InterviewerId");

                    b.HasIndex("PositionID");

                    b.ToTable("Interviews");
                });

            modelBuilder.Entity("hirelonghorn.Models.Major", b =>
                {
                    b.Property<int>("MajorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MajorName")
                        .IsRequired();

                    b.HasKey("MajorID");

                    b.ToTable("Majors");
                });

            modelBuilder.Entity("hirelonghorn.Models.MajorPosition", b =>
                {
                    b.Property<int>("MajorPositionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MajorID");

                    b.Property<int?>("PositionID");

                    b.HasKey("MajorPositionID");

                    b.HasIndex("MajorID");

                    b.HasIndex("PositionID");

                    b.ToTable("MajorPositions");
                });

            modelBuilder.Entity("hirelonghorn.Models.Position", b =>
                {
                    b.Property<int>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyID");

                    b.Property<DateTime>("Deadline");

                    b.Property<string>("Description");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("PositionTitle")
                        .IsRequired();

                    b.Property<string>("PositionType")
                        .IsRequired();

                    b.HasKey("PositionID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("hirelonghorn.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("hirelonghorn.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hirelonghorn.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("hirelonghorn.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("hirelonghorn.Models.Application", b =>
                {
                    b.HasOne("hirelonghorn.Models.AppUser", "AppUser")
                        .WithMany("Applications")
                        .HasForeignKey("AppUserId");

                    b.HasOne("hirelonghorn.Models.Position", "Position")
                        .WithMany("Applications")
                        .HasForeignKey("PositionID");
                });

            modelBuilder.Entity("hirelonghorn.Models.AppUser", b =>
                {
                    b.HasOne("hirelonghorn.Models.Company", "Company")
                        .WithMany("AppUsers")
                        .HasForeignKey("CompanyID");

                    b.HasOne("hirelonghorn.Models.Major", "Major")
                        .WithMany("AppUsers")
                        .HasForeignKey("MajorID");
                });

            modelBuilder.Entity("hirelonghorn.Models.Interview", b =>
                {
                    b.HasOne("hirelonghorn.Models.AppUser", "Interviewee")
                        .WithMany("InterviewsSuffered")
                        .HasForeignKey("IntervieweeId");

                    b.HasOne("hirelonghorn.Models.AppUser", "Interviewer")
                        .WithMany("InterviewsGiven")
                        .HasForeignKey("InterviewerId");

                    b.HasOne("hirelonghorn.Models.Position", "Position")
                        .WithMany("Interviews")
                        .HasForeignKey("PositionID");
                });

            modelBuilder.Entity("hirelonghorn.Models.MajorPosition", b =>
                {
                    b.HasOne("hirelonghorn.Models.Major", "Major")
                        .WithMany("MajorPositions")
                        .HasForeignKey("MajorID");

                    b.HasOne("hirelonghorn.Models.Position", "Position")
                        .WithMany("MajorPositions")
                        .HasForeignKey("PositionID");
                });

            modelBuilder.Entity("hirelonghorn.Models.Position", b =>
                {
                    b.HasOne("hirelonghorn.Models.Company", "Company")
                        .WithMany("Positions")
                        .HasForeignKey("CompanyID");
                });
#pragma warning restore 612, 618
        }
    }
}
