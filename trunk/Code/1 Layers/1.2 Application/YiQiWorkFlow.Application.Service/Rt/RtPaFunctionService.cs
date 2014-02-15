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
    public class RtPaFunctionService:IRtPaFunctionService
    {

        public IRepositoryGUID<RtPaFunction> EntityRepository { get; set; }

        [Transaction]
        public string Create(RtPaFunction entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public RtPaFunction GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<RtPaFunction> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(RtPaFunction entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(RtPaFunction entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<RtPaFunction> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<RtPaFunction> Search(SearchDtoBase<RtPaFunction> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.FuncName) == false)
					{
						q = q.Where(p => p.FuncName.Contains(c.entity.FuncName));
					}
					if (string.IsNullOrEmpty(c.entity.FuncValue) == false)
					{
						q = q.Where(p => p.FuncValue.Contains(c.entity.FuncValue));
					}
					if (string.IsNullOrEmpty(c.entity.IfAble) == false)
					{
						q = q.Where(p => p.IfAble.Contains(c.entity.IfAble));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.FuncName.Contains(c.key)
					|| l.FuncValue.Contains(c.key)
					|| l.IfAble.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<RtPaFunction> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.FuncName.Contains(key)
					|| l.FuncValue.Contains(key)
					|| l.IfAble.Contains(key)
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




