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
    public class BsSupplyPromotionService:IBsSupplyPromotionService
    {

        public IRepositoryGUID<BsSupplyPromotion> EntityRepository { get; set; }

        [Transaction]
        public string Create(BsSupplyPromotion entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public BsSupplyPromotion GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<BsSupplyPromotion> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(BsSupplyPromotion entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(BsSupplyPromotion entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<BsSupplyPromotion> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<BsSupplyPromotion> Search(SearchDtoBase<BsSupplyPromotion> c)
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
					if (string.IsNullOrEmpty(c.entity.AdjustReason) == false)
					{
						q = q.Where(p => p.AdjustReason.Contains(c.entity.AdjustReason));
					}
					if (string.IsNullOrEmpty(c.entity.SpBranch) == false)
					{
						q = q.Where(p => p.SpBranch.Contains(c.entity.SpBranch));
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
					|| l.AdjustReason.Contains(c.key)
					|| l.SpBranch.Contains(c.key)
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
        public IList<BsSupplyPromotion> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.EnCode.Contains(key)
					|| l.SpBeginDate.Contains(key)
					|| l.SpEndDate.Contains(key)
					|| l.AdjustReason.Contains(key)
					|| l.SpBranch.Contains(key)
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



