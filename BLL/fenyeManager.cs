using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class fenyeManager
    {
        public static int GetRows()
        {
            return fenyeService.GetRows();
        }
        ////分页查询
        //public static IQueryable FenGetAll(int PageIndex, int PageSize)
        //{
        //    return fenyeService.FenGetAll(PageIndex, PageSize);
        //}
        public static PageList PageListAA(int PageIndex, int PageSize)
        {
            return fenyeService.PageListAA(PageIndex, PageSize);
        }
    }
}
