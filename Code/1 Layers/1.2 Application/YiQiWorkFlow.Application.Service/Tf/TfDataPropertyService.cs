/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:07
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Tf;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tf
{
    public class TfDataPropertyService:ITfDataPropertyService
    {

        public IRepositoryGUID<TfDataProperty> EntityRepository { get; set; }

        [Transaction]
        public string Create(TfDataProperty entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public TfDataProperty GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<TfDataProperty> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(TfDataProperty entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(TfDataProperty entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<TfDataProperty> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<TfDataProperty> Search(SearchDtoBase<TfDataProperty> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.PropertyId) == false)
					{
						
						q = q.Where(p => p.PropertyId.Contains(c.entity.PropertyId));
					}
					if (string.IsNullOrEmpty(c.entity.PropertyObject) == false)
					{
						
						q = q.Where(p => p.PropertyObject.Contains(c.entity.PropertyObject));
					}
					if (string.IsNullOrEmpty(c.entity.PropertyName) == false)
					{
						
						q = q.Where(p => p.PropertyName.Contains(c.entity.PropertyName));
					}
					if (string.IsNullOrEmpty(c.entity.PropertyType) == false)
					{
						
						q = q.Where(p => p.PropertyType.Contains(c.entity.PropertyType));
					}
					if (string.IsNullOrEmpty(c.entity.PropertyDescription) == false)
					{
						
						q = q.Where(p => p.PropertyDescription.Contains(c.entity.PropertyDescription));
					}
					if (string.IsNullOrEmpty(c.entity.PropertyCondition) == false)
					{
						
						q = q.Where(p => p.PropertyCondition.Contains(c.entity.PropertyCondition));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.PropertyId.Contains(c.key)
					|| l.PropertyObject.Contains(c.key)
					|| l.PropertyName.Contains(c.key)
					|| l.PropertyType.Contains(c.key)
					|| l.PropertyDescription.Contains(c.key)
					|| l.PropertyCondition.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<TfDataProperty> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.PropertyId.Contains(key)
					|| l.PropertyObject.Contains(key)
					|| l.PropertyName.Contains(key)
					|| l.PropertyType.Contains(key)
					|| l.PropertyDescription.Contains(key)
					|| l.PropertyCondition.Contains(key)
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




