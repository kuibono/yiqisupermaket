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
    public class RtRetailManageService:IRtRetailManageService
    {

        public IRepository<RtRetailManage> EntityRepository { get; set; }

        [Transaction]
        public int Create(RtRetailManage entity)
        {
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public RtRetailManage GetById(int id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<RtRetailManage> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(RtRetailManage entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(RtRetailManage entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<RtRetailManage> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<RtRetailManage> Search(SearchDtoBase<RtRetailManage> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
					if (string.IsNullOrEmpty(c.entity.RtType) == false)
					{
						q = q.Where(p => p.RtType.Contains(c.entity.RtType));
					}
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					if (string.IsNullOrEmpty(c.entity.Posid) == false)
					{
						q = q.Where(p => p.Posid.Contains(c.entity.Posid));
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
					
					if (string.IsNullOrEmpty(c.entity.CardNumber) == false)
					{
						q = q.Where(p => p.CardNumber.Contains(c.entity.CardNumber));
					}
					if (string.IsNullOrEmpty(c.entity.Cashier) == false)
					{
						q = q.Where(p => p.Cashier.Contains(c.entity.Cashier));
					}
					if (string.IsNullOrEmpty(c.entity.CashierHigher) == false)
					{
						q = q.Where(p => p.CashierHigher.Contains(c.entity.CashierHigher));
					}
					if (string.IsNullOrEmpty(c.entity.Salesman) == false)
					{
						q = q.Where(p => p.Salesman.Contains(c.entity.Salesman));
					}
					if (string.IsNullOrEmpty(c.entity.UnderCounterCode) == false)
					{
						q = q.Where(p => p.UnderCounterCode.Contains(c.entity.UnderCounterCode));
					}
					if (string.IsNullOrEmpty(c.entity.ReturnNumber) == false)
					{
						q = q.Where(p => p.ReturnNumber.Contains(c.entity.ReturnNumber));
					}
					if (string.IsNullOrEmpty(c.entity.Comment) == false)
					{
						q = q.Where(p => p.Comment.Contains(c.entity.Comment));
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
					1==0
					|| l.RtType.Contains(c.key)
					|| l.WhCode.Contains(c.key)
					|| l.Posid.Contains(c.key)
					|| l.CardNumber.Contains(c.key)
					|| l.Cashier.Contains(c.key)
					|| l.CashierHigher.Contains(c.key)
					|| l.Salesman.Contains(c.key)
					|| l.UnderCounterCode.Contains(c.key)
					|| l.ReturnNumber.Contains(c.key)
					|| l.Comment.Contains(c.key)
					|| l.SysGuid.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<RtRetailManage> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.RtType.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.Posid.Contains(key)
					|| l.CardNumber.Contains(key)
					|| l.Cashier.Contains(key)
					|| l.CashierHigher.Contains(key)
					|| l.Salesman.Contains(key)
					|| l.UnderCounterCode.Contains(key)
					|| l.ReturnNumber.Contains(key)
					|| l.Comment.Contains(key)
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
			var int_ids = ids.ToList().Select(p => { return Convert.ToInt32(p); }).ToList();
            var q = EntityRepository.LinqQuery.Where(p => int_ids.Contains(p.Id));
            foreach (var each in q)
            {
                Delete(each);
            }
        }
    }
}




