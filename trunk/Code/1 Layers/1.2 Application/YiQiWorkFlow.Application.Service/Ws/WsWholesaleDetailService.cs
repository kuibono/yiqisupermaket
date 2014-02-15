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
using YiQiWorkFlow.Domain.Ws;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ws
{
    public class WsWholesaleDetailService:IWsWholesaleDetailService
    {

        public IRepositoryGUID<WsWholesaleDetail> EntityRepository { get; set; }

        [Transaction]
        public string Create(WsWholesaleDetail entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public WsWholesaleDetail GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<WsWholesaleDetail> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(WsWholesaleDetail entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(WsWholesaleDetail entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<WsWholesaleDetail> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<WsWholesaleDetail> Search(SearchDtoBase<WsWholesaleDetail> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.WsNumber) == false)
					{
						q = q.Where(p => p.WsNumber.Contains(c.entity.WsNumber));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsBarCode) == false)
					{
						q = q.Where(p => p.GoodsBarCode.Contains(c.entity.GoodsBarCode));
					}
					if (string.IsNullOrEmpty(c.entity.Specification) == false)
					{
						q = q.Where(p => p.Specification.Contains(c.entity.Specification));
					}
					if (string.IsNullOrEmpty(c.entity.PackUnitCode) == false)
					{
						q = q.Where(p => p.PackUnitCode.Contains(c.entity.PackUnitCode));
					}
					 if (c.entity.PackQty > 0)
					{
						q = q.Where(p => p.PackQty == c.entity.PackQty);
					}
					
					 if (c.entity.PackCoef > 0)
					{
						q = q.Where(p => p.PackCoef == c.entity.PackCoef);
					}
					
					 if (c.entity.SaleQty > 0)
					{
						q = q.Where(p => p.SaleQty == c.entity.SaleQty);
					}
					
					 if (c.entity.TradePrice > 0)
					{
						q = q.Where(p => p.TradePrice == c.entity.TradePrice);
					}
					
					 if (c.entity.SaleMoney > 0)
					{
						q = q.Where(p => p.SaleMoney == c.entity.SaleMoney);
					}
					
					 if (c.entity.DiscountMoney > 0)
					{
						q = q.Where(p => p.DiscountMoney == c.entity.DiscountMoney);
					}
					
					 if (c.entity.NontaxSalePrice > 0)
					{
						q = q.Where(p => p.NontaxSalePrice == c.entity.NontaxSalePrice);
					}
					
					 if (c.entity.NontaxSaleMoney > 0)
					{
						q = q.Where(p => p.NontaxSaleMoney == c.entity.NontaxSaleMoney);
					}
					
					 if (c.entity.CostMoney > 0)
					{
						q = q.Where(p => p.CostMoney == c.entity.CostMoney);
					}
					
					 if (c.entity.NontaxCostMoney > 0)
					{
						q = q.Where(p => p.NontaxCostMoney == c.entity.NontaxCostMoney);
					}
					
					 if (c.entity.GrossMoney > 0)
					{
						q = q.Where(p => p.GrossMoney == c.entity.GrossMoney);
					}
					
					 if (c.entity.NontaxGrossMoney > 0)
					{
						q = q.Where(p => p.NontaxGrossMoney == c.entity.NontaxGrossMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.SaleType) == false)
					{
						q = q.Where(p => p.SaleType.Contains(c.entity.SaleType));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.WsNumber.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.GoodsBarCode.Contains(c.key)
					|| l.Specification.Contains(c.key)
					|| l.PackUnitCode.Contains(c.key)
					|| l.SaleType.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<WsWholesaleDetail> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.WsNumber.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.GoodsBarCode.Contains(key)
					|| l.Specification.Contains(key)
					|| l.PackUnitCode.Contains(key)
					|| l.SaleType.Contains(key)
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




