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
    public class SysOperationFlowDetailService:ISysOperationFlowDetailService
    {

        public IRepositoryGUID<SysOperationFlowDetail> EntityRepository { get; set; }

        [Transaction]
        public string Create(SysOperationFlowDetail entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public SysOperationFlowDetail GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<SysOperationFlowDetail> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(SysOperationFlowDetail entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(SysOperationFlowDetail entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<SysOperationFlowDetail> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<SysOperationFlowDetail> Search(SearchDtoBase<SysOperationFlowDetail> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.OperationName) == false)
					{
						
						q = q.Where(p => p.OperationName.Contains(c.entity.OperationName));
					}
					if (string.IsNullOrEmpty(c.entity.WindowName) == false)
					{
						
						q = q.Where(p => p.WindowName.Contains(c.entity.WindowName));
					}
					if (string.IsNullOrEmpty(c.entity.CurrentsNumber) == false)
					{
						
						q = q.Where(p => p.CurrentsNumber.Contains(c.entity.CurrentsNumber));
					}
					if (string.IsNullOrEmpty(c.entity.FunctionCode) == false)
					{
						
						q = q.Where(p => p.FunctionCode.Contains(c.entity.FunctionCode));
					}
					if (string.IsNullOrEmpty(c.entity.CurrentFunctionCode) == false)
					{
						
						q = q.Where(p => p.CurrentFunctionCode.Contains(c.entity.CurrentFunctionCode));
					}
					if (string.IsNullOrEmpty(c.entity.ColumnName) == false)
					{
						
						q = q.Where(p => p.ColumnName.Contains(c.entity.ColumnName));
					}
					if (string.IsNullOrEmpty(c.entity.NextsNumber) == false)
					{
						
						q = q.Where(p => p.NextsNumber.Contains(c.entity.NextsNumber));
					}
					if (string.IsNullOrEmpty(c.entity.CurrentState) == false)
					{
						
						q = q.Where(p => p.CurrentState.Contains(c.entity.CurrentState));
					}
					if (string.IsNullOrEmpty(c.entity.OperationState) == false)
					{
						
						q = q.Where(p => p.OperationState.Contains(c.entity.OperationState));
					}
					if (string.IsNullOrEmpty(c.entity.OperationResult) == false)
					{
						
						q = q.Where(p => p.OperationResult.Contains(c.entity.OperationResult));
					}
					if (string.IsNullOrEmpty(c.entity.OperationOpinion) == false)
					{
						
						q = q.Where(p => p.OperationOpinion.Contains(c.entity.OperationOpinion));
					}
					if (string.IsNullOrEmpty(c.entity.Operator) == false)
					{
						
						q = q.Where(p => p.Operator.Contains(c.entity.Operator));
					}
					if (string.IsNullOrEmpty(c.entity.Statement) == false)
					{
						
						q = q.Where(p => p.Statement.Contains(c.entity.Statement));
					}
					if (string.IsNullOrEmpty(c.entity.StatementState) == false)
					{
						
						q = q.Where(p => p.StatementState.Contains(c.entity.StatementState));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.OperationName.Contains(c.key)
					|| l.WindowName.Contains(c.key)
					|| l.CurrentsNumber.Contains(c.key)
					|| l.FunctionCode.Contains(c.key)
					|| l.CurrentFunctionCode.Contains(c.key)
					|| l.ColumnName.Contains(c.key)
					|| l.NextsNumber.Contains(c.key)
					|| l.CurrentState.Contains(c.key)
					|| l.OperationState.Contains(c.key)
					|| l.OperationResult.Contains(c.key)
					|| l.OperationOpinion.Contains(c.key)
					|| l.Operator.Contains(c.key)
					|| l.Statement.Contains(c.key)
					|| l.StatementState.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<SysOperationFlowDetail> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.OperationNumber.Contains(key)
					|| l.OperationName.Contains(key)
					|| l.sNumber.Contains(key)
					|| l.WindowName.Contains(key)
					|| l.CurrentsNumber.Contains(key)
					|| l.FunctionCode.Contains(key)
					|| l.CurrentFunctionCode.Contains(key)
					|| l.ColumnName.Contains(key)
					|| l.NextsNumber.Contains(key)
					|| l.CurrentState.Contains(key)
					|| l.OperationState.Contains(key)
					|| l.OperationResult.Contains(key)
					|| l.OperationOpinion.Contains(key)
					|| l.Operator.Contains(key)
					|| l.Statement.Contains(key)
					|| l.StatementState.Contains(key)
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




