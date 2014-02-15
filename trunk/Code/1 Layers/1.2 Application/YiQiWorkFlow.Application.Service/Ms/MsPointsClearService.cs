/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public class MsPointsClearService:IMsPointsClearService
    {

        public IRepository<MsPointsClear> EntityRepository { get; set; }

        [Transaction]
        public int Create(MsPointsClear entity)
        {
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public MsPointsClear GetById(int id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<MsPointsClear> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(MsPointsClear entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(MsPointsClear entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<MsPointsClear> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<MsPointsClear> Search(SearchDtoBase<MsPointsClear> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
					if (string.IsNullOrEmpty(c.entity.Operator) == false)
					{
						q = q.Where(p => p.Operator.Contains(c.entity.Operator));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.Operator.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<MsPointsClear> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.Operator.Contains(key)
                    select l;
					
                
            }
            q = q.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            var result = q.ToList();
            return result.ToList();
        }

        [Transaction]
        public void Delete(IList<string> ids)
        {
			var int_ids = ids.ToList().Select(p => { return Convert.ToInt32(p); }).ToList();
            var q = EntityRepository.LinqQuery.Where(p => int_ids.Contains(p.Id));
            foreach (var each in q)
            {
                Delete(each);
            }
        }
    }
}




