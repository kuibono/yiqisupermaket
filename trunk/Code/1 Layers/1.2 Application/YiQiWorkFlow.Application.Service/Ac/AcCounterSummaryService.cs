/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:06
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public class AcCounterSummaryService:IAcCounterSummaryService
    {

        public IRepositoryGUID<AcCounterSummary> EntityRepository { get; set; }

        [Transaction]
        public string Create(AcCounterSummary entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public AcCounterSummary GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<AcCounterSummary> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(AcCounterSummary entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(AcCounterSummary entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<AcCounterSummary> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<AcCounterSummary> Search(SearchDtoBase<AcCounterSummary> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					 if (c.entity.RtFlowNumber > 0)
					{
						q = q.Where(p => p.RtFlowNumber == c.entity.RtFlowNumber);
					}
					
					if (string.IsNullOrEmpty(c.entity.RtDate) == false)
					{
						
						q = q.Where(p => p.RtDate.Contains(c.entity.RtDate));
					}
					if (string.IsNullOrEmpty(c.entity.UnderCounterCode) == false)
					{
						
						q = q.Where(p => p.UnderCounterCode.Contains(c.entity.UnderCounterCode));
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
                    l.Id.Contains(c.key)
					|| l.RtDate.Contains(c.key)
					|| l.UnderCounterCode.Contains(c.key)
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
        public IList<AcCounterSummary> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.RtDate.Contains(key)
					|| l.UnderCounterCode.Contains(key)
					|| l.RtType.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.bCode.Contains(key)
					|| l.PaywayCode.Contains(key)
					|| l.Id.Contains(key)
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




