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
    public class BsSupplyPresentPromotionGoodsService:IBsSupplyPresentPromotionGoodsService
    {

        public IRepositoryGUID<BsSupplyPresentPromotionGoods> EntityRepository { get; set; }

        [Transaction]
        public string Create(BsSupplyPresentPromotionGoods entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public BsSupplyPresentPromotionGoods GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<BsSupplyPresentPromotionGoods> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(BsSupplyPresentPromotionGoods entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(BsSupplyPresentPromotionGoods entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<BsSupplyPresentPromotionGoods> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<BsSupplyPresentPromotionGoods> Search(SearchDtoBase<BsSupplyPresentPromotionGoods> c)
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
					if (string.IsNullOrEmpty(c.entity.GoodsBarCode) == false)
					{
						q = q.Where(p => p.GoodsBarCode.Contains(c.entity.GoodsBarCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					 if (c.entity.SupplyQty > 0)
					{
						q = q.Where(p => p.SupplyQty == c.entity.SupplyQty);
					}
					
					 if (c.entity.SupplyPrice > 0)
					{
						q = q.Where(p => p.SupplyPrice == c.entity.SupplyPrice);
					}
					
					if (string.IsNullOrEmpty(c.entity.GoodsBarCodePresent) == false)
					{
						q = q.Where(p => p.GoodsBarCodePresent.Contains(c.entity.GoodsBarCodePresent));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCodePresent) == false)
					{
						q = q.Where(p => p.GoodsCodePresent.Contains(c.entity.GoodsCodePresent));
					}
					 if (c.entity.PresentQty > 0)
					{
						q = q.Where(p => p.PresentQty == c.entity.PresentQty);
					}
					
					 if (c.entity.PresentMoney > 0)
					{
						q = q.Where(p => p.PresentMoney == c.entity.PresentMoney);
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
					|| l.GoodsBarCode.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.GoodsBarCodePresent.Contains(c.key)
					|| l.GoodsCodePresent.Contains(c.key)
					|| l.SysGuid.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<BsSupplyPresentPromotionGoods> Search(string key, int pageSize = 20, int pageIndex = 1)
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
					|| l.GoodsBarCode.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.GoodsBarCodePresent.Contains(key)
					|| l.GoodsCodePresent.Contains(key)
					|| l.SysGuid.Contains(key)
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




