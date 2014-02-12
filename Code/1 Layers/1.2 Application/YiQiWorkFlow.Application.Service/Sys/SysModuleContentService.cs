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
    public class SysModuleContentService:ISysModuleContentService
    {

        public IRepositoryGUID<SysModuleContent> EntityRepository { get; set; }

        [Transaction]
        public string Create(SysModuleContent entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public SysModuleContent GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<SysModuleContent> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(SysModuleContent entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(SysModuleContent entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<SysModuleContent> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<SysModuleContent> Search(SearchDtoBase<SysModuleContent> c)
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
					if (string.IsNullOrEmpty(c.entity.ColumnCode) == false)
					{
						
						q = q.Where(p => p.ColumnCode.Contains(c.entity.ColumnCode));
					}
					if (string.IsNullOrEmpty(c.entity.OpenWindowName) == false)
					{
						
						q = q.Where(p => p.OpenWindowName.Contains(c.entity.OpenWindowName));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.WindowName.Contains(c.key)
					|| l.ColumnCode.Contains(c.key)
					|| l.OpenWindowName.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<SysModuleContent> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.WindowName.Contains(key)
					|| l.ColumnCode.Contains(key)
					|| l.OpenWindowName.Contains(key)
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




