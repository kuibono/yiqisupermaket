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
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public class AcCashierSummaryService:IAcCashierSummaryService
    {

        public IRepository<AcCashierSummary> EntityRepository { get; set; }

        [Transaction]
        public int Create(AcCashierSummary entity)
        {
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public AcCashierSummary GetById(int id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<AcCashierSummary> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(AcCashierSummary entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(AcCashierSummary entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<AcCashierSummary> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<AcCashierSummary> Search(SearchDtoBase<AcCashierSummary> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
					if (string.IsNullOrEmpty(c.entity.RtDate) == false)
					{
						q = q.Where(p => p.RtDate.Contains(c.entity.RtDate));
					}
					if (string.IsNullOrEmpty(c.entity.Cashier) == false)
					{
						q = q.Where(p => p.Cashier.Contains(c.entity.Cashier));
					}
					if (string.IsNullOrEmpty(c.entity.RtType) == false)
					{
						q = q.Where(p => p.RtType.Contains(c.entity.RtType));
					}
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					if (string.IsNullOrEmpty(c.entity.bCode) == false)
					{
						q = q.Where(p => p.bCode.Contains(c.entity.bCode));
					}
					if (string.IsNullOrEmpty(c.entity.PaywayCode) == false)
					{
						q = q.Where(p => p.PaywayCode.Contains(c.entity.PaywayCode));
					}
					 if (c.entity.SaleMoney > 0)
					{
						q = q.Where(p => p.SaleMoney == c.entity.SaleMoney);
					}
					
					 if (c.entity.ExRate > 0)
					{
						q = q.Where(p => p.ExRate == c.entity.ExRate);
					}
					
					 if (c.entity.PayMoney > 0)
					{
						q = q.Where(p => p.PayMoney == c.entity.PayMoney);
					}
					
					 if (c.entity.PayLoss > 0)
					{
						q = q.Where(p => p.PayLoss == c.entity.PayLoss);
					}
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.RtDate.Contains(c.key)
					|| l.Cashier.Contains(c.key)
					|| l.RtType.Contains(c.key)
					|| l.WhCode.Contains(c.key)
					|| l.bCode.Contains(c.key)
					|| l.PaywayCode.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<AcCashierSummary> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.RtDate.Contains(key)
					|| l.Cashier.Contains(key)
					|| l.RtType.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.bCode.Contains(key)
					|| l.PaywayCode.Contains(key)
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




