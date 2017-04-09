//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Contract.cs" company="Anonymous">
//   Copyright ©. Anonymous. All rights reserved.
// </copyright>
// <summary>
//   Contract Module Contract.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Contracts_Module_Sample.Models
{
    public class Contract
    {   
        public int ID { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }

        /// <summary>
        /// link to contractor
        /// </summary>
        public Contractor Contractor { get; set; }

        /// <summary>
        /// links to tasks under the contract
        /// </summary>
        public virtual List<CMSTask> Tasks { get; set; }

        /// <summary>
        /// link to contract attachments
        /// </summary>
        public List<Attachment> Attachments { get; set; }
    }
}
