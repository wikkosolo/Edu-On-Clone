﻿namespace EduOnClone.Domain.Entities;

public class Test : BaseEntity
{
    public string Question { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
