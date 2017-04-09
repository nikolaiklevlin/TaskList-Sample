//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Attachment.cs" company="Anonymous">
//   Copyright ©. Anonymous. All rights reserved.
// </copyright>
// <summary>
//   Contract Module Attachment.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace Contracts_Module_Sample.Models
{
    public class Attachment
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public byte[] File { get; set; }

        /// <summary>
        /// link to contract
        /// </summary>
        public Contract Contract { get; set; }

        /// <summary>
        /// link to task
        /// </summary>
        public CMSTask Task { get; set; }
    }
}
