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
using YiQiWorkFlow.Domain.Pc;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Pc
{
    public class PcPutoutDetailService:IPcPutoutDetailService
    {

        public IRepositoryGUID<PcPutoutDetail> EntityRepository { get; set; }

        [Transaction]
        public string Create(PcPutoutDetail entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public PcPutoutDetail GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<PcPutoutDetail> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(PcPutoutDetail entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(PcPutoutDetail entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<PcPutoutDetail> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<PcPutoutDetail> Search(SearchDtoBase<PcPutoutDetail> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.PoNumber) == false)
					{
						q = q.Where(p => p.PoNumber.Contains(c.entity.PoNumber));
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
					
					 if (c.entity.ReturnQty > 0)
					{
						q = q.Where(p => p.ReturnQty == c.entity.ReturnQty);
					}
					
					 if (c.entity.SalePrice > 0)
					{
						q = q.Where(p => p.SalePrice == c.entity.SalePrice);
					}
					
					 if (c.entity.PurchasePrice > 0)
					{
						q = q.Where(p => p.PurchasePrice == c.entity.PurchasePrice);
					}
					
					 if (c.entity.NontaxPurchasePrice > 0)
					{
						q = q.Where(p => p.NontaxPurchasePrice == c.entity.NontaxPurchasePrice);
					}
					
					 if (c.entity.ReturnMoney > 0)
					{
						q = q.Where(p => p.ReturnMoney == c.entity.ReturnMoney);
					}
					
					 if (c.entity.NontaxReturnMoney > 0)
					{
						q = q.Where(p => p.NontaxReturnMoney == c.entity.NontaxReturnMoney);
					}
					
					 if (c.entity.SaleMoney > 0)
					{
						q = q.Where(p => p.SaleMoney == c.entity.SaleMoney);
					}
					
					 if (c.entity.NontaxSaleMoney > 0)
					{
						q = q.Where(p => p.NontaxSaleMoney == c.entity.NontaxSaleMoney);
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
					|| l.PoNumber.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.GoodsBarCode.Contains(c.key)
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
        public IList<PcPutoutDetail> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.PoNumber.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.GoodsBarCode.Contains(key)
					|| l.Specification.Contains(key)
					|| l.PackUnitCode.Contains(key)
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




