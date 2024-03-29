using System.Collections.Generic;
using Apartments_API.DTO;
using Apartments_API.Models;

namespace Apartments_API.Repository.Repositories
{
    public interface IButasRepository : IRepositoryBase<Butas>
    {
        /// <summary>
        /// Searches spartments by given options
        /// </summary>
        /// <param name="searchDto">Search options</param>
        /// <returns>Found apartments</returns>
        IEnumerable<Butas> Search(ApartmentsSearchDto searchDto);

        /// <summary>
        /// Adds or updates apartment's rating
        /// </summary>
        /// <param name="ratingDto">Rating data</param>
        /// <returns>Created or Updated rating</returns>
        Reitingas Rate(RatingDto ratingDto);
        Butas Add(ApartmentCreateDto apartmentCreateDto);
        void Update(ApartmentUpdateDto apartmentCreateDto);
        bool Delete(ApartmentDeleteDto apartmentCreateDto);
        IEnumerable<Butas> Search(ReportDto searchDto);
    }
}