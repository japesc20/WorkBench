using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using backend.Models.Inspection;
using backend.Dtos;
using backend.Data;
using WorkBench.Dtos;


namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChecklistController : ControllerBase
    {
        private readonly List<ChecklistCreate> _checklists = new List<ChecklistCreate> { };
        private readonly ApplicationDbContext _context;

        public ChecklistController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpPost("create-checklist")]
        public IActionResult CreateChecklist([FromBody] ChecklistCreate checklist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newChecklist = new Checklist
            {
                Id = checklist.Id,
                PartNumber = checklist.PartNumber,
                PartRevision = checklist.PartRevision,
                Operation = checklist.Operation,
                Timestamp = checklist.Timestamp,
                InspectorID = checklist.InspectorID,
                Items = checklist.Items.Select(item => new ChecklistItem
                {
                    Characteristic = item.Characteristic,
                    UpperTolerance = item.UpperTolerance,
                    LowerTolerance = item.LowerTolerance,
                    Measurement = item.Measurement,
                    Gage = item.Gage,
                    MeasurementStatus = item.MeasurementStatus,
                    Comment = item.Comment
                }).ToList()
            };

            // LATER SAVE VIA SERVICE LAYER
            _context.Checklists.Add(newChecklist);
            _context.SaveChanges();
            //

            return Ok(newChecklist);
        }

        [HttpGet("checklist-by-id/{id}")]
        public IActionResult CreateChecklistById(string id)
        {
            var checklist = _context.Checklists.FirstOrDefault(c => c.Id == id);

            if (checklist == null)
            {
                return NotFound();
            }
            return Ok(checklist);
        }

        [HttpGet("all-checklists")]
        public IActionResult GetAllChecklists()
        {
            var checklists = _context.Checklists.ToList();

            return Ok(checklists);
        }

        [HttpPatch("checklist-update")]
        public IActionResult ChecklistUpdate(string id, [FromBody] ChecklistUpdate checklistUpdate)
        {
            var existingChecklist = _context.Checklists.FirstOrDefault(c => c.Id == id);

            if (existingChecklist == null) {
                return NotFound($"Checklist with {id} is not found");
            }

            if (!string.IsNullOrEmpty(checklistUpdate.PartNumber))
            {
                existingChecklist.PartNumber = checklistUpdate.PartNumber;
            }

            if (!string.IsNullOrEmpty(checklistUpdate.PartRevision)) 
            {
                existingChecklist.PartRevision = checklistUpdate.PartRevision;
            }

            if (!string.IsNullOrEmpty(checklistUpdate.Operation)) 
            {
                existingChecklist.Operation = checklistUpdate.Operation;
            }

            if (!string.IsNullOrEmpty(checklistUpdate.InspectorID)) 
            {
                existingChecklist.InspectorID = checklistUpdate.InspectorID;
            }

            if (checklistUpdate.Timestamp != null) 
            {
                existingChecklist.Timestamp = checklistUpdate.Timestamp;
            }

            return Ok();
        }

        // [HttpDelete("delete-checklist")]
        // public IActionResult DeleteChecklist([FromBody] DeleteChecklist deleteChecklist)
        // {

        // }
    }
}