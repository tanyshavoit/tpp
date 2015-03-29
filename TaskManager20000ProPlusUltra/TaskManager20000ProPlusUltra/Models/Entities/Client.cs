//-----------------------------------------------------------------------
// <copyright file="Client.cs" company="Primat NaUKMA">
//     Primat NaUKMA Inc.
// </copyright>
//-----------------------------------------------------------------------

namespace MathProCorporation.TaskManagerDatabase
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using MathProCorporation.Models;

    /// <summary>
    /// Represents user of the service
    /// </summary>
    public class Client
    {
        [Key]
        public string ClientId { get; set; }

        [ForeignKey("ClientId")]
        public ApplicationUser User { get; set; }

        /// <summary>
        /// Gets or sets the list of client's contracts
        /// </summary>
        public List<Project> Projects { get; set; }
    }
}