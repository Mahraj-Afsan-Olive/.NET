using System;
using System.ComponentModel.DataAnnotations;

public class IdMatchesEmailAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        // Get the Email and Id properties
        var email = value as string;
        var idProperty = validationContext.ObjectType.GetProperty("Id");
        var id = idProperty.GetValue(validationContext.ObjectInstance, null) as string;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(id))
        {
            return ValidationResult.Success; // Proceed with other validation if Id or Email is not provided
        }

        // Check if email starts with the Id
        if (email.StartsWith(id) && email.EndsWith("@student.aiub.edu"))
        {
            return ValidationResult.Success; // Valid email format
        }

        // Custom error message
        return new ValidationResult("Email must match the Id format (e.g., Id@student.aiub.edu).");
    }
}
