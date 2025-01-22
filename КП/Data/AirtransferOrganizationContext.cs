using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using КП.Core.Entities;

namespace КП.Data;

public partial class AirtransferOrganizationContext : DbContext
{
    public AirtransferOrganizationContext()
    {
    }

    public AirtransferOrganizationContext(DbContextOptions<AirtransferOrganizationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aircraft> Aircraft { get; set; }

    public virtual DbSet<AircraftModel> AircraftModels { get; set; }

    public virtual DbSet<Airline> Airlines { get; set; }

    public virtual DbSet<AirlineAccount> AirlineAccounts { get; set; }

    public virtual DbSet<AirlineOwnsAircraft> AirlineOwnsAircrafts { get; set; }

    public virtual DbSet<Airport> Airports { get; set; }

    public virtual DbSet<Baggage> Baggages { get; set; }

    public virtual DbSet<BaggageType> BaggageTypes { get; set; }

    public virtual DbSet<BookingStatus> BookingStatuses { get; set; }

    public virtual DbSet<Crew> Crews { get; set; }

    public virtual DbSet<CrewAssigment> CrewAssigments { get; set; }

    public virtual DbSet<CrewMember> CrewMembers { get; set; }

    public virtual DbSet<CrewMemberPosition> CrewMemberPositions { get; set; }

    public virtual DbSet<DocumentType> DocumentTypes { get; set; }

    public virtual DbSet<Flight> Flights { get; set; }

    public virtual DbSet<FlightStatus> FlightStatuses { get; set; }

    public virtual DbSet<Passenger> Passengers { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentMehod> PaymentMehods { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<StaffPosition> StaffPositions { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<TicketBooking> TicketBookings { get; set; }

    public virtual DbSet<TicketStatus> TicketStatuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=airtransfer_organization;Username=postgres;Password=BaBaaH228!!!", x => x.UseNodaTime());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aircraft>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("aircraft_pkey");

            entity.ToTable("aircraft");

            entity.HasIndex(e => e.RegistationNumber, "aircraft_registation_number_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ModelId).HasColumnName("model_id");
            entity.Property(e => e.RegistationNumber).HasColumnName("registation_number");

            entity.HasOne(d => d.Model).WithMany(p => p.Aircraft)
                .HasForeignKey(d => d.ModelId)
                .HasConstraintName("aircraft_model_id_fkey");
        });

        modelBuilder.Entity<AircraftModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("aircraft_model_pkey");

            entity.ToTable("aircraft_model");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capacity).HasColumnName("capacity");
            entity.Property(e => e.ModelName)
                .HasColumnType("character varying")
                .HasColumnName("model_name");
        });

        modelBuilder.Entity<Airline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("airline_pkey");

            entity.ToTable("airline");

