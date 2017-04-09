//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Contractors.cs" company="Anonymous">
//   Copyright ©. Anonymous. All rights reserved.
// </copyright>
// <summary>
//   Contract Module Contractors.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace Contracts_Module_Sample.Models
{
    public class Contractor
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public EStateContractor State { get; set; }
        public DateTime ExpiredDate { get; set; }
    }

    /// <summary>
    /// contractor state list
    /// </summary>
    public enum EStateContractor
    {
        Active,
        Expired
    }
}
