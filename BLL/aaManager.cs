using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL
{
    public class aaManager
    {
        //查询全部信息
        public static IQueryable GetaaAll()
        {
            return aaService.GetaaAll();
        }
        //新增
        public static int aaAdd(aa a)
        {
            return aaService.aaAdd(a);
        }
        //删除
        public static int Del(int id)
        {
            return aaService.Del(id);
        }
        //修改根据ID先查询全部信息
        public static IQueryable GetById(int id)
        {
            return aaService.GetById(id);
        }
        //修改
        public static int Edit(aa a)
        {
            return aaService.Edit(a);
        }
    }
}
