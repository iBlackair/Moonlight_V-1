﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moonlight.App.Database;

#nullable disable

namespace Moonlight.App.Database.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230215200722_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Moonlight.App.Database.Entities.DockerImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Default")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("DockerImages");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConfigFiles")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InstallDockerImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InstallEntrypoint")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InstallScript")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Startup")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StartupDetection")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StopCommand")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.ImageTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("ImageTags");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.ImageVariable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DefaultValue")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("ImageVariables");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.LoadingMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("LoadingMessages");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.Node", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Fqdn")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("HttpPort")
                        .HasColumnType("int");

                    b.Property<int>("MoonlightDaemonPort")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SftpPort")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TokenId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Nodes");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.NodeAllocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("NodeId")
                        .HasColumnType("int");

                    b.Property<int>("Port")
                        .HasColumnType("int");

                    b.Property<int?>("ServerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NodeId");

                    b.HasIndex("ServerId");

                    b.ToTable("NodeAllocations");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cpu")
                        .HasColumnType("int");

                    b.Property<long>("Disk")
                        .HasColumnType("bigint");

                    b.Property<int>("DockerImageIndex")
                        .HasColumnType("int");

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<bool>("Installing")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("MainAllocationId")
                        .HasColumnType("int");

                    b.Property<long>("Memory")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NodeId")
                        .HasColumnType("int");

                    b.Property<string>("OverrideStartup")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<bool>("Suspended")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("MainAllocationId");

                    b.HasIndex("NodeId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Servers");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.ServerBackup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("Bytes")
                        .HasColumnType("bigint");

                    b.Property<bool>("Created")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("ServerId")
                        .HasColumnType("int");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.ToTable("ServerBackups");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.ServerVariable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("ServerId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.ToTable("ServerVariables");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Admin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DiscordDiscriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("DiscordId")
                        .HasColumnType("bigint");

                    b.Property<string>("DiscordUsername")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("TokenValidTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("TotpEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("TotpSecret")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.DockerImage", b =>
                {
                    b.HasOne("Moonlight.App.Database.Entities.Image", null)
                        .WithMany("DockerImages")
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.ImageTag", b =>
                {
                    b.HasOne("Moonlight.App.Database.Entities.Image", null)
                        .WithMany("Tags")
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.ImageVariable", b =>
                {
                    b.HasOne("Moonlight.App.Database.Entities.Image", null)
                        .WithMany("Variables")
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.NodeAllocation", b =>
                {
                    b.HasOne("Moonlight.App.Database.Entities.Node", null)
                        .WithMany("Allocations")
                        .HasForeignKey("NodeId");

                    b.HasOne("Moonlight.App.Database.Entities.Server", null)
                        .WithMany("Allocations")
                        .HasForeignKey("ServerId");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.Server", b =>
                {
                    b.HasOne("Moonlight.App.Database.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moonlight.App.Database.Entities.NodeAllocation", "MainAllocation")
                        .WithMany()
                        .HasForeignKey("MainAllocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moonlight.App.Database.Entities.Node", "Node")
                        .WithMany()
                        .HasForeignKey("NodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moonlight.App.Database.Entities.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("MainAllocation");

                    b.Navigation("Node");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.ServerBackup", b =>
                {
                    b.HasOne("Moonlight.App.Database.Entities.Server", null)
                        .WithMany("Backups")
                        .HasForeignKey("ServerId");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.ServerVariable", b =>
                {
                    b.HasOne("Moonlight.App.Database.Entities.Server", null)
                        .WithMany("Variables")
                        .HasForeignKey("ServerId");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.Image", b =>
                {
                    b.Navigation("DockerImages");

                    b.Navigation("Tags");

                    b.Navigation("Variables");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.Node", b =>
                {
                    b.Navigation("Allocations");
                });

            modelBuilder.Entity("Moonlight.App.Database.Entities.Server", b =>
                {
                    b.Navigation("Allocations");

                    b.Navigation("Backups");

                    b.Navigation("Variables");
                });
#pragma warning restore 612, 618
        }
    }
}
