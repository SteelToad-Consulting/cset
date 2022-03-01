﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CSETWebCore.DataLayer.Model2
{
    /// <summary>
    /// A collection of LEVEL_NAMES records
    /// </summary>
    public partial class LEVEL_NAMES
    {
        public LEVEL_NAMES()
        {
            ASSESSMENT_SELECTED_LEVELS = new HashSet<ASSESSMENT_SELECTED_LEVELS>();
        }

        /// <summary>
        /// The Level Name is used to
        /// </summary>
        [Key]
        [StringLength(50)]
        public string Level_Name { get; set; }

        [InverseProperty("Level_NameNavigation")]
        public virtual ICollection<ASSESSMENT_SELECTED_LEVELS> ASSESSMENT_SELECTED_LEVELS { get; set; }
    }
}