﻿namespace ProjectWorkshop.Models.PageModels
{
    public class HealthCareProviderModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? Gender { get; set; }

        public DateOnly? Dob { get; set; }

        public string? Adress { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? Zip { get; set; }

        public string? Phone { get; set; }

        public string? Npi { get; set; }

        public int HospitalId { get; set; }

        public int RoleId { get; set; }

    }
}