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
    public class OpSplitComManageFlowService:IOpSplitComManageFlowService
    {

        public IRepository<OpSplitComManageFlow> EntityRepository { get; set; }

        [Transaction]
        public int Create(OpSplitComManageFlow entity)
        {
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public OpSplitComManageFlow GetById(int id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<OpSplitComManageFlow> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(OpSplitComManageFlow entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(OpSplitComManageFlow entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<OpSplitComManageFlow> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<OpSplitComManageFlow> Search(SearchDtoBase<OpSplitComManageFlow> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
					if (string.IsNullOrEmpty(c.entity.ScType) == false)
					{
						q = q.Where(p => p.ScType.Contains(c.entity.ScType));
					}
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					 if (c.entity.PurchaseQty > 0)
					{
						q = q.Where(p => p.PurchaseQty == c.entity.PurchaseQty);
					}
					
					 if (c.entity.PurchaseMoney > 0)
					{
						q = q.Where(p => p.PurchaseMoney == c.entity.PurchaseMoney);
					}
					
					 if (c.entity.NontaxPurchaseMoney > 0)
					{
						q = q.Where(p => p.NontaxPurchaseMoney == c.entity.NontaxPurchaseMoney);
					}
					
					 if (c.entity.SalePrice > 0)
					{
						q = q.Where(p => p.SalePrice == c.entity.SalePrice);
					}
					
					 if (c.entity.SaleMoney > 0)
					{
						q = q.Where(p => p.SaleMoney == c.entity.SaleMoney);
					}
					
					 if (c.entity.NontaxSaleMoney > 0)
					{
						q = q.Where(p => p.NontaxSaleMoney == c.entity.NontaxSaleMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.Operator) == false)
					{
						q = q.Where(p => p.Operator.Contains(c.entity.Operator));
					}
					if (string.IsNullOrEmpty(c.entity.Assessor) == false)
					{
						q = q.Where(p => p.Assessor.Contains(c.entity.Assessor));
					}
					if (string.IsNullOrEmpty(c.entity.IfExamine) == false)
					{
						q = q.Where(p => p.IfExamine.Contains(c.entity.IfExamine));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.ScType.Contains(c.key)
					|| l.WhCode.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.Operator.Contains(c.key)
					|| l.Assessor.Contains(c.key)
					|| l.IfExamine.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<OpSplitComManageFlow> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.ScType.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.Operator.Contains(key)
					|| l.Assessor.Contains(key)
					|| l.IfExamine.Contains(key)
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




