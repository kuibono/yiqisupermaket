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
    public class AcPeriodTimeSummaryService:IAcPeriodTimeSummaryService
    {

        public IRepository<AcPeriodTimeSummary> EntityRepository { get; set; }

        [Transaction]
        public int Create(AcPeriodTimeSummary entity)
        {
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public AcPeriodTimeSummary GetById(int id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<AcPeriodTimeSummary> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(AcPeriodTimeSummary entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(AcPeriodTimeSummary entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<AcPeriodTimeSummary> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<AcPeriodTimeSummary> Search(SearchDtoBase<AcPeriodTimeSummary> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
					if (string.IsNullOrEmpty(c.entity.RtDate) == false)
					{
						q = q.Where(p => p.RtDate.Contains(c.entity.RtDate));
					}
					if (string.IsNullOrEmpty(c.entity.PeriodTime) == false)
					{
						q = q.Where(p => p.PeriodTime.Contains(c.entity.PeriodTime));
					}
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					if (string.IsNullOrEmpty(c.entity.bCode) == false)
					{
						q = q.Where(p => p.bCode.Contains(c.entity.bCode));
					}
					 if (c.entity.PassengerFlow > 0)
					{
						q = q.Where(p => p.PassengerFlow == c.entity.PassengerFlow);
					}
					
					 if (c.entity.AvgSalePrice > 0)
					{
						q = q.Where(p => p.AvgSalePrice == c.entity.AvgSalePrice);
					}
					
					 if (c.entity.SaleQty > 0)
					{
						q = q.Where(p => p.SaleQty == c.entity.SaleQty);
					}
					
					 if (c.entity.SaleMoney > 0)
					{
						q = q.Where(p => p.SaleMoney == c.entity.SaleMoney);
					}
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.RtDate.Contains(c.key)
					|| l.PeriodTime.Contains(c.key)
					|| l.WhCode.Contains(c.key)
					|| l.bCode.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<AcPeriodTimeSummary> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.RtDate.Contains(key)
					|| l.PeriodTime.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.bCode.Contains(key)
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



