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
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public class TgPaCarsChargeService:ITgPaCarsChargeService
    {

        public IRepositoryGUID<TgPaCarsCharge> EntityRepository { get; set; }

        [Transaction]
        public string Create(TgPaCarsCharge entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public TgPaCarsCharge GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<TgPaCarsCharge> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(TgPaCarsCharge entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(TgPaCarsCharge entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<TgPaCarsCharge> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<TgPaCarsCharge> Search(SearchDtoBase<TgPaCarsCharge> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.CarsTypeCode) == false)
					{
						q = q.Where(p => p.CarsTypeCode.Contains(c.entity.CarsTypeCode));
					}
					 if (c.entity.PersonLower > 0)
					{
						q = q.Where(p => p.PersonLower == c.entity.PersonLower);
					}
					
					 if (c.entity.PersonUpper > 0)
					{
						q = q.Where(p => p.PersonUpper == c.entity.PersonUpper);
					}
					
					 if (c.entity.StopCharge > 0)
					{
						q = q.Where(p => p.StopCharge == c.entity.StopCharge);
					}
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.CarsTypeCode.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<TgPaCarsCharge> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.CarsTypeCode.Contains(key)
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




