﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HillarysHairCare.Migrations
{
    [DbContext(typeof(HillarysHairCareDbContext))]
    partial class HillarysHairCareDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HillarysHairCare.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("StylistId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StylistId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Date = new DateTime(2024, 1, 4, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            StylistId = 2
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 3,
                            Date = new DateTime(2024, 1, 15, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            StylistId = 1
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 5,
                            Date = new DateTime(2024, 2, 22, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            StylistId = 3
                        },
                        new
                        {
                            Id = 4,
                            CustomerId = 2,
                            Date = new DateTime(2024, 1, 16, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StylistId = 4
                        },
                        new
                        {
                            Id = 5,
                            CustomerId = 8,
                            Date = new DateTime(2024, 2, 5, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            StylistId = 1
                        },
                        new
                        {
                            Id = 6,
                            CustomerId = 10,
                            Date = new DateTime(2024, 2, 18, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            StylistId = 1
                        },
                        new
                        {
                            Id = 7,
                            CustomerId = 6,
                            Date = new DateTime(2024, 1, 3, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            StylistId = 3
                        },
                        new
                        {
                            Id = 8,
                            CustomerId = 4,
                            Date = new DateTime(2024, 2, 19, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            StylistId = 2
                        },
                        new
                        {
                            Id = 9,
                            CustomerId = 7,
                            Date = new DateTime(2024, 2, 27, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            StylistId = 4
                        },
                        new
                        {
                            Id = 10,
                            CustomerId = 10,
                            Date = new DateTime(2024, 1, 20, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            StylistId = 1
                        });
                });

            modelBuilder.Entity("HillarysHairCare.Models.AppointmentService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AppointmentId")
                        .HasColumnType("integer");

                    b.Property<int>("ServiceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("ServiceId");

                    b.ToTable("AppointmentServices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppointmentId = 1,
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 2,
                            AppointmentId = 1,
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 3,
                            AppointmentId = 2,
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 4,
                            AppointmentId = 2,
                            ServiceId = 4
                        },
                        new
                        {
                            Id = 5,
                            AppointmentId = 3,
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 6,
                            AppointmentId = 3,
                            ServiceId = 5
                        },
                        new
                        {
                            Id = 7,
                            AppointmentId = 4,
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 8,
                            AppointmentId = 4,
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 9,
                            AppointmentId = 5,
                            ServiceId = 4
                        },
                        new
                        {
                            Id = 10,
                            AppointmentId = 5,
                            ServiceId = 5
                        },
                        new
                        {
                            Id = 11,
                            AppointmentId = 6,
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 12,
                            AppointmentId = 7,
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 13,
                            AppointmentId = 8,
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 14,
                            AppointmentId = 9,
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 15,
                            AppointmentId = 9,
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 16,
                            AppointmentId = 10,
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 17,
                            AppointmentId = 10,
                            ServiceId = 4
                        });
                });

            modelBuilder.Entity("HillarysHairCare.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "angeliglegias@gmail.com",
                            Name = "Angel Iglesias"
                        },
                        new
                        {
                            Id = 2,
                            Email = "blestrange@gmail.com",
                            Name = "Beatrice LeStrange"
                        },
                        new
                        {
                            Id = 3,
                            Email = "rtyler@gmail.com",
                            Name = "Reed Tyler"
                        },
                        new
                        {
                            Id = 4,
                            Email = "gholland@gmail.com",
                            Name = "Grant Holland"
                        },
                        new
                        {
                            Id = 5,
                            Email = "bweller@gmail.com",
                            Name = "Bruce Weller"
                        },
                        new
                        {
                            Id = 6,
                            Email = "mvereen@gmail.com",
                            Name = "Margot Vereen"
                        },
                        new
                        {
                            Id = 7,
                            Email = "pquantz@gmail.com",
                            Name = "Petunia Quantz"
                        },
                        new
                        {
                            Id = 8,
                            Email = "snguyen@gmail.com",
                            Name = "Sammy Nguyen"
                        },
                        new
                        {
                            Id = 9,
                            Email = "bhezberdeen@gmail.com",
                            Name = "Bianca Hezberdeen"
                        },
                        new
                        {
                            Id = 10,
                            Email = "cmichaels@gmail.com",
                            Name = "Clint Michaels"
                        });
                });

            modelBuilder.Entity("HillarysHairCare.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Haircut",
                            Price = 20m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Keratin Treatment",
                            Price = 40m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Beard/Eyebrow Shaping",
                            Price = 10m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hair Coloring",
                            Price = 60m
                        },
                        new
                        {
                            Id = 5,
                            Name = "Formal Styling",
                            Price = 50m
                        });
                });

            modelBuilder.Entity("HillarysHairCare.Models.Stylist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Stylists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Violet has been a hair stylist for 5 years, 2 of them here at Hillary's. Violet loves to build strong connections and trust with her clients.",
                            Email = "violetb@gmail.com",
                            ImgUrl = "https://images.pexels.com/photos/2805050/pexels-photo-2805050.jpeg?auto=compress&cs=tinysrgb&w=800",
                            IsActive = true,
                            Name = "Violet Blankenship"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "Hillary is not only a stylist but has been owner-operate of Hillary's Hair Care for 6 years. Her business is thriving and all of her customers don't mind waiting to get in with her! Make your appointment soon!",
                            Email = "hillaryr@gmail.com",
                            ImgUrl = "https://images.pexels.com/photos/3021554/pexels-photo-3021554.jpeg?auto=compress&cs=tinysrgb&w=800",
                            IsActive = true,
                            Name = "Hillary Reed"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "Lisa is a long time stylist, with experience in many services and styling practices. Although she is our newest stylist, she is already building a strong network of clients!",
                            Email = "lisat@gmail.com",
                            ImgUrl = "https://images.pexels.com/photos/654696/pexels-photo-654696.jpeg?auto=compress&cs=tinysrgb&w=800",
                            IsActive = true,
                            Name = "Lisa Tomas"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "Nate was the first stylist hired on my Hillary when she decided to open her own salon. They have been best friends since high school, and fell in love with styling together. Nate loves staying on top of the hottest new trends, and would love to add you to his long list of regulars. ",
                            Email = "natev@gmail.com",
                            ImgUrl = "https://images.pexels.com/photos/2531553/pexels-photo-2531553.jpeg?auto=compress&cs=tinysrgb&w=800",
                            IsActive = true,
                            Name = "Nate Vissel"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "Victoria is a personable and high energy stylist who loves treating her clients like royalty. With several years of experience working with many hair types and styles, if in doubt, she's the stylist for you!",
                            Email = "victorad@gmail.com",
                            ImgUrl = "https://images.pexels.com/photos/3108924/pexels-photo-3108924.jpeg?auto=compress&cs=tinysrgb&w=800",
                            IsActive = false,
                            Name = "Victoria Byron"
                        });
                });

            modelBuilder.Entity("HillarysHairCare.Models.Appointment", b =>
                {
                    b.HasOne("HillarysHairCare.Models.Customer", "Customer")
                        .WithMany("Appointments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HillarysHairCare.Models.Stylist", "Stylist")
                        .WithMany("Appointments")
                        .HasForeignKey("StylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Stylist");
                });

            modelBuilder.Entity("HillarysHairCare.Models.AppointmentService", b =>
                {
                    b.HasOne("HillarysHairCare.Models.Appointment", null)
                        .WithMany("AppointmentServices")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HillarysHairCare.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");
                });

            modelBuilder.Entity("HillarysHairCare.Models.Appointment", b =>
                {
                    b.Navigation("AppointmentServices");
                });

            modelBuilder.Entity("HillarysHairCare.Models.Customer", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("HillarysHairCare.Models.Stylist", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
