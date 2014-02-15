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
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public class BaBranchDetailService:IBaBranchDetailService
    {

        public IRepositoryGUID<BaBranchDetail> EntityRepository { get; set; }

        [Transaction]
        public string Create(BaBranchDetail entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public BaBranchDetail GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<BaBranchDetail> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(BaBranchDetail entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(BaBranchDetail entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<BaBranchDetail> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<BaBranchDetail> Search(SearchDtoBase<BaBranchDetail> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.BaNumber) == false)
					{
						q = q.Where(p => p.BaNumber.Contains(c.entity.BaNumber));
					}
					if (string.IsNullOrEmpty(c.entity.OperatNumber) == false)
					{
						q = q.Where(p => p.OperatNumber.Contains(c.entity.OperatNumber));
					}
					if (string.IsNullOrEmpty(c.entity.OperatType) == false)
					{
						q = q.Where(p => p.OperatType.Contains(c.entity.OperatType));
					}
					 if (c.entity.ReceivableMoney > 0)
					{
						q = q.Where(p => p.ReceivableMoney == c.entity.ReceivableMoney);
					}
					
					 if (c.entity.ReceivedMoney > 0)
					{
						q = q.Where(p => p.ReceivedMoney == c.entity.ReceivedMoney);
					}
					
					 if (c.entity.UnreceivedMoney > 0)
					{
						q = q.Where(p => p.UnreceivedMoney == c.entity.UnreceivedMoney);
					}
					
					 if (c.entity.PayMoney > 0)
					{
						q = q.Where(p => p.PayMoney == c.entity.PayMoney);
					}
					
					 if (c.entity.PayMargin > 0)
					{
						q = q.Where(p => p.PayMargin == c.entity.PayMargin);
					}
					
					if (string.IsNullOrEmpty(c.entity.MarginDeal) == false)
					{
						q = q.Where(p => p.MarginDeal.Contains(c.entity.MarginDeal));
					}
					if (string.IsNullOrEmpty(c.entity.TableName) == false)
					{
						q = q.Where(p => p.TableName.Contains(c.entity.TableName));
					}
					if (string.IsNullOrEmpty(c.entity.ColumnName) == false)
					{
						q = q.Where(p => p.ColumnName.Contains(c.entity.ColumnName));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.BaNumber.Contains(c.key)
					|| l.OperatNumber.Contains(c.key)
					|| l.OperatType.Contains(c.key)
					|| l.MarginDeal.Contains(c.key)
					|| l.TableName.Contains(c.key)
					|| l.ColumnName.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<BaBranchDetail> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.BaNumber.Contains(key)
					|| l.OperatNumber.Contains(key)
					|| l.OperatType.Contains(key)
					|| l.MarginDeal.Contains(key)
					|| l.TableName.Contains(key)
					|| l.ColumnName.Contains(key)
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




