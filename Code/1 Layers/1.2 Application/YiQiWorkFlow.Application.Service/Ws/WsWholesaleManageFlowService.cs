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
using YiQiWorkFlow.Domain.Ws;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ws
{
    public class WsWholesaleManageFlowService:IWsWholesaleManageFlowService
    {

        public IRepository<WsWholesaleManageFlow> EntityRepository { get; set; }

        [Transaction]
        public int Create(WsWholesaleManageFlow entity)
        {
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public WsWholesaleManageFlow GetById(int id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<WsWholesaleManageFlow> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(WsWholesaleManageFlow entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(WsWholesaleManageFlow entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<WsWholesaleManageFlow> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<WsWholesaleManageFlow> Search(SearchDtoBase<WsWholesaleManageFlow> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
					if (string.IsNullOrEmpty(c.entity.WsNumber) == false)
					{
						q = q.Where(p => p.WsNumber.Contains(c.entity.WsNumber));
					}
					if (string.IsNullOrEmpty(c.entity.OrderNumber) == false)
					{
						q = q.Where(p => p.OrderNumber.Contains(c.entity.OrderNumber));
					}
					if (string.IsNullOrEmpty(c.entity.CustCode) == false)
					{
						q = q.Where(p => p.CustCode.Contains(c.entity.CustCode));
					}
					if (string.IsNullOrEmpty(c.entity.WsType) == false)
					{
						q = q.Where(p => p.WsType.Contains(c.entity.WsType));
					}
					if (string.IsNullOrEmpty(c.entity.WsOrgan) == false)
					{
						q = q.Where(p => p.WsOrgan.Contains(c.entity.WsOrgan));
					}
					if (string.IsNullOrEmpty(c.entity.PayMode) == false)
					{
						q = q.Where(p => p.PayMode.Contains(c.entity.PayMode));
					}
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					if (string.IsNullOrEmpty(c.entity.Salesman) == false)
					{
						q = q.Where(p => p.Salesman.Contains(c.entity.Salesman));
					}
					if (string.IsNullOrEmpty(c.entity.Comment) == false)
					{
						q = q.Where(p => p.Comment.Contains(c.entity.Comment));
					}
					 if (c.entity.WsMoney > 0)
					{
						q = q.Where(p => p.WsMoney == c.entity.WsMoney);
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
					|| l.WsNumber.Contains(c.key)
					|| l.OrderNumber.Contains(c.key)
					|| l.CustCode.Contains(c.key)
					|| l.WsType.Contains(c.key)
					|| l.WsOrgan.Contains(c.key)
					|| l.PayMode.Contains(c.key)
					|| l.WhCode.Contains(c.key)
					|| l.Salesman.Contains(c.key)
					|| l.Comment.Contains(c.key)
					|| l.IfBalance.Contains(c.key)
					|| l.BaNumber.Contains(c.key)
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
        public IList<WsWholesaleManageFlow> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.WsNumber.Contains(key)
					|| l.OrderNumber.Contains(key)
					|| l.CustCode.Contains(key)
					|| l.WsType.Contains(key)
					|| l.WsOrgan.Contains(key)
					|| l.PayMode.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.Salesman.Contains(key)
					|| l.Comment.Contains(key)
					|| l.IfBalance.Contains(key)
					|| l.BaNumber.Contains(key)
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




