﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectWorkshop.Models;

public partial class Hospital
{
    public int Id { get; set; }

    public string HospitalName { get; set; } = null!;

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Phone { get; set; }

    
    public virtual ICollection<HealthCareProvider> HealthCareProviders { get; set; } = new List<HealthCareProvider>();
    
    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
