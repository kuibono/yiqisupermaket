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
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public class SysModuleService:ISysModuleService
    {

        public IRepositoryGUID<SysModule> EntityRepository { get; set; }

        [Transaction]
        public string Create(SysModule entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public SysModule GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<SysModule> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(SysModule entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(SysModule entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<SysModule> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<SysModule> Search(SearchDtoBase<SysModule> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.WindowCode) == false)
					{
						q = q.Where(p => p.WindowCode.Contains(c.entity.WindowCode));
					}
					if (string.IsNullOrEmpty(c.entity.ModuleCode) == false)
					{
						q = q.Where(p => p.ModuleCode.Contains(c.entity.ModuleCode));
					}
					if (string.IsNullOrEmpty(c.entity.ModuleName) == false)
					{
						q = q.Where(p => p.ModuleName.Contains(c.entity.ModuleName));
					}
					if (string.IsNullOrEmpty(c.entity.ModuleChild) == false)
					{
						q = q.Where(p => p.ModuleChild.Contains(c.entity.ModuleChild));
					}
					if (string.IsNullOrEmpty(c.entity.OpenMode) == false)
					{
						q = q.Where(p => p.OpenMode.Contains(c.entity.OpenMode));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.WindowCode.Contains(c.key)
					|| l.ModuleCode.Contains(c.key)
					|| l.ModuleName.Contains(c.key)
					|| l.ModuleChild.Contains(c.key)
					|| l.OpenMode.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<SysModule> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.WindowCode.Contains(key)
					|| l.ModuleCode.Contains(key)
					|| l.ModuleName.Contains(key)
					|| l.ModuleChild.Contains(key)
					|| l.OpenMode.Contains(key)
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




