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
using YiQiWorkFlow.Domain.Em;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Em
{
    public class EmPaPoliticsService:IEmPaPoliticsService
    {

        public IRepositoryGUID<EmPaPolitics> EntityRepository { get; set; }

        [Transaction]
        public string Create(EmPaPolitics entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public EmPaPolitics GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<EmPaPolitics> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(EmPaPolitics entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(EmPaPolitics entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<EmPaPolitics> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<EmPaPolitics> Search(SearchDtoBase<EmPaPolitics> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.PoliticsCode) == false)
					{
						q = q.Where(p => p.PoliticsCode.Contains(c.entity.PoliticsCode));
					}
					if (string.IsNullOrEmpty(c.entity.PoliticsName) == false)
					{
						q = q.Where(p => p.PoliticsName.Contains(c.entity.PoliticsName));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.PoliticsCode.Contains(c.key)
					|| l.PoliticsName.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<EmPaPolitics> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.PoliticsCode.Contains(key)
					|| l.PoliticsName.Contains(key)
                    select l;
					
                
            }
            q = q.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            var result = q.ToList();
            return result.ToList();
        }

        [Transaction]
        public void Delete(IList<string> ids)
        {
            var q = EntityRepository.LinqQuery.Where(p => ids.Contains(p.Id));
            foreach (var each in q)
            {
                Delete(each);
            }
        }
    }
}




