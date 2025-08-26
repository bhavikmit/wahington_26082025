using Enums;
using Helpers.Datetime;
using Helpers.Extensions;
using System.ComponentModel.DataAnnotations;
using ViewModels.Shared;

namespace ViewModels
{
    public class StreetServiceRequestDetailViewModel : BaseCrudViewModel
    {
        public long Id { get; set; }
        public string? Subject { get; set; }
        public string Name { get; set; }

        public bool HasNotes { get; set; }

        public string HasNotesClass => HasNotes ? "has-note" : "";

        public DateTime CreatedOn { get; set; }

        public string FormattedCreatedOn => CreatedOn.FormatDate();

        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string? Zip { get; set; }
        public string Email { get; set; }

        [Display(Name = "Please call me")]
        public bool CallMe { get; set; }

        [Display(Name = "Please e-mail me")]
        public bool EmailMe { get; set; }

        [Display(Name = "Please handle, no need to contact me")]
        public bool NoNeedToContact { get; set; }

        // ✅ Type of problem
        [Display(Name = "Sidewalk")]
        public bool SideWalk { get; set; }

        [Display(Name = "Potholes/Pavement")]
        public bool Potholes { get; set; }

        [Display(Name = "Drainage")]
        public bool Drainage { get; set; }

        [Display(Name = "Street Sweeping")]
        public bool StreetSweeping { get; set; }

        [Display(Name = "Parkway Tree")]
        public bool ParkwayTree { get; set; }

        [Display(Name = "Other")]
        public bool Other { get; set; }

        public string? Description { get; set; }

        [Display(Name = "Location of problem (closest street address)")]
        public string? LocationOfProblem { get; set; }

        [Display(Name = "Please use the box below to describe the problem")]
        public string? DescriptionOfProblem { get; set; }

        // ✅ Safety / Regulatory
        [Display(Name = "Gas Odor Detected?")]
        public bool GasOdorDetected { get; set; }

        [Display(Name = "Evacuation Needed?")]
        public bool EvacuationNeeded { get; set; }

        [Display(Name = "Responders Notified?")]
        public string? RespondersNotified { get; set; }

        [Display(Name = "Regulatory Step/Policy Code")]
        public string? RegulatoryStepCode { get; set; }

        // ✅ Dispatch / Assignment
        [Display(Name = "Assigned Technician")]
        public string? AssignedTechnicians { get; set; }

        [Display(Name = "Assigned Crew / Department")]
        public string? AssignedCrew { get; set; }

        [Display(Name = "Supervisor / Approver Name")]
        public string? SupervisorName { get; set; }

        // ✅ Dispatch Status (integer)
        [Display(Name = "Dispatch Status")]
        public int? DispatchStatusId { get; set; }

        // ✅ Status (enum for admin view)
        public SSRStatus? Status { get; set; }
    }
}
