/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:49
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public class BsPaAreaService:IBsPaAreaService
    {

        public IRepositoryGUID<BsPaArea> EntityRepository { get; set; }

        [Transaction]
        public string Create(BsPaArea entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public BsPaArea GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<BsPaArea> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(BsPaArea entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(BsPaArea entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<BsPaArea> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<BsPaArea> Search(SearchDtoBase<BsPaArea> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.AreaCode) == false)
					{
						q = q.Where(p => p.AreaCode.Contains(c.entity.AreaCode));
					}
					if (string.IsNullOrEmpty(c.entity.AreaName) == false)
					{
						q = q.Where(p => p.AreaName.Contains(c.entity.AreaName));
					}
					if (string.IsNullOrEmpty(c.entity.Functionary) == false)
					{
						q = q.Where(p => p.Functionary.Contains(c.entity.Functionary));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.AreaCode.Contains(c.key)
					|| l.AreaName.Contains(c.key)
					|| l.Functionary.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<BsPaArea> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.AreaCode.Contains(key)
					|| l.AreaName.Contains(key)
					|| l.Functionary.Contains(key)
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




