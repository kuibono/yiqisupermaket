/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:07
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public class SysOperationFlowService:ISysOperationFlowService
    {

        public IRepositoryGUID<SysOperationFlow> EntityRepository { get; set; }

        [Transaction]
        public string Create(SysOperationFlow entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public SysOperationFlow GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<SysOperationFlow> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(SysOperationFlow entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(SysOperationFlow entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<SysOperationFlow> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<SysOperationFlow> Search(SearchDtoBase<SysOperationFlow> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.WindowName) == false)
					{
						
						q = q.Where(p => p.WindowName.Contains(c.entity.WindowName));
					}
					if (string.IsNullOrEmpty(c.entity.FunctionCode) == false)
					{
						
						q = q.Where(p => p.FunctionCode.Contains(c.entity.FunctionCode));
					}
					if (string.IsNullOrEmpty(c.entity.TurnsNumber) == false)
					{
						
						q = q.Where(p => p.TurnsNumber.Contains(c.entity.TurnsNumber));
					}
					if (string.IsNullOrEmpty(c.entity.Operation) == false)
					{
						
						q = q.Where(p => p.Operation.Contains(c.entity.Operation));
					}
					if (string.IsNullOrEmpty(c.entity.Condition) == false)
					{
						
						q = q.Where(p => p.Condition.Contains(c.entity.Condition));
					}
					 if (c.entity.Content > 0)
					{
						q = q.Where(p => p.Content == c.entity.Content);
					}
					
					if (string.IsNullOrEmpty(c.entity.Statement) == false)
					{
						
						q = q.Where(p => p.Statement.Contains(c.entity.Statement));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.WindowName.Contains(c.key)
					|| l.FunctionCode.Contains(c.key)
					|| l.TurnsNumber.Contains(c.key)
					|| l.Operation.Contains(c.key)
					|| l.Condition.Contains(c.key)
					|| l.Statement.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<SysOperationFlow> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.OperationName.Contains(key)
					|| l.WindowName.Contains(key)
					|| l.sNumber.Contains(key)
					|| l.FunctionCode.Contains(key)
					|| l.TurnsNumber.Contains(key)
					|| l.Operation.Contains(key)
					|| l.Condition.Contains(key)
					|| l.Statement.Contains(key)
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




