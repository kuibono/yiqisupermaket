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
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public class OpAdjustPurchaseDetailService:IOpAdjustPurchaseDetailService
    {

        public IRepositoryGUID<OpAdjustPurchaseDetail> EntityRepository { get; set; }

        [Transaction]
        public string Create(OpAdjustPurchaseDetail entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public OpAdjustPurchaseDetail GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<OpAdjustPurchaseDetail> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(OpAdjustPurchaseDetail entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(OpAdjustPurchaseDetail entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<OpAdjustPurchaseDetail> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<OpAdjustPurchaseDetail> Search(SearchDtoBase<OpAdjustPurchaseDetail> c)
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
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					 if (c.entity.BatchNumber > 0)
					{
						q = q.Where(p => p.BatchNumber == c.entity.BatchNumber);
					}
					
					if (string.IsNullOrEmpty(c.entity.PiNumber) == false)
					{
						q = q.Where(p => p.PiNumber.Contains(c.entity.PiNumber));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsBarCode) == false)
					{
						q = q.Where(p => p.GoodsBarCode.Contains(c.entity.GoodsBarCode));
					}
					if (string.IsNullOrEmpty(c.entity.SupCode) == false)
					{
						q = q.Where(p => p.SupCode.Contains(c.entity.SupCode));
					}
					 if (c.entity.InputTax > 0)
					{
						q = q.Where(p => p.InputTax == c.entity.InputTax);
					}
					
					 if (c.entity.PurchasePrice > 0)
					{
						q = q.Where(p => p.PurchasePrice == c.entity.PurchasePrice);
					}
					
					 if (c.entity.NontaxPurchasePrice > 0)
					{
						q = q.Where(p => p.NontaxPurchasePrice == c.entity.NontaxPurchasePrice);
					}
					
					 if (c.entity.SalePrice > 0)
					{
						q = q.Where(p => p.SalePrice == c.entity.SalePrice);
					}
					
					 if (c.entity.NontaxSalePrice > 0)
					{
						q = q.Where(p => p.NontaxSalePrice == c.entity.NontaxSalePrice);
					}
					
					 if (c.entity.PurchaseQty > 0)
					{
						q = q.Where(p => p.PurchaseQty == c.entity.PurchaseQty);
					}
					
					 if (c.entity.StockoutQty > 0)
					{
						q = q.Where(p => p.StockoutQty == c.entity.StockoutQty);
					}
					
					 if (c.entity.StockQty > 0)
					{
						q = q.Where(p => p.StockQty == c.entity.StockQty);
					}
					
					 if (c.entity.AdjustQty > 0)
					{
						q = q.Where(p => p.AdjustQty == c.entity.AdjustQty);
					}
					
					 if (c.entity.AdjustPrice > 0)
					{
						q = q.Where(p => p.AdjustPrice == c.entity.AdjustPrice);
					}
					
					 if (c.entity.AdjustDiff > 0)
					{
						q = q.Where(p => p.AdjustDiff == c.entity.AdjustDiff);
					}
					
					 if (c.entity.AdjustMoney > 0)
					{
						q = q.Where(p => p.AdjustMoney == c.entity.AdjustMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.IfAblebalance) == false)
					{
						q = q.Where(p => p.IfAblebalance.Contains(c.entity.IfAblebalance));
					}
					 if (c.entity.AdjustBaMoney > 0)
					{
						q = q.Where(p => p.AdjustBaMoney == c.entity.AdjustBaMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.IfBalance) == false)
					{
						q = q.Where(p => p.IfBalance.Contains(c.entity.IfBalance));
					}
					if (string.IsNullOrEmpty(c.entity.BaNumber) == false)
					{
						q = q.Where(p => p.BaNumber.Contains(c.entity.BaNumber));
					}
					 if (c.entity.BaMoney > 0)
					{
						q = q.Where(p => p.BaMoney == c.entity.BaMoney);
					}
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.AdjustNumber.Contains(c.key)
					|| l.WhCode.Contains(c.key)
					|| l.PiNumber.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.GoodsBarCode.Contains(c.key)
					|| l.SupCode.Contains(c.key)
					|| l.IfAblebalance.Contains(c.key)
					|| l.IfBalance.Contains(c.key)
					|| l.BaNumber.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<OpAdjustPurchaseDetail> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.AdjustNumber.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.PiNumber.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.GoodsBarCode.Contains(key)
					|| l.SupCode.Contains(key)
					|| l.IfAblebalance.Contains(key)
					|| l.IfBalance.Contains(key)
					|| l.BaNumber.Contains(key)
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




