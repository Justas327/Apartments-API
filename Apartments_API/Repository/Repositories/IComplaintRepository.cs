using Apartments_API.DTO;
using Apartments_API.Models;
using System.Collections.Generic;

namespace Apartments_API.Repository.Repositories
{
    public interface IComplaintRepository : IRepositoryBase<Skundas>
    {
        /// <summary>
        /// Saves complaint to the db
        /// </summary>
        /// <param name="complaintDto">Complaint information</param>
        /// <returns>Saved complaint information</returns>
        Skundas WriteComplaint(ComplaintWriteDto complaintDto);
        IEnumerable<Skundas> Search(ApartmentsSearchDto searchDto);

    }
}