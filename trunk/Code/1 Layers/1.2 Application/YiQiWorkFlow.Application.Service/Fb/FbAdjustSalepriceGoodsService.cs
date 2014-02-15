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
    public class FbAdjustSalepriceGoodsService:IFbAdjustSalepriceGoodsService
    {

        public IRepositoryGUID<FbAdjustSalepriceGoods> EntityRepository { get; set; }

        [Transaction]
        public string Create(FbAdjustSalepriceGoods entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public FbAdjustSalepriceGoods GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<FbAdjustSalepriceGoods> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(FbAdjustSalepriceGoods entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(FbAdjustSalepriceGoods entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<FbAdjustSalepriceGoods> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<FbAdjustSalepriceGoods> Search(SearchDtoBase<FbAdjustSalepriceGoods> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.AdjustNumber) == false)
					{
						q = q.Where(p => p.AdjustNumber.Contains(c.entity.AdjustNumber));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsBarCode) == false)
					{
						q = q.Where(p => p.GoodsBarCode.Contains(c.entity.GoodsBarCode));
					}
					 if (c.entity.SalePriceOld > 0)
					{
						q = q.Where(p => p.SalePriceOld == c.entity.SalePriceOld);
					}
					
					 if (c.entity.SalePrice > 0)
					{
						q = q.Where(p => p.SalePrice == c.entity.SalePrice);
					}
					
					 if (c.entity.VipPriceOld > 0)
					{
						q = q.Where(p => p.VipPriceOld == c.entity.VipPriceOld);
					}
					
					 if (c.entity.VipPrice > 0)
					{
						q = q.Where(p => p.VipPrice == c.entity.VipPrice);
					}
					
					 if (c.entity.TradePriceOld > 0)
					{
						q = q.Where(p => p.TradePriceOld == c.entity.TradePriceOld);
					}
					
					 if (c.entity.TradePrice > 0)
					{
						q = q.Where(p => p.TradePrice == c.entity.TradePrice);
					}
					
					 if (c.entity.StockQty > 0)
					{
						q = q.Where(p => p.StockQty == c.entity.StockQty);
					}
					
					 if (c.entity.LossMoney > 0)
					{
						q = q.Where(p => p.LossMoney == c.entity.LossMoney);
					}
					
					 if (c.entity.NontaxLossMoney > 0)
					{
						q = q.Where(p => p.NontaxLossMoney == c.entity.NontaxLossMoney);
					}
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.AdjustNumber.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.GoodsBarCode.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<FbAdjustSalepriceGoods> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.AdjustNumber.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.GoodsBarCode.Contains(key)
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




