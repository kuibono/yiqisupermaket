/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:07
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public class TgGroupBalanceDetailService:ITgGroupBalanceDetailService
    {

        public IRepositoryGUID<TgGroupBalanceDetail> EntityRepository { get; set; }

        [Transaction]
        public string Create(TgGroupBalanceDetail entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public TgGroupBalanceDetail GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<TgGroupBalanceDetail> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(TgGroupBalanceDetail entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(TgGroupBalanceDetail entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<TgGroupBalanceDetail> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<TgGroupBalanceDetail> Search(SearchDtoBase<TgGroupBalanceDetail> c)
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
					if (string.IsNullOrEmpty(c.entity.BaItems) == false)
					{
						
						q = q.Where(p => p.BaItems.Contains(c.entity.BaItems));
					}
					if (string.IsNullOrEmpty(c.entity.GroupNumber) == false)
					{
						
						q = q.Where(p => p.GroupNumber.Contains(c.entity.GroupNumber));
					}
					if (string.IsNullOrEmpty(c.entity.GuideCode) == false)
					{
						
						q = q.Where(p => p.GuideCode.Contains(c.entity.GuideCode));
					}
					if (string.IsNullOrEmpty(c.entity.GuideName) == false)
					{
						
						q = q.Where(p => p.GuideName.Contains(c.entity.GuideName));
					}
					if (string.IsNullOrEmpty(c.entity.GbCode) == false)
					{
						
						q = q.Where(p => p.GbCode.Contains(c.entity.GbCode));
					}
					 if (c.entity.SaleMoney > 0)
					{
						q = q.Where(p => p.SaleMoney == c.entity.SaleMoney);
					}
					
					 if (c.entity.PushRate > 0)
					{
						q = q.Where(p => p.PushRate == c.entity.PushRate);
					}
					
					 if (c.entity.PushMoney > 0)
					{
						q = q.Where(p => p.PushMoney == c.entity.PushMoney);
					}
					
					 if (c.entity.PtimesMoney > 0)
					{
						q = q.Where(p => p.PtimesMoney == c.entity.PtimesMoney);
					}
					
					 if (c.entity.TotalPushMoney > 0)
					{
						q = q.Where(p => p.TotalPushMoney == c.entity.TotalPushMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.BaState) == false)
					{
						
						q = q.Where(p => p.BaState.Contains(c.entity.BaState));
					}
					if (string.IsNullOrEmpty(c.entity.BaType) == false)
					{
						
						q = q.Where(p => p.BaType.Contains(c.entity.BaType));
					}
					if (string.IsNullOrEmpty(c.entity.IfBalance) == false)
					{
						
						q = q.Where(p => p.IfBalance.Contains(c.entity.IfBalance));
					}
					if (string.IsNullOrEmpty(c.entity.IfPrint) == false)
					{
						
						q = q.Where(p => p.IfPrint.Contains(c.entity.IfPrint));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.BaNumber.Contains(c.key)
					|| l.sNumber.Contains(c.key)
					|| l.BaItems.Contains(c.key)
					|| l.GroupNumber.Contains(c.key)
					|| l.GuideCode.Contains(c.key)
					|| l.GuideName.Contains(c.key)
					|| l.GbCode.Contains(c.key)
					|| l.BaState.Contains(c.key)
					|| l.BaType.Contains(c.key)
					|| l.IfBalance.Contains(c.key)
					|| l.IfPrint.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<TgGroupBalanceDetail> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.BaNumber.Contains(key)
					|| l.sNumber.Contains(key)
					|| l.BaItems.Contains(key)
					|| l.GroupNumber.Contains(key)
					|| l.GuideCode.Contains(key)
					|| l.GuideName.Contains(key)
					|| l.GbCode.Contains(key)
					|| l.BaState.Contains(key)
					|| l.BaType.Contains(key)
					|| l.IfBalance.Contains(key)
					|| l.IfPrint.Contains(key)
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




