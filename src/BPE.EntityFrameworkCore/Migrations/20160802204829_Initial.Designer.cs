using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BPE.EntityFrameworkCore;

namespace BPE.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(BPEDbContext))]
    [Migration("20160802204829_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BPE.Players.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("FirstName");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<string>("LastName");

                    b.Property<int>("LoginCount");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });
        }
    }
}
