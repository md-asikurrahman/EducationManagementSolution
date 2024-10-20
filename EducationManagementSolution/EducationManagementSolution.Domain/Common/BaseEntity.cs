﻿namespace EducationManagementSolution.Domain.Common;

public class BaseEntity
{
    public int Id { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public string CreatedById { get; set; }
    public string? UpdatedById { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? Remarks { get; set; }
}
