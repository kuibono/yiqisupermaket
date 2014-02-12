/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:06
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public class BsSupplyDetailService:IBsSupplyDetailService
    {

        public IRepositoryGUID<BsSupplyDetail> EntityRepository { get; set; }

        [Transaction]
        public string Create(BsSupplyDetail entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public BsSupplyDetail GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<BsSupplyDetail> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(BsSupplyDetail entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(BsSupplyDetail entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<BsSupplyDetail> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<BsSupplyDetail> Search(SearchDtoBase<BsSupplyDetail> c)
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
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					if (string.IsNullOrEmpty(c.entity.bCode) == false)
					{
						
						q = q.Where(p => p.bCode.Contains(c.entity.bCode));
					}
					if (string.IsNullOrEmpty(c.entity.SpState) == false)
					{
						
						q = q.Where(p => p.SpState.Contains(c.entity.SpState));
					}
					if (string.IsNullOrEmpty(c.entity.WhCodeOut) == false)
					{
						
						q = q.Where(p => p.WhCodeOut.Contains(c.entity.WhCodeOut));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsBarCode) == false)
					{
						
						q = q.Where(p => p.GoodsBarCode.Contains(c.entity.GoodsBarCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.Specification) == false)
					{
						
						q = q.Where(p => p.Specification.Contains(c.entity.Specification));
					}
					if (string.IsNullOrEmpty(c.entity.PackUnitCode) == false)
					{
						
						q = q.Where(p => p.PackUnitCode.Contains(c.entity.PackUnitCode));
					}
					 if (c.entity.PurchasePackQty > 0)
					{
						q = q.Where(p => p.PurchasePackQty == c.entity.PurchasePackQty);
					}
					
					 if (c.entity.SupplyPackQty > 0)
					{
						q = q.Where(p => p.SupplyPackQty == c.entity.SupplyPackQty);
					}
					
					 if (c.entity.PutinPackQty > 0)
					{
						q = q.Where(p => p.PutinPackQty == c.entity.PutinPackQty);
					}
					
					 if (c.entity.PackCoef > 0)
					{
						q = q.Where(p => p.PackCoef == c.entity.PackCoef);
					}
					
					 if (c.entity.PurchaseQty > 0)
					{
						q = q.Where(p => p.PurchaseQty == c.entity.PurchaseQty);
					}
					
					 if (c.entity.SupplyQty > 0)
					{
						q = q.Where(p => p.SupplyQty == c.entity.SupplyQty);
					}
					
					 if (c.entity.PutinQty > 0)
					{
						q = q.Where(p => p.PutinQty == c.entity.PutinQty);
					}
					
					 if (c.entity.SupplyPrice > 0)
					{
						q = q.Where(p => p.SupplyPrice == c.entity.SupplyPrice);
					}
					
					 if (c.entity.SupplyMoney > 0)
					{
						q = q.Where(p => p.SupplyMoney == c.entity.SupplyMoney);
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
					|| l.WhCode.Contains(c.key)
					|| l.bCode.Contains(c.key)
					|| l.SpState.Contains(c.key)
					|| l.WhCodeOut.Contains(c.key)
					|| l.GoodsBarCode.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.Specification.Contains(c.key)
					|| l.PackUnitCode.Contains(c.key)
					|| l.SysGuid.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<BsSupplyDetail> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.SpNumber.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.bCode.Contains(key)
					|| l.SpState.Contains(key)
					|| l.WhCodeOut.Contains(key)
					|| l.GoodsBarCode.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.Specification.Contains(key)
					|| l.PackUnitCode.Contains(key)
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




