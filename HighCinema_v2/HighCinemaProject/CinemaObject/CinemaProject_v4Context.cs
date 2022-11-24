﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CinemaObject
{
    public partial class CinemaProject_v4Context : DbContext
    {
        public CinemaProject_v4Context()
        {
        }

        public CinemaProject_v4Context(DbContextOptions<CinemaProject_v4Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<FastFood> FastFoods { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Revenue> Revenues { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<ShowTime> ShowTimes { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Use> Uses { get; set; }
        public virtual DbSet<ViewCau1> ViewCau1s { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=VINHHUNG;uid=sa;pwd=123456;database=CinemaProject_v4");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idpeople).HasColumnName("IDPeople");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("Bill");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BookingDate).HasColumnType("date");

                entity.Property(e => e.IdMovie).HasColumnName("ID_Movie");

                entity.Property(e => e.QuantityDrink).HasColumnName("Quantity_Drink");

                entity.Property(e => e.QuantityFastfood).HasColumnName("Quantity_Fastfood");

                entity.Property(e => e.SeatNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Seat_num");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.Property(e => e.TicketType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ticket_type");

                entity.HasOne(d => d.IdMovieNavigation)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.IdMovie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bill_Movie");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORY");

                entity.HasIndex(e => e.CategoryName, "UQ__CATEGORY__B35EB419872F48D9")
                    .IsUnique();

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("Category_ID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(20)
                    .HasColumnName("Category_Name");

                entity.Property(e => e.NumberOfSeat).HasColumnName("Number_Of_Seat");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("CUSTOMER");

                entity.Property(e => e.CustomerId)
                    .ValueGeneratedNever()
                    .HasColumnName("Customer_ID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(20)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.Phone).HasMaxLength(10);
            });

            modelBuilder.Entity<FastFood>(entity =>
            {
                entity.ToTable("FastFood");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("Movie");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.GenreId).HasColumnName("Genre_ID");

                entity.Property(e => e.Genres).IsRequired();

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MainCharacters)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("Main_Characters");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movie_Genres");
            });

            modelBuilder.Entity<Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Revenue");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("End_date");

                entity.Property(e => e.MovieId).HasColumnName("Movie_ID");

                entity.Property(e => e.MovieName)
                    .IsRequired()
                    .HasColumnName("Movie_name");

                entity.Property(e => e.NumOfTicketSold).HasColumnName("numOfTicketSold");

                entity.Property(e => e.PremiereDate)
                    .HasColumnType("date")
                    .HasColumnName("Premiere_date");

                entity.Property(e => e.Revenue1).HasColumnName("Revenue");

                entity.HasOne(d => d.Movie)
                    .WithMany()
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Revenue_Movie");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("ROOM");

                entity.Property(e => e.RoomId)
                    .ValueGeneratedNever()
                    .HasColumnName("Room_ID");

                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("QUANHE_11");
            });

            modelBuilder.Entity<ShowTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ShowTime");

                entity.Property(e => e.MovieId).HasColumnName("Movie_ID");

                entity.Property(e => e.NumOfTicketSold).HasColumnName("numOfTicketSold");

                entity.Property(e => e.RoomId).HasColumnName("Room_ID");

                entity.Property(e => e.ShowDate)
                    .HasColumnType("date")
                    .HasColumnName("Show_date");

                entity.Property(e => e.TicketPrice).HasColumnName("Ticket_price");

                entity.HasOne(d => d.Movie)
                    .WithMany()
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShowTime_Movie");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdMovie).HasColumnName("ID_Movie");

                entity.Property(e => e.TicketType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ticket_type");

                entity.HasOne(d => d.IdMovieNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.IdMovie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticket_Movie");
            });

            modelBuilder.Entity<Use>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Use");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(50);

                entity.Property(e => e.RoomId).HasColumnName("Room_ID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany()
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Use_Customer_ID");

                entity.HasOne(d => d.Room)
                    .WithMany()
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_Use_Room_ID");
            });

            modelBuilder.Entity<ViewCau1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_cau1");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(20)
                    .HasColumnName("Category_Name");

                entity.Property(e => e.NumberOfSeat).HasColumnName("Number_Of_Seat");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNum)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
