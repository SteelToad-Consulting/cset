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
    /// A collection of REFERENCE_DOCS records
    /// </summary>
    public partial class REFERENCE_DOCS
    {
        public REFERENCE_DOCS()
        {
            REFERENCES_DATA = new HashSet<REFERENCES_DATA>();
        }

        /// <summary>
        /// The Reference Doc Id is used to
        /// </summary>
        [Key]
        public int Reference_Doc_Id { get; set; }
        /// <summary>
        /// The Doc Name is used to
        /// </summary>
        public string Doc_Name { get; set; }
        /// <summary>
        /// The Doc Link is used to
        /// </summary>
        public string Doc_Link { get; set; }
        /// <summary>
        /// The Doc Short is used to
        /// </summary>
        [StringLength(50)]
        public string Doc_Short { get; set; }
        /// <summary>
        /// The Date Updated is used to
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Date_Updated { get; set; }
        /// <summary>
        /// The Date Last Checked is used to
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Date_Last_Checked { get; set; }
        /// <summary>
        /// The Doc Url is used to
        /// </summary>
        public string Doc_Url { get; set; }
        /// <summary>
        /// The Doc Notes is used to
        /// </summary>
        public string Doc_Notes { get; set; }

        [InverseProperty("Reference_Doc")]
        public virtual ICollection<REFERENCES_DATA> REFERENCES_DATA { get; set; }
    }
}