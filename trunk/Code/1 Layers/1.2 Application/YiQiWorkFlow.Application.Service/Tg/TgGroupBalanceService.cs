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
    public class TgGroupBalanceService:ITgGroupBalanceService
    {

        public IRepositoryGUID<TgGroupBalance> EntityRepository { get; set; }

        [Transaction]
        public string Create(TgGroupBalance entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public TgGroupBalance GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<TgGroupBalance> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(TgGroupBalance entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(TgGroupBalance entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<TgGroupBalance> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<TgGroupBalance> Search(SearchDtoBase<TgGroupBalance> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.PaywayCode) == false)
					{
						q = q.Where(p => p.PaywayCode.Contains(c.entity.PaywayCode));
					}
					if (string.IsNullOrEmpty(c.entity.EnCode) == false)
					{
						q = q.Where(p => p.EnCode.Contains(c.entity.EnCode));
					}
					if (string.IsNullOrEmpty(c.entity.GroupNumber) == false)
					{
						q = q.Where(p => p.GroupNumber.Contains(c.entity.GroupNumber));
					}
					if (string.IsNullOrEmpty(c.entity.TaCode) == false)
					{
						q = q.Where(p => p.TaCode.Contains(c.entity.TaCode));
					}
					 if (c.entity.PersonTimes > 0)
					{
						q = q.Where(p => p.PersonTimes == c.entity.PersonTimes);
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
					
					 if (c.entity.TaReturnsMoney > 0)
					{
						q = q.Where(p => p.TaReturnsMoney == c.entity.TaReturnsMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.GuideCode) == false)
					{
						q = q.Where(p => p.GuideCode.Contains(c.entity.GuideCode));
					}
					if (string.IsNullOrEmpty(c.entity.ContactPhone) == false)
					{
						q = q.Where(p => p.ContactPhone.Contains(c.entity.ContactPhone));
					}
					 if (c.entity.GuidePushMoney > 0)
					{
						q = q.Where(p => p.GuidePushMoney == c.entity.GuidePushMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.Expostor) == false)
					{
						q = q.Where(p => p.Expostor.Contains(c.entity.Expostor));
					}
					 if (c.entity.ExpostorPushMoney > 0)
					{
						q = q.Where(p => p.ExpostorPushMoney == c.entity.ExpostorPushMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.Driver) == false)
					{
						q = q.Where(p => p.Driver.Contains(c.entity.Driver));
					}
					 if (c.entity.StopCharge > 0)
					{
						q = q.Where(p => p.StopCharge == c.entity.StopCharge);
					}
					
					 if (c.entity.NopayMoney > 0)
					{
						q = q.Where(p => p.NopayMoney == c.entity.NopayMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.RebalanceCause) == false)
					{
						q = q.Where(p => p.RebalanceCause.Contains(c.entity.RebalanceCause));
					}
					if (string.IsNullOrEmpty(c.entity.IfBalance) == false)
					{
						q = q.Where(p => p.IfBalance.Contains(c.entity.IfBalance));
					}
					if (string.IsNullOrEmpty(c.entity.Operator) == false)
					{
						q = q.Where(p => p.Operator.Contains(c.entity.Operator));
					}
					if (string.IsNullOrEmpty(c.entity.Assessor) == false)
					{
						q = q.Where(p => p.Assessor.Contains(c.entity.Assessor));
					}
					if (string.IsNullOrEmpty(c.entity.IfExamine) == false)
					{
						q = q.Where(p => p.IfExamine.Contains(c.entity.IfExamine));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.PaywayCode.Contains(c.key)
					|| l.EnCode.Contains(c.key)
					|| l.GroupNumber.Contains(c.key)
					|| l.TaCode.Contains(c.key)
					|| l.GuideCode.Contains(c.key)
					|| l.ContactPhone.Contains(c.key)
					|| l.Expostor.Contains(c.key)
					|| l.Driver.Contains(c.key)
					|| l.RebalanceCause.Contains(c.key)
					|| l.IfBalance.Contains(c.key)
					|| l.Operator.Contains(c.key)
					|| l.Assessor.Contains(c.key)
					|| l.IfExamine.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<TgGroupBalance> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.PaywayCode.Contains(key)
					|| l.EnCode.Contains(key)
					|| l.GroupNumber.Contains(key)
					|| l.TaCode.Contains(key)
					|| l.GuideCode.Contains(key)
					|| l.ContactPhone.Contains(key)
					|| l.Expostor.Contains(key)
					|| l.Driver.Contains(key)
					|| l.RebalanceCause.Contains(key)
					|| l.IfBalance.Contains(key)
					|| l.Operator.Contains(key)
					|| l.Assessor.Contains(key)
					|| l.IfExamine.Contains(key)
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




