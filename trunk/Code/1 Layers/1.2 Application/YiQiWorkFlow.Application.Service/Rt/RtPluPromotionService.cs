/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:07
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public class RtPluPromotionService:IRtPluPromotionService
    {

        public IRepositoryGUID<RtPluPromotion> EntityRepository { get; set; }

        [Transaction]
        public string Create(RtPluPromotion entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public RtPluPromotion GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<RtPluPromotion> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(RtPluPromotion entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(RtPluPromotion entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<RtPluPromotion> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<RtPluPromotion> Search(SearchDtoBase<RtPluPromotion> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.EnCode) == false)
					{
						
						q = q.Where(p => p.EnCode.Contains(c.entity.EnCode));
					}
					if (string.IsNullOrEmpty(c.entity.SpBeginDate) == false)
					{
						
						q = q.Where(p => p.SpBeginDate.Contains(c.entity.SpBeginDate));
					}
					if (string.IsNullOrEmpty(c.entity.SpEndDate) == false)
					{
						
						q = q.Where(p => p.SpEndDate.Contains(c.entity.SpEndDate));
					}
					if (string.IsNullOrEmpty(c.entity.SpBeginTime) == false)
					{
						
						q = q.Where(p => p.SpBeginTime.Contains(c.entity.SpBeginTime));
					}
					if (string.IsNullOrEmpty(c.entity.SpEndTime) == false)
					{
						
						q = q.Where(p => p.SpEndTime.Contains(c.entity.SpEndTime));
					}
					if (string.IsNullOrEmpty(c.entity.SpW1) == false)
					{
						
						q = q.Where(p => p.SpW1.Contains(c.entity.SpW1));
					}
					if (string.IsNullOrEmpty(c.entity.SpW2) == false)
					{
						
						q = q.Where(p => p.SpW2.Contains(c.entity.SpW2));
					}
					if (string.IsNullOrEmpty(c.entity.SpW3) == false)
					{
						
						q = q.Where(p => p.SpW3.Contains(c.entity.SpW3));
					}
					if (string.IsNullOrEmpty(c.entity.SpW4) == false)
					{
						
						q = q.Where(p => p.SpW4.Contains(c.entity.SpW4));
					}
					if (string.IsNullOrEmpty(c.entity.SpW5) == false)
					{
						
						q = q.Where(p => p.SpW5.Contains(c.entity.SpW5));
					}
					if (string.IsNullOrEmpty(c.entity.SpW6) == false)
					{
						
						q = q.Where(p => p.SpW6.Contains(c.entity.SpW6));
					}
					if (string.IsNullOrEmpty(c.entity.SpW7) == false)
					{
						
						q = q.Where(p => p.SpW7.Contains(c.entity.SpW7));
					}
					if (string.IsNullOrEmpty(c.entity.AdjustReason) == false)
					{
						
						q = q.Where(p => p.AdjustReason.Contains(c.entity.AdjustReason));
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
					|| l.EnCode.Contains(c.key)
					|| l.SpBeginDate.Contains(c.key)
					|| l.SpEndDate.Contains(c.key)
					|| l.SpBeginTime.Contains(c.key)
					|| l.SpEndTime.Contains(c.key)
					|| l.SpW1.Contains(c.key)
					|| l.SpW2.Contains(c.key)
					|| l.SpW3.Contains(c.key)
					|| l.SpW4.Contains(c.key)
					|| l.SpW5.Contains(c.key)
					|| l.SpW6.Contains(c.key)
					|| l.SpW7.Contains(c.key)
					|| l.AdjustReason.Contains(c.key)
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
        public IList<RtPluPromotion> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.SpNumber.Contains(key)
					|| l.EnCode.Contains(key)
					|| l.SpBeginDate.Contains(key)
					|| l.SpEndDate.Contains(key)
					|| l.SpBeginTime.Contains(key)
					|| l.SpEndTime.Contains(key)
					|| l.SpW1.Contains(key)
					|| l.SpW2.Contains(key)
					|| l.SpW3.Contains(key)
					|| l.SpW4.Contains(key)
					|| l.SpW5.Contains(key)
					|| l.SpW6.Contains(key)
					|| l.SpW7.Contains(key)
					|| l.AdjustReason.Contains(key)
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




