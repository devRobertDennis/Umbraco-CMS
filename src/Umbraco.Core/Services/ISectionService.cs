﻿using System.Collections.Generic;
using Umbraco.Core.Models;

namespace Umbraco.Core.Services
{
    public interface ISectionService
    {
        /// <summary>
        /// Ensures all available sections exist in the storage medium
        /// </summary>
        /// <param name="existingSections"></param>
        void Initialize(IEnumerable<Section> existingSections);

        /// <summary>
        /// The cache storage for all applications
        /// </summary>
        IEnumerable<Section> GetSections();

        /// <summary>
        /// Get the user's allowed sections
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        IEnumerable<Section> GetAllowedSections(int userId);

        /// <summary>
        /// Gets the application by its alias.
        /// </summary>
        /// <param name="appAlias">The application alias.</param>
        /// <returns></returns>
        Section GetByAlias(string appAlias);

        /// <summary>
        /// Creates a new applcation if no application with the specified alias is found.
        /// </summary>
        /// <param name="name">The application name.</param>
        /// <param name="alias">The application alias.</param>
        /// <param name="icon">The application icon, which has to be located in umbraco/images/tray folder.</param>
        void MakeNew(string name, string alias, string icon);

        /// <summary>
        /// Makes the new.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="alias">The alias.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="sortOrder">The sort order.</param>
        void MakeNew(string name, string alias, string icon, int sortOrder);

        /// <summary>
        /// Deletes the section
        /// </summary>        
        void DeleteSection(Section section);
    }
}