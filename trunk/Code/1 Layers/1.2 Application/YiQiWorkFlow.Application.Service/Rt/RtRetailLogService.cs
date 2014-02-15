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
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public class RtRetailLogService:IRtRetailLogService
    {

        public IRepository<RtRetailLog> EntityRepository { get; set; }

        [Transaction]
        public int Create(RtRetailLog entity)
        {
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public RtRetailLog GetById(int id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<RtRetailLog> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(RtRetailLog entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(RtRetailLog entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<RtRetailLog> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<RtRetailLog> Search(SearchDtoBase<RtRetailLog> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
					if (string.IsNullOrEmpty(c.entity.Cashier) == false)
					{
						q = q.Where(p => p.Cashier.Contains(c.entity.Cashier));
					}
					if (string.IsNullOrEmpty(c.entity.EmName) == false)
					{
						q = q.Where(p => p.EmName.Contains(c.entity.EmName));
					}
					if (string.IsNullOrEmpty(c.entity.OperatType) == false)
					{
						q = q.Where(p => p.OperatType.Contains(c.entity.OperatType));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsBarCode) == false)
					{
						q = q.Where(p => p.GoodsBarCode.Contains(c.entity.GoodsBarCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsBarName) == false)
					{
						q = q.Where(p => p.GoodsBarName.Contains(c.entity.GoodsBarName));
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
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.Cashier.Contains(c.key)
					|| l.EmName.Contains(c.key)
					|| l.OperatType.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.GoodsBarCode.Contains(c.key)
					|| l.GoodsBarName.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<RtRetailLog> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.Cashier.Contains(key)
					|| l.EmName.Contains(key)
					|| l.OperatType.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.GoodsBarCode.Contains(key)
					|| l.GoodsBarName.Contains(key)
                    select l;
					
                
            }
            q = q.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            var result = q.ToList();
            return result.ToList();
        }

        [Transaction]
        public void Delete(IList<string> ids)
        {
			var int_ids = ids.ToList().Select(p => { return Convert.ToInt32(p); }).ToList();
            var q = EntityRepository.LinqQuery.Where(p => int_ids.Contains(p.Id));
            foreach (var each in q)
            {
                Delete(each);
            }
        }
    }
}




