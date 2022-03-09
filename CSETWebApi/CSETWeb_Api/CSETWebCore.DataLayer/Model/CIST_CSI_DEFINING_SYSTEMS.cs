﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CSETWebCore.DataLayer.Model
{
    public partial class CIST_CSI_DEFINING_SYSTEMS
    {
        public CIST_CSI_DEFINING_SYSTEMS()
        {
            CIST_CSI_SERVICE_COMPOSITION = new HashSet<CIST_CSI_SERVICE_COMPOSITION>();
        }

        [Key]
        public int Value_Id { get; set; }
        [StringLength(400)]
        public string Defining_System { get; set; }

        [InverseProperty("Primary_Defining_SystemNavigation")]
        public virtual ICollection<CIST_CSI_SERVICE_COMPOSITION> CIST_CSI_SERVICE_COMPOSITION { get; set; }
    }
}