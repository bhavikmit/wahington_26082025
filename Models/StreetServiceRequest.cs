using System.ComponentModel.DataAnnotations.Schema;
using Enums;
using Models.Models.Shared;

namespace Models
{
    public class StreetServiceRequest : BaseDBModel
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string? Zip { get; set; }
        public string Email { get; set; }

        // Contact preferences
        public bool CallMe { get; set; }
        public bool EmailMe { get; set; }
        public bool NoNeedToContact { get; set; }

        // Problem types
        public bool SideWalk { get; set; }
        public bool Potholes { get; set; }
        public bool Drainage { get; set; }
        public bool StreetSweeping { get; set; }
        public bool ParkwayTree { get; set; }
        public bool Other { get; set; }
        public string? Description { get; set; }

        // Problem location
        public string? LocationOfProblem { get; set; }
        public string? DescriptionOfProblem { get; set; }

        // ✅ Safety / Regulatory
        public bool GasOdorDetected { get; set; }
        public bool EvacuationNeeded { get; set; }
        public string? RespondersNotified { get; set; }
        public string? RegulatoryStepCode { get; set; }

        // ✅ Dispatch / Assignment
        public string? AssignedTechnicians { get; set; }
        public string? AssignedCrew { get; set; }
        public string? SupervisorName { get; set; }
        public int? DispatchStatusId { get; set; }

        // ✅ Status
        public SSRStatus? Status { get; set; } = SSRStatus.Open;

        // Navigation
        public WorkOrder? WorkOrder { get; set; }
    }
}
