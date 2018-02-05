using System;
using System.Collections.Generic;
using System.Linq;

namespace VacancyStore.Website.Models
{
    public class PageInfo<T>
    {
        public PageInfo(IEnumerable<T> itemsOnCurrentPage, int currentPageNumber, int itemsPerPage, long totalItemsCount)
        {
            TotalPageNumber = (int)Math.Ceiling((double)totalItemsCount/itemsPerPage);
            CurrentPageNumber = currentPageNumber;
            ItemsOnPage = itemsOnCurrentPage;
            TotalItemsCount = totalItemsCount;
        }

        public IEnumerable<T> ItemsOnPage { get; set; }
        public int CurrentPageNumber { get; set; }
        public int TotalPageNumber { get; set; }
        public long TotalItemsCount { get; set; }
    }
}