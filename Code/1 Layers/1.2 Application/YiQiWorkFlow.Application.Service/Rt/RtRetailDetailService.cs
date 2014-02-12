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
    public class RtRetailDetailService:IRtRetailDetailService
    {

        public IRepositoryGUID<RtRetailDetail> EntityRepository { get; set; }

        [Transaction]
        public string Create(RtRetailDetail entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public RtRetailDetail GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<RtRetailDetail> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(RtRetailDetail entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(RtRetailDetail entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<RtRetailDetail> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<RtRetailDetail> Search(SearchDtoBase<RtRetailDetail> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					 if (c.entity.SaFlowNumber > 0)
					{
						q = q.Where(p => p.SaFlowNumber == c.entity.SaFlowNumber);
					}
					
					if (string.IsNullOrEmpty(c.entity.RtNumber) == false)
					{
						
						q = q.Where(p => p.RtNumber.Contains(c.entity.RtNumber));
					}
					if (string.IsNullOrEmpty(c.entity.sNumber) == false)
					{
						
						q = q.Where(p => p.sNumber.Contains(c.entity.sNumber));
					}
					if (string.IsNullOrEmpty(c.entity.RtType) == false)
					{
						
						q = q.Where(p => p.RtType.Contains(c.entity.RtType));
					}
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					if (string.IsNullOrEmpty(c.entity.bCode) == false)
					{
						
						q = q.Where(p => p.bCode.Contains(c.entity.bCode));
					}
					if (string.IsNullOrEmpty(c.entity.Posid) == false)
					{
						
						q = q.Where(p => p.Posid.Contains(c.entity.Posid));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsBarCode) == false)
					{
						
						q = q.Where(p => p.GoodsBarCode.Contains(c.entity.GoodsBarCode));
					}
					 if (c.entity.SalePrice > 0)
					{
						q = q.Where(p => p.SalePrice == c.entity.SalePrice);
					}
					
					 if (c.entity.RealPrice > 0)
					{
						q = q.Where(p => p.RealPrice == c.entity.RealPrice);
					}
					
					 if (c.entity.SaleQty > 0)
					{
						q = q.Where(p => p.SaleQty == c.entity.SaleQty);
					}
					
					 if (c.entity.SaleMoney > 0)
					{
						q = q.Where(p => p.SaleMoney == c.entity.SaleMoney);
					}
					
					 if (c.entity.DiscountMoney > 0)
					{
						q = q.Where(p => p.DiscountMoney == c.entity.DiscountMoney);
					}
					
					 if (c.entity.PurchaseQty > 0)
					{
						q = q.Where(p => p.PurchaseQty == c.entity.PurchaseQty);
					}
					
					 if (c.entity.pSalePrice > 0)
					{
						q = q.Where(p => p.pSalePrice == c.entity.pSalePrice);
					}
					
					 if (c.entity.pSaleMoney > 0)
					{
						q = q.Where(p => p.pSaleMoney == c.entity.pSaleMoney);
					}
					
					 if (c.entity.pDiscountMoney > 0)
					{
						q = q.Where(p => p.pDiscountMoney == c.entity.pDiscountMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.Cashier) == false)
					{
						
						q = q.Where(p => p.Cashier.Contains(c.entity.Cashier));
					}
					if (string.IsNullOrEmpty(c.entity.Salesman) == false)
					{
						
						q = q.Where(p => p.Salesman.Contains(c.entity.Salesman));
					}
					if (string.IsNullOrEmpty(c.entity.UnderCounterCode) == false)
					{
						
						q = q.Where(p => p.UnderCounterCode.Contains(c.entity.UnderCounterCode));
					}
					 if (c.entity.PoolRate > 0)
					{
						q = q.Where(p => p.PoolRate == c.entity.PoolRate);
					}
					
					if (string.IsNullOrEmpty(c.entity.IfPromotion) == false)
					{
						
						q = q.Where(p => p.IfPromotion.Contains(c.entity.IfPromotion));
					}
					if (string.IsNullOrEmpty(c.entity.OwnerType) == false)
					{
						
						q = q.Where(p => p.OwnerType.Contains(c.entity.OwnerType));
					}
					if (string.IsNullOrEmpty(c.entity.SysGuid) == false)
					{
						
						q = q.Where(p => p.SysGuid.Contains(c.entity.SysGuid));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.RtNumber.Contains(c.key)
					|| l.sNumber.Contains(c.key)
					|| l.RtType.Contains(c.key)
					|| l.WhCode.Contains(c.key)
					|| l.bCode.Contains(c.key)
					|| l.Posid.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.GoodsBarCode.Contains(c.key)
					|| l.Cashier.Contains(c.key)
					|| l.Salesman.Contains(c.key)
					|| l.UnderCounterCode.Contains(c.key)
					|| l.IfPromotion.Contains(c.key)
					|| l.OwnerType.Contains(c.key)
					|| l.SysGuid.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<RtRetailDetail> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.RtNumber.Contains(key)
					|| l.sNumber.Contains(key)
					|| l.RtType.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.bCode.Contains(key)
					|| l.Posid.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.GoodsBarCode.Contains(key)
					|| l.Cashier.Contains(key)
					|| l.Salesman.Contains(key)
					|| l.UnderCounterCode.Contains(key)
					|| l.IfPromotion.Contains(key)
					|| l.OwnerType.Contains(key)
					|| l.SysGuid.Contains(key)
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




