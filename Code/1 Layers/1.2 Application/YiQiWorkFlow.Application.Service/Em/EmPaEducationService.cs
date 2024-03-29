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
using YiQiWorkFlow.Domain.Em;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Em
{
    public class EmPaEducationService:IEmPaEducationService
    {

        public IRepositoryGUID<EmPaEducation> EntityRepository { get; set; }

        [Transaction]
        public string Create(EmPaEducation entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public EmPaEducation GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<EmPaEducation> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(EmPaEducation entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(EmPaEducation entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<EmPaEducation> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<EmPaEducation> Search(SearchDtoBase<EmPaEducation> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
					if (string.IsNullOrEmpty(c.entity.EducationCode) == false)
					{
						q = q.Where(p => p.EducationCode.Contains(c.entity.EducationCode));
					}
					if (string.IsNullOrEmpty(c.entity.EducationName) == false)
					{
						q = q.Where(p => p.EducationName.Contains(c.entity.EducationName));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                
					l.EducationCode.Contains(c.key)
					|| l.EducationName.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<EmPaEducation> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					l.EducationCode.Contains(key)
					|| l.EducationName.Contains(key)
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




