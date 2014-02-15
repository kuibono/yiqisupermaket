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
    public class TgTravelBalanceDetailService:ITgTravelBalanceDetailService
    {

        public IRepositoryGUID<TgTravelBalanceDetail> EntityRepository { get; set; }

        [Transaction]
        public string Create(TgTravelBalanceDetail entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public TgTravelBalanceDetail GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<TgTravelBalanceDetail> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(TgTravelBalanceDetail entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(TgTravelBalanceDetail entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<TgTravelBalanceDetail> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<TgTravelBalanceDetail> Search(SearchDtoBase<TgTravelBalanceDetail> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.BaNumber) == false)
					{
						q = q.Where(p => p.BaNumber.Contains(c.entity.BaNumber));
					}
					if (string.IsNullOrEmpty(c.entity.sNumber) == false)
					{
						q = q.Where(p => p.sNumber.Contains(c.entity.sNumber));
					}
					if (string.IsNullOrEmpty(c.entity.BaNopayNumber) == false)
					{
						q = q.Where(p => p.BaNopayNumber.Contains(c.entity.BaNopayNumber));
					}
					if (string.IsNullOrEmpty(c.entity.GroupNumber) == false)
					{
						q = q.Where(p => p.GroupNumber.Contains(c.entity.GroupNumber));
					}
					if (string.IsNullOrEmpty(c.entity.BaItems) == false)
					{
						q = q.Where(p => p.BaItems.Contains(c.entity.BaItems));
					}
					if (string.IsNullOrEmpty(c.entity.GbCode) == false)
					{
						q = q.Where(p => p.GbCode.Contains(c.entity.GbCode));
					}
					if (string.IsNullOrEmpty(c.entity.GuideCode) == false)
					{
						q = q.Where(p => p.GuideCode.Contains(c.entity.GuideCode));
					}
					 if (c.entity.SaleMoney > 0)
					{
						q = q.Where(p => p.SaleMoney == c.entity.SaleMoney);
					}
					
					 if (c.entity.PushMoney > 0)
					{
						q = q.Where(p => p.PushMoney == c.entity.PushMoney);
					}
					
					 if (c.entity.AdjustMoney > 0)
					{
						q = q.Where(p => p.AdjustMoney == c.entity.AdjustMoney);
					}
					
					 if (c.entity.TotalPushMoney > 0)
					{
						q = q.Where(p => p.TotalPushMoney == c.entity.TotalPushMoney);
					}
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.BaNumber.Contains(c.key)
					|| l.sNumber.Contains(c.key)
					|| l.BaNopayNumber.Contains(c.key)
					|| l.GroupNumber.Contains(c.key)
					|| l.BaItems.Contains(c.key)
					|| l.GbCode.Contains(c.key)
					|| l.GuideCode.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<TgTravelBalanceDetail> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.BaNumber.Contains(key)
					|| l.sNumber.Contains(key)
					|| l.BaNopayNumber.Contains(key)
					|| l.GroupNumber.Contains(key)
					|| l.BaItems.Contains(key)
					|| l.GbCode.Contains(key)
					|| l.GuideCode.Contains(key)
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




