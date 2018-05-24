﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Dtos;

namespace Vidly.Models
{
    public class Min18YearsIfMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
            if (customer.Bitrhdate == null)
            {
                return new ValidationResult("Birthdate is required");
            }

            var age = DateTime.Today.Year - customer.Bitrhdate.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be at least 18 years old to go on a membership");

        }

        public class Min18YearsIfMemberDto : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                var customer = (CustomerDto)validationContext.ObjectInstance;

                if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                {
                    return ValidationResult.Success;
                }
                if (customer.Bitrhdate == null)
                {
                    return new ValidationResult("Birthdate is required");
                }

                var age = DateTime.Today.Year - customer.Bitrhdate.Value.Year;

                return (age >= 18)
                    ? ValidationResult.Success
                    : new ValidationResult("Customer should be at least 18 years old to go on a membership");

            }
        }
    }
}

