﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CSETWebCore.DataLayer.Model2
{
    [Keyless]
    public partial class Answer_Components_Exploded
    {
        [StringLength(100)]
        public string UniqueKey { get; set; }
        public int Assessment_Id { get; set; }
        public int? Answer_Id { get; set; }
        public int Question_Id { get; set; }
        [StringLength(50)]
        public string Answer_Text { get; set; }
        [StringLength(1000)]
        public string Comment { get; set; }
        [StringLength(1000)]
        public string Alternate_Justification { get; set; }
        [StringLength(2048)]
        public string FeedBack { get; set; }
        public int? Question_Number { get; set; }
        [StringLength(7338)]
        public string QuestionText { get; set; }
        [StringLength(200)]
        public string ComponentName { get; set; }
        [Required]
        [StringLength(100)]
        public string Symbol_Name { get; set; }
        [StringLength(250)]
        public string Question_Group_Heading { get; set; }
        public int? GroupHeadingId { get; set; }
        [StringLength(100)]
        public string Universal_Sub_Category { get; set; }
        public int? SubCategoryId { get; set; }
        public bool Is_Component { get; set; }
        public Guid Component_Guid { get; set; }
        public int? Layer_Id { get; set; }
        [Required]
        [StringLength(250)]
        public string LayerName { get; set; }
        public int? Container_Id { get; set; }
        [StringLength(250)]
        public string ZoneName { get; set; }
        [StringLength(10)]
        public string SAL { get; set; }
        public bool? Mark_For_Review { get; set; }
        public bool? Is_Requirement { get; set; }
        public bool? Is_Framework { get; set; }
        public bool? Reviewed { get; set; }
        [StringLength(7338)]
        public string Simple_Question { get; set; }
        [StringLength(1000)]
        public string Sub_Heading_Question_Description { get; set; }
        public int? heading_pair_id { get; set; }
        [StringLength(200)]
        public string label { get; set; }
        public int Component_Symbol_Id { get; set; }
    }
}