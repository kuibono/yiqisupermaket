/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:07
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public class OpCheckStockService:IOpCheckStockService
    {

        public IRepositoryGUID<OpCheckStock> EntityRepository { get; set; }

        [Transaction]
        public string Create(OpCheckStock entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public OpCheckStock GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<OpCheckStock> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(OpCheckStock entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(OpCheckStock entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<OpCheckStock> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<OpCheckStock> Search(SearchDtoBase<OpCheckStock> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.CkNumber) == false)
					{
						
						q = q.Where(p => p.CkNumber.Contains(c.entity.CkNumber));
					}
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					 if (c.entity.StockQty > 0)
					{
						q = q.Where(p => p.StockQty == c.entity.StockQty);
					}
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.CkNumber.Contains(c.key)
					|| l.WhCode.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<OpCheckStock> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.CkNumber.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.GoodsCode.Contains(key)
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




