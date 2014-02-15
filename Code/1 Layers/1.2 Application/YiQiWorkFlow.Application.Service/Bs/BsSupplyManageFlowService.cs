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
    public class BsSupplyManageFlowService:IBsSupplyManageFlowService
    {

        public IRepository<BsSupplyManageFlow> EntityRepository { get; set; }

        [Transaction]
        public int Create(BsSupplyManageFlow entity)
        {
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public BsSupplyManageFlow GetById(int id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<BsSupplyManageFlow> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(BsSupplyManageFlow entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(BsSupplyManageFlow entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<BsSupplyManageFlow> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<BsSupplyManageFlow> Search(SearchDtoBase<BsSupplyManageFlow> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
					if (string.IsNullOrEmpty(c.entity.bCode) == false)
					{
						q = q.Where(p => p.bCode.Contains(c.entity.bCode));
					}
					if (string.IsNullOrEmpty(c.entity.EnCode) == false)
					{
						q = q.Where(p => p.EnCode.Contains(c.entity.EnCode));
					}
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					if (string.IsNullOrEmpty(c.entity.WhCodeOut) == false)
					{
						q = q.Where(p => p.WhCodeOut.Contains(c.entity.WhCodeOut));
					}
					if (string.IsNullOrEmpty(c.entity.SpType) == false)
					{
						q = q.Where(p => p.SpType.Contains(c.entity.SpType));
					}
					if (string.IsNullOrEmpty(c.entity.SpState) == false)
					{
						q = q.Where(p => p.SpState.Contains(c.entity.SpState));
					}
					 if (c.entity.SupplyMoney > 0)
					{
						q = q.Where(p => p.SupplyMoney == c.entity.SupplyMoney);
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
					
					if (string.IsNullOrEmpty(c.entity.Operator) == false)
					{
						q = q.Where(p => p.Operator.Contains(c.entity.Operator));
					}
					if (string.IsNullOrEmpty(c.entity.PurchaseAssessor) == false)
					{
						q = q.Where(p => p.PurchaseAssessor.Contains(c.entity.PurchaseAssessor));
					}
					if (string.IsNullOrEmpty(c.entity.PurchaseIfExamine) == false)
					{
						q = q.Where(p => p.PurchaseIfExamine.Contains(c.entity.PurchaseIfExamine));
					}
					if (string.IsNullOrEmpty(c.entity.SupplyAssessor) == false)
					{
						q = q.Where(p => p.SupplyAssessor.Contains(c.entity.SupplyAssessor));
					}
					if (string.IsNullOrEmpty(c.entity.SupplyIfExamine) == false)
					{
						q = q.Where(p => p.SupplyIfExamine.Contains(c.entity.SupplyIfExamine));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.bCode.Contains(c.key)
					|| l.EnCode.Contains(c.key)
					|| l.WhCode.Contains(c.key)
					|| l.WhCodeOut.Contains(c.key)
					|| l.SpType.Contains(c.key)
					|| l.SpState.Contains(c.key)
					|| l.IfBalance.Contains(c.key)
					|| l.BaNumber.Contains(c.key)
					|| l.Operator.Contains(c.key)
					|| l.PurchaseAssessor.Contains(c.key)
					|| l.PurchaseIfExamine.Contains(c.key)
					|| l.SupplyAssessor.Contains(c.key)
					|| l.SupplyIfExamine.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<BsSupplyManageFlow> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.bCode.Contains(key)
					|| l.EnCode.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.WhCodeOut.Contains(key)
					|| l.SpType.Contains(key)
					|| l.SpState.Contains(key)
					|| l.IfBalance.Contains(key)
					|| l.BaNumber.Contains(key)
					|| l.Operator.Contains(key)
					|| l.PurchaseAssessor.Contains(key)
					|| l.PurchaseIfExamine.Contains(key)
					|| l.SupplyAssessor.Contains(key)
					|| l.SupplyIfExamine.Contains(key)
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




