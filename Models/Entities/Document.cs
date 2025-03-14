﻿using Edutopia.Models.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Document
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public Guid UserId { get; set; }

    [ForeignKey(nameof(UserId))] // Move the attribute to the navigation property
    public virtual User User { get; set; }

    [Required]
    [MaxLength(255)]
    public string Title { get; set; }

    [Required]
    [MaxLength(500)]
    public string FilePath { get; set; }

    [Required]
    [MaxLength(100)]
    public string FileType { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Required]
    [MaxLength(50)]
    public string Status { get; set; } = "Processing";
}
