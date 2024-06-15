using DataAccessLayer.DTOs;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MapperClasses
{
    public class ReportMapper
    {
        public static ReportDTO MapToDTO(Report report)
        {
            return new ReportDTO
            {
                Id = report.Id,
                Title = report.Title,
                Category = report.Category.ToString(), // Assuming ReportCategory is an enum
                Description = report.Description,
                DateCreated = report.DateCreated,
                CreatedBy = report.CreatedBy.Id  // Assuming CreatedBy is an Employee object
            };
        }

        public static Report MapFromDTO(ReportDTO reportDTO, Employee createdBy)
        {
            return new Report(
                reportDTO.Title,
                Enum.Parse<ReportCategory>(reportDTO.Category), // Convert string to enum
                reportDTO.Description,
                createdBy)
            {
                Id = reportDTO.Id,
                DateCreated = reportDTO.DateCreated
            };
        }
    }
}
