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
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public class BaPoolDetailService:IBaPoolDetailService
    {

        public IRepositoryGUID<BaPoolDetail> EntityRepository { get; set; }

        [Transaction]
        public string Create(BaPoolDetail entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public BaPoolDetail GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<BaPoolDetail> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(BaPoolDetail entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(BaPoolDetail entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<BaPoolDetail> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<BaPoolDetail> Search(SearchDtoBase<BaPoolDetail> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.AcNumber) == false)
					{
						q = q.Where(p => p.AcNumber.Contains(c.entity.AcNumber));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.RtDate) == false)
					{
						q = q.Where(p => p.RtDate.Contains(c.entity.RtDate));
					}
					 if (c.entity.SaleQty > 0)
					{
						q = q.Where(p => p.SaleQty == c.entity.SaleQty);
					}
					
					 if (c.entity.SaleMoney > 0)
					{
						q = q.Where(p => p.SaleMoney == c.entity.SaleMoney);
					}
					
					 if (c.entity.PoolRate > 0)
					{
						q = q.Where(p => p.PoolRate == c.entity.PoolRate);
					}
					
					 if (c.entity.PayableMoney > 0)
					{
						q = q.Where(p => p.PayableMoney == c.entity.PayableMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.IfPromotion) == false)
					{
						q = q.Where(p => p.IfPromotion.Contains(c.entity.IfPromotion));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.AcNumber.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.RtDate.Contains(c.key)
					|| l.IfPromotion.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<BaPoolDetail> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.AcNumber.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.RtDate.Contains(key)
					|| l.IfPromotion.Contains(key)
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




