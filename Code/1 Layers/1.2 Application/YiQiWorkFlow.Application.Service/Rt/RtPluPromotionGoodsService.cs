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
    public class RtPluPromotionGoodsService:IRtPluPromotionGoodsService
    {

        public IRepositoryGUID<RtPluPromotionGoods> EntityRepository { get; set; }

        [Transaction]
        public string Create(RtPluPromotionGoods entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public RtPluPromotionGoods GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<RtPluPromotionGoods> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(RtPluPromotionGoods entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(RtPluPromotionGoods entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<RtPluPromotionGoods> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<RtPluPromotionGoods> Search(SearchDtoBase<RtPluPromotionGoods> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.SpNumber) == false)
					{
						
						q = q.Where(p => p.SpNumber.Contains(c.entity.SpNumber));
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
					if (string.IsNullOrEmpty(c.entity.GoodsBarCode) == false)
					{
						
						q = q.Where(p => p.GoodsBarCode.Contains(c.entity.GoodsBarCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.IfSalePrice) == false)
					{
						
						q = q.Where(p => p.IfSalePrice.Contains(c.entity.IfSalePrice));
					}
					 if (c.entity.SalePriceOld > 0)
					{
						q = q.Where(p => p.SalePriceOld == c.entity.SalePriceOld);
					}
					
					 if (c.entity.SalePriceDiscount > 0)
					{
						q = q.Where(p => p.SalePriceDiscount == c.entity.SalePriceDiscount);
					}
					
					 if (c.entity.SalePrice > 0)
					{
						q = q.Where(p => p.SalePrice == c.entity.SalePrice);
					}
					
					if (string.IsNullOrEmpty(c.entity.IfLimit) == false)
					{
						
						q = q.Where(p => p.IfLimit.Contains(c.entity.IfLimit));
					}
					 if (c.entity.TotalLimit > 0)
					{
						q = q.Where(p => p.TotalLimit == c.entity.TotalLimit);
					}
					
					 if (c.entity.TotalLimitSale > 0)
					{
						q = q.Where(p => p.TotalLimitSale == c.entity.TotalLimitSale);
					}
					
					 if (c.entity.DayLimit > 0)
					{
						q = q.Where(p => p.DayLimit == c.entity.DayLimit);
					}
					
					 if (c.entity.DayLimitSale > 0)
					{
						q = q.Where(p => p.DayLimitSale == c.entity.DayLimitSale);
					}
					
					 if (c.entity.SheetLimit > 0)
					{
						q = q.Where(p => p.SheetLimit == c.entity.SheetLimit);
					}
					
					if (string.IsNullOrEmpty(c.entity.IfPool) == false)
					{
						
						q = q.Where(p => p.IfPool.Contains(c.entity.IfPool));
					}
					 if (c.entity.PoolRateOld > 0)
					{
						q = q.Where(p => p.PoolRateOld == c.entity.PoolRateOld);
					}
					
					 if (c.entity.PoolRate > 0)
					{
						q = q.Where(p => p.PoolRate == c.entity.PoolRate);
					}
					
					if (string.IsNullOrEmpty(c.entity.IfVip) == false)
					{
						
						q = q.Where(p => p.IfVip.Contains(c.entity.IfVip));
					}
					 if (c.entity.VipPriceOld > 0)
					{
						q = q.Where(p => p.VipPriceOld == c.entity.VipPriceOld);
					}
					
					 if (c.entity.VipPrice > 0)
					{
						q = q.Where(p => p.VipPrice == c.entity.VipPrice);
					}
					
					 if (c.entity.VipSheetLimit > 0)
					{
						q = q.Where(p => p.VipSheetLimit == c.entity.VipSheetLimit);
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
					|| l.SpNumber.Contains(c.key)
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
					|| l.GoodsBarCode.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.IfSalePrice.Contains(c.key)
					|| l.IfLimit.Contains(c.key)
					|| l.IfPool.Contains(c.key)
					|| l.IfVip.Contains(c.key)
					|| l.SysGuid.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<RtPluPromotionGoods> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.SpNumber.Contains(key)
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
					|| l.GoodsBarCode.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.IfSalePrice.Contains(key)
					|| l.IfLimit.Contains(key)
					|| l.IfPool.Contains(key)
					|| l.IfVip.Contains(key)
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




