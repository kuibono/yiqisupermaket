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
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public class FbAdjustPurchasepriceGoodsService:IFbAdjustPurchasepriceGoodsService
    {

        public IRepositoryGUID<FbAdjustPurchasepriceGoods> EntityRepository { get; set; }

        [Transaction]
        public string Create(FbAdjustPurchasepriceGoods entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public FbAdjustPurchasepriceGoods GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<FbAdjustPurchasepriceGoods> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(FbAdjustPurchasepriceGoods entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(FbAdjustPurchasepriceGoods entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<FbAdjustPurchasepriceGoods> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<FbAdjustPurchasepriceGoods> Search(SearchDtoBase<FbAdjustPurchasepriceGoods> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id==c.entity.Id);
                }
					if (string.IsNullOrEmpty(c.entity.AdjustNumber) == false)
					{
						q = q.Where(p => p.AdjustNumber==c.entity.AdjustNumber);
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.SupCode) == false)
					{
						q = q.Where(p => p.SupCode.Contains(c.entity.SupCode));
					}
					 if (c.entity.InputTax > 0)
					{
						q = q.Where(p => p.InputTax == c.entity.InputTax);
					}
					
					 if (c.entity.PurchasePriceOld > 0)
					{
						q = q.Where(p => p.PurchasePriceOld == c.entity.PurchasePriceOld);
					}
					
					 if (c.entity.NontaxPurchasePriceOld > 0)
					{
						q = q.Where(p => p.NontaxPurchasePriceOld == c.entity.NontaxPurchasePriceOld);
					}
					
					 if (c.entity.PurchasePrice > 0)
					{
						q = q.Where(p => p.PurchasePrice == c.entity.PurchasePrice);
					}
					
					 if (c.entity.NontaxPurchasePrice > 0)
					{
						q = q.Where(p => p.NontaxPurchasePrice == c.entity.NontaxPurchasePrice);
					}
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.AdjustNumber.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.SupCode.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<FbAdjustPurchasepriceGoods> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.AdjustNumber.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.SupCode.Contains(key)
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




