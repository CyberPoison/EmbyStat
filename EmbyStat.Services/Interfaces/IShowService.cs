﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EmbyStat.Common.Helpers;
using EmbyStat.Common.Models.Entities;
using EmbyStat.Services.Models.Show;

namespace EmbyStat.Services.Interfaces
{
    public interface IShowService
    {
        IEnumerable<Library> GetShowLibraries();
        Task<ShowStatistics> GetStatistics(List<string> libraryIds);
        Task<ShowStatistics> CalculateShowStatistics(List<string> libraryIds);
        ListContainer<ShowCollectionRow> GetCollectedRows(List<string> libraryIds, int page);
        List<ShowCollectionRow> CalculateCollectedRows(List<string> libraryIds);
        bool TypeIsPresent();
    }
}
