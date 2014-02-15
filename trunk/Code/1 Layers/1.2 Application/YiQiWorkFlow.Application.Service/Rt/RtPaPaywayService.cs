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
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public class RtPaPaywayService:IRtPaPaywayService
    {

        public IRepositoryGUID<RtPaPayway> EntityRepository { get; set; }

        [Transaction]
        public string Create(RtPaPayway entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public RtPaPayway GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<RtPaPayway> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(RtPaPayway entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(RtPaPayway entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<RtPaPayway> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<RtPaPayway> Search(SearchDtoBase<RtPaPayway> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.PaywayName) == false)
					{
						q = q.Where(p => p.PaywayName.Contains(c.entity.PaywayName));
					}
					if (string.IsNullOrEmpty(c.entity.PaywaySubCode) == false)
					{
						q = q.Where(p => p.PaywaySubCode.Contains(c.entity.PaywaySubCode));
					}
					if (string.IsNullOrEmpty(c.entity.PaywayType) == false)
					{
						q = q.Where(p => p.PaywayType.Contains(c.entity.PaywayType));
					}
					 if (c.entity.ExRate > 0)
					{
						q = q.Where(p => p.ExRate == c.entity.ExRate);
					}
					
					if (string.IsNullOrEmpty(c.entity.IfChange) == false)
					{
						q = q.Where(p => p.IfChange.Contains(c.entity.IfChange));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.PaywayName.Contains(c.key)
					|| l.PaywaySubCode.Contains(c.key)
					|| l.PaywayType.Contains(c.key)
					|| l.IfChange.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<RtPaPayway> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.PaywayName.Contains(key)
					|| l.PaywaySubCode.Contains(key)
					|| l.PaywayType.Contains(key)
					|| l.IfChange.Contains(key)
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




