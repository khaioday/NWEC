﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HealthcareAppointment.Models.Models;

public partial class Appointment
{
    public string Id { get; set; }

    public string PatientId { get; set; }

    public string DoctorId { get; set; }

    public DateTime? Date { get; set; }

    public int? Status { get; set; }
}