using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class aaService
    {
        //查询全部信息
        public static IQueryable GetaaAll()
        {
            LianXiEntities1 lian = new LianXiEntities1();
            var obj = from p in lian.aa
                      select new
                      {
                          id = p.id,
                          name = p.name,
                          age = p.age
                      };
            return obj;
        }
        //新增
        public static int aaAdd(aa a)
        {
            LianXiEntities1 lian = new LianXiEntities1();
            lian.aa.Add(a);
            return lian.SaveChanges();
        }
        //删除
        public static int Del(int id)
        {
            LianXiEntities1 lian = new LianXiEntities1();
            var obj = (from p in lian.aa where p.id == id select p).First();
            lian.aa.Remove(obj);
            return lian.SaveChanges();
        }
        //修改根据ID先查询全部信息
        public static IQueryable GetById(int id) {
            LianXiEntities1 lian = new LianXiEntities1();
            var obj = from p in lian.aa
                      where p.id == id
                      select new
                      {
                          id = p.id,
                          name = p.name,
                          age = p.age
                      };
            return obj;
        }
        //修改
        public static int Edit(aa a) {
            LianXiEntities1 lian = new LianXiEntities1();
            var obj = (from p in lian.aa where p.id == a.id select p).First();
            obj.name = a.name;
            obj.age = a.age;
            return lian.SaveChanges();
        }
    }
}