            entity.HasIndex(e => e.Ogrn, "airline_ogrn_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BuildingNumb).HasColumnName("building_numb");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Ogrn)
                .HasColumnType("character varying")
                .HasColumnName("ogrn");
            entity.Property(e => e.Street)
                .HasColumnType("character varying")
                .HasColumnName("street");
        });

        modelBuilder.Entity<AirlineAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("airline_account");

            entity.Property(e => e.AirlineId).HasColumnName("airline_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Airline).WithMany()
                .HasForeignKey(d => d.AirlineId)
                .HasConstraintName("airline_account_airline_id_fkey");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("airline_account_user_id_fkey");
        });

        modelBuilder.Entity<AirlineOwnsAircraft>(entity =>
        {
            entity.HasKey(e => new { e.AirlineId, e.AircraftId, e.StartDate }).HasName("airline_owns_aircraft_pkey");

            entity.ToTable("airline_owns_aircraft");

            entity.HasIndex(e => e.AircraftId, "airline_owns_aircraft_aircraft_id_key").IsUnique();

            entity.Property(e => e.AirlineId)
                .ValueGeneratedOnAdd()
                .HasColumnName("airline_id");
            entity.Property(e => e.AircraftId).HasColumnName("aircraft_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");

            entity.HasOne(d => d.Aircraft).WithOne(p => p.AirlineOwnsAircraft)
                .HasForeignKey<AirlineOwnsAircraft>(d => d.AircraftId)
                .HasConstraintName("airline_owns_aircraft_aircraft_id_fkey");

            entity.HasOne(d => d.Airline).WithMany(p => p.AirlineOwnsAircrafts)
                .HasForeignKey(d => d.AirlineId)
                .HasConstraintName("airline_owns_aircraft_airline_id_fkey");
        });

        modelBuilder.Entity<Airport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("airport_pkey");

            entity.ToTable("airport");

            entity.HasIndex(e => e.IcaoCode, "airport_icao_code_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BuildingNumb).HasColumnName("building_numb");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.IataCode)
                .HasMaxLength(3)
                .HasColumnName("iata_code");
            entity.Property(e => e.IcaoCode)
                .HasMaxLength(4)
                .HasColumnName("icao_code");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Street)
                .HasColumnType("character varying")
                .HasColumnName("street");
        });

        modelBuilder.Entity<Baggage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("baggage_pkey");

            entity.ToTable("baggage");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BookingId).HasColumnName("booking_id");
            entity.Property(e => e.Dimensions)
                .HasColumnType("character varying")
                .HasColumnName("dimensions");
            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.Booking).WithMany(p => p.Baggages)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("baggage_booking_id_fkey");

            entity.HasOne(d => d.Type).WithMany(p => p.Baggages)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("baggage_type_id_fkey");
        });

        modelBuilder.Entity<BaggageType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("baggage_type_pkey");

            entity.ToTable("baggage_type");

            entity.HasIndex(e => e.Name, "baggage_type_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        modelBuilder.Entity<BookingStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("booking_status_pkey");

            entity.ToTable("booking_status");

            entity.HasIndex(e => e.Name, "booking_status_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Crew>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crew_pkey");

            entity.ToTable("crew");

            entity.HasIndex(e => e.Name, "crew_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        modelBuilder.Entity<CrewAssigment>(entity =>
        {
            entity.HasKey(e => new { e.CrewId, e.CrewMemberId }).HasName("crew_assigments_pkey");

            entity.ToTable("crew_assigments");

            entity.Property(e => e.CrewId).HasColumnName("crew_id");
            entity.Property(e => e.CrewMemberId).HasColumnName("crew_member_id");
            entity.Property(e => e.MemberPositionId).HasColumnName("member_position_id");

            entity.HasOne(d => d.Crew).WithMany(p => p.CrewAssigments)
                .HasForeignKey(d => d.CrewId)
                .HasConstraintName("crew_assigments_crew_id_fkey");

            entity.HasOne(d => d.CrewMember).WithMany(p => p.CrewAssigments)
                .HasForeignKey(d => d.CrewMemberId)
                .HasConstraintName("crew_assigments_crew_member_id_fkey");

            entity.HasOne(d => d.MemberPosition).WithMany(p => p.CrewAssigments)
                .HasForeignKey(d => d.MemberPositionId)
                .HasConstraintName("crew_assigments_member_position_id_fkey");
        });

        modelBuilder.Entity<CrewMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crew_members_pkey");

            entity.ToTable("crew_members");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Qualification)
                .HasColumnType("character varying")
                .HasColumnName("qualification");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.CrewMember)
                .HasForeignKey<CrewMember>(d => d.Id)
                .HasConstraintName("crew_members_id_fkey");
        });

        modelBuilder.Entity<CrewMemberPosition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crew_member_positions_pkey");

            entity.ToTable("crew_member_positions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        modelBuilder.Entity<DocumentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("document_type_pkey");

            entity.ToTable("document_type");

            entity.HasIndex(e => e.Name, "document_type_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Flight>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("flight_pkey");

            entity.ToTable("flight");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AircraftId).HasColumnName("aircraft_id");
            entity.Property(e => e.AirlineId)
                .ValueGeneratedOnAdd()
                .HasColumnName("airline_id");
            entity.Property(e => e.ArrivalAirportId).HasColumnName("arrival_airport_id");
            entity.Property(e => e.ArrivalTime).HasColumnName("arrival_time");
            entity.Property(e => e.CrewId).HasColumnName("crew_id");
            entity.Property(e => e.DepartureAirportId).HasColumnName("departure_airport_id");
            entity.Property(e => e.DepartureTime)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("departure_time");
            entity.Property(e => e.StatusId).HasColumnName("status_id");

            entity.HasOne(d => d.Aircraft).WithMany(p => p.Flights)
                .HasForeignKey(d => d.AircraftId)
                .HasConstraintName("flight_aircraft_id_fkey");

            entity.HasOne(d => d.Airline).WithMany(p => p.Flights)
                .HasForeignKey(d => d.AirlineId)
                .HasConstraintName("flight_airline_id_fkey");

            entity.HasOne(d => d.ArrivalAirport).WithMany(p => p.FlightArrivalAirports)
                .HasForeignKey(d => d.ArrivalAirportId)
                .HasConstraintName("flight_arrival_airport_id_fkey");

            entity.HasOne(d => d.Crew).WithMany(p => p.Flights)
                .HasForeignKey(d => d.CrewId)
                .HasConstraintName("flight_crew_id_fkey");

            entity.HasOne(d => d.DepartureAirport).WithMany(p => p.FlightDepartureAirports)
                .HasForeignKey(d => d.DepartureAirportId)
                .HasConstraintName("flight_departure_airport_id_fkey");

            entity.HasOne(d => d.Status).WithMany(p => p.Flights)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("flight_status_id_fkey");
        });

        modelBuilder.Entity<FlightStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("flight_status_pkey");

            entity.ToTable("flight_status");

            entity.HasIndex(e => e.Name, "flight_status_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Passenger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("passenger_pkey");

            entity.ToTable("passenger");

            entity.HasIndex(e => e.PhoneNumber, "passenger_phone_number_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Birthdate).HasColumnName("birthdate");
            entity.Property(e => e.DocumentNumber)
                .HasColumnType("character varying")
                .HasColumnName("document_number");
            entity.Property(e => e.DocumentTypeId).HasColumnName("document_type_id");
            entity.Property(e => e.FirstName)
                .HasColumnType("character varying")
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasColumnType("character varying")
                .HasColumnName("last_name");
            entity.Property(e => e.PhoneNumber)
                .HasColumnType("character varying")
                .HasColumnName("phone_number");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.Passengers)
                .HasForeignKey(d => d.DocumentTypeId)
                .HasConstraintName("passenger_document_type_id_fkey");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payment_pkey");

            entity.ToTable("payment");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.BookingId).HasColumnName("booking_id");
            entity.Property(e => e.PaymentMethodId).HasColumnName("payment_method_id");

            entity.HasOne(d => d.Booking).WithMany(p => p.Payments)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("payment_booking_id_fkey");

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.Payments)
                .HasForeignKey(d => d.PaymentMethodId)
                .HasConstraintName("payment_payment_method_id_fkey");
        });

        modelBuilder.Entity<PaymentMehod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payment_mehod_pkey");

            entity.ToTable("payment_mehod");

            entity.HasIndex(e => e.Name, "payment_mehod_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payment_method_pkey");

            entity.ToTable("payment_method");

            entity.HasIndex(e => e.Name, "payment_method_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("staff_pkey");

            entity.ToTable("staff");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.PositionId).HasColumnName("position_id");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Staff)
                .HasForeignKey<Staff>(d => d.Id)
                .HasConstraintName("staff_id_fkey");

            entity.HasOne(d => d.Position).WithMany(p => p.Staff)
                .HasForeignKey(d => d.PositionId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("staff_position_id_fkey");
        });

        modelBuilder.Entity<StaffPosition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("staff_positions_pkey");

            entity.ToTable("staff_positions");

            entity.HasIndex(e => e.Name, "staff_positions_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ticket_pkey");

            entity.ToTable("ticket");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BookingId).HasColumnName("booking_id");
            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.SeatNumber).HasColumnName("seat_number");
            entity.Property(e => e.StatusId).HasColumnName("status_id");

            entity.HasOne(d => d.Booking).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.BookingId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ticket_booking_id_fkey");

            entity.HasOne(d => d.Flight).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.FlightId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ticket_flight_id_fkey");

            entity.HasOne(d => d.Status).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("ticket_status_id_fkey");
        });

        modelBuilder.Entity<TicketBooking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ticket_booking_pkey");

            entity.ToTable("ticket_booking");

            entity.HasIndex(e => new { e.Id, e.PassengerId }, "ticket_booking_id_passenger_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BookingDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("booking_date");
            entity.Property(e => e.BookingId).HasColumnName("booking_id");
            entity.Property(e => e.PassengerId).HasColumnName("passenger_id");
            entity.Property(e => e.StatusId)
                .HasDefaultValue((short)1)
                .HasColumnName("status_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Passenger).WithMany(p => p.TicketBookings)
                .HasForeignKey(d => d.PassengerId)
                .HasConstraintName("ticket_booking_passenger_id_fkey");

            entity.HasOne(d => d.Status).WithMany(p => p.TicketBookings)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("ticket_booking_status_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.TicketBookings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("ticket_booking_user_id_fkey");
        });

        modelBuilder.Entity<TicketStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ticket_status_pkey");

            entity.ToTable("ticket_status");

            entity.HasIndex(e => e.Name, "ticket_status_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.HasIndex(e => e.Email, "users_email_key").IsUnique();

            entity.HasIndex(e => e.PhoneNumber, "users_phone_number_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasColumnType("character varying")
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasColumnType("character varying")
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasColumnType("character varying")
                .HasColumnName("password");
            entity.Property(e => e.PhoneNumber)
                .HasColumnType("character varying")
                .HasColumnName("phone_number");
            entity.Property(e => e.RoleId).HasColumnName("role_id");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("users_role_id_fkey");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_roles_pkey");

            entity.ToTable("user_roles");

            entity.HasIndex(e => e.Name, "user_roles_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
