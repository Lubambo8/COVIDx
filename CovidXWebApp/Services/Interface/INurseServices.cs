using CovidXWebApp.Models.ViewModel;
using EFCore.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.Services.Interface
{
    public interface INurseServices
    {
        /// <summary>
        /// Add new <see cref="Nurse"/> to the database
        /// </summary>
        /// <param name="model">The data for the patient profile</param>
        /// <returns>True if there was an entity added</returns>
        bool AddNurse(NurseCreateViewModel model);

        /// <summary>
        /// Gets a list of suburbs to load items for a drop-down
        /// </summary>
        /// <returns> <see cref="Suburb.SuburbID"/> as the selected value and <see cref="Suburb.SuburbName"/> as the display value</returns>
        SelectList GetSuburbList();

        /// <summary>
        /// Check if Nurse already exists
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        bool NurseExists(string UserID);

        /// <summary>
        /// Add Nurse's favourite suburbs
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool AddSuburbs(NurseSuburbsModel model);

        /// <summary>
        /// Find nurse by user id
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        Nurse FindNurseByUserID(string UserID);

        IQueryable<SuburbsPreferred> GetFavouriteSuburbs();

        /// <summary>
        /// Find a nurse's favourite suburbs
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        List<SuburbsPreferred> GetSuburbsPreffereds(string userID);
    }
}
