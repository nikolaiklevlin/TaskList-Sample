//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Task.cs" company="Anonymous">
//   Copyright ©. Anonymous. All rights reserved.
// </copyright>
// <summary>
//   Contract Module Task.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contracts_Module_Sample.Models
{
    /// <summary>
    /// "task" name is reserved - use CMSTask
    /// </summary>
    public class CMSTask
    {
        public int ID { get; set; }

        public Guid ContentTypeID { get; set; }

        public string Title { get; set; }

        public ECMSTaskStatus Status { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Complete to")]
        public DateTime Deadline { get; set; }

        [Display(Name ="Create")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Completed")]
        public DateTime EditDate { get; set; }

        /// <summary>
        /// link to contract
        /// </summary>
        public Contract Contract { get; set; }

        /// <summary>
        /// link to task attachments
        /// </summary>
        public List<Attachment> Attachments {get; set;}

        /// <summary>
        /// сompletion mark
        /// </summary>
        public bool IsComleted { get; set; }

        /// <summary>
        /// base initialize
        /// </summary>
        public void Initialize()
        {
            IsComleted = false;
            Status = ECMSTaskStatus.New;
            DateTime curentDate = DateTime.Now;
            CreateDate = curentDate;
        }

        /// <summary>
        /// completed task
        /// </summary>
        public void Completed()
        {
            IsComleted = true;
            Status = ECMSTaskStatus.Comleted;
            DateTime curentDate = DateTime.Now;
            EditDate = curentDate;
            CreateDate = this.CreateDate;
        }
    }

    public enum ECMSTaskStatus { New, Comleted, Expired}
}
