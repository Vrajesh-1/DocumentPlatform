﻿using System.ComponentModel.DataAnnotations;

public class RegisterViewModel
{
    [Required]
    public string UserName { get; set; } = string.Empty; 

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty; 

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;

    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; } = string.Empty; 
}
