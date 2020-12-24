using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class fenyeService
    {
        ////分页查询
        //public static IQueryable FenGetAll(int PageIndex,int PageSize) {
        //    LianXiEntities1 lian = new LianXiEntities1();
        //    PageList list = new PageList();
        //    var obj = from p in lian.aa
        //              orderby p.id
        //              select new
        //              {
        //                  id = p.id,
        //                  name = p.name,
        //                  age = p.age
        //              };

        //    return obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
        //}
        public static PageList PageListAA(int PageIndex, int PageSize)
        {
            LianXiEntities1 lian = new LianXiEntities1();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in lian.aa
                      orderby p.id
                      select new
                      {
                          id = p.id,
                          name = p.name,
                          age = p.age
                      };
            //设置分页数据
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);

            int rows = lian.aa.Count();
            //设置总页数
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
    }
}
