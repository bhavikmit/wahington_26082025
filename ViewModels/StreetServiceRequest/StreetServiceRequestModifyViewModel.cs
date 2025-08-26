using Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Common.Interfaces;
using System.ComponentModel.DataAnnotations;
using ViewModels;
using ViewModels.Shared;

namespace ViewModels
{
    public class StreetServiceRequestModifyViewModel : BaseUpdateVM, IBaseCrudViewModel, IIdentitifier
    {
        [Display(Name = "Subject", Prompt = "Subject")]
        public string Subject { get; set; }

        [Display(Name = "Name", Prompt = "Name")]
        public string Name { get; set; }

        [Phone]
        [Display(Name = "Phone", Prompt = "Phone")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Street Address", Prompt = "Street Address")]
        public string StreetAddress { get; set; }

        [Display(Name = "City", Prompt = "City")]
        public string City { get; set; }

        [Display(Name = "State", Prompt = "State")]
        public string State { get; set; }

        [Display(Name = "Zip Code", Prompt = "Zip Code")]
        public string? Zip { get; set; }

        [EmailAddress]
        [Display(Name = "Email", Prompt = "Email")]
        public string Email { get; set; }

        // ✅ Problem Types
        [Display(Name = "Sidewalk", Prompt = "Sidewalk")]
        public bool SideWalk { get; set; }

        [Display(Name = "Potholes/Pavement", Prompt = "Potholes/Pavement")]
        public bool Potholes { get; set; }

        [Display(Name = "Drainage", Prompt = "Drainage")]
        public bool Drainage { get; set; }

        [Display(Name = "Street Sweeping", Prompt = "Street Sweeping")]
        public bool StreetSweeping { get; set; }

        [Display(Name = "Parkway Tree", Prompt = "Parkway Tree")]
        public bool ParkwayTree { get; set; }

        [Display(Name = "Other", Prompt = "Other")]
        public bool Other { get; set; }

        [Display(Name = "Problem Description", Prompt = "Problem Description")]
        public string? Description { get; set; }

        // ✅ Safety / Regulatory
        [Display(Name = "Gas Odor Detected?")]
        public bool GasOdorDetected { get; set; }

        [Display(Name = "Evacuation Needed?")]
        public bool EvacuationNeeded { get; set; }

        [Display(Name = "Responders Notified?")]
        public string RespondersNotified { get; set; }

        [Display(Name = "Regulatory Step/Policy Code")]
        public string RegulatoryStepCode { get; set; }

        // ✅ Dispatch / Assignment
        [Display(Name = "Assigned Technician")]
        public string AssignedTechnicians { get; set; }

        [Display(Name = "Assigned Crew / Department")]
        public string AssignedCrew { get; set; }

        [Display(Name = "Supervisor / Approver Name")]
        public string SupervisorName { get; set; }

        // ✅ Dispatch Status (integer)
        [Display(Name = "Dispatch Status")]
        public int? DispatchStatusId { get; set; }

        // Optionally populate this from DB (if needed for dropdown binding later)
        public List<SelectListItem> DispatchStatuses { get; set; } = new();

        // ✅ File Upload
        [Display(Name = "Problem Photo")]
        public IFormFile? Photo { get; set; }  // Uploaded file

        public string? PhotoPath { get; set; } // Saved file path

        // ✅ Status (only editable for admins)
        public SSRStatus? Status { get; set; } = SSRStatus.Open;
    }

}

