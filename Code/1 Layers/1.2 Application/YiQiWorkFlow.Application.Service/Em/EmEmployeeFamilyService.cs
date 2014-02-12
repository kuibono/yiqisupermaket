/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:06
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Em;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Em
{
    public class EmEmployeeFamilyService:IEmEmployeeFamilyService
    {

        public IRepositoryGUID<EmEmployeeFamily> EntityRepository { get; set; }

        [Transaction]
        public string Create(EmEmployeeFamily entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public EmEmployeeFamily GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<EmEmployeeFamily> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(EmEmployeeFamily entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(EmEmployeeFamily entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<EmEmployeeFamily> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<EmEmployeeFamily> Search(SearchDtoBase<EmEmployeeFamily> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.EmCode) == false)
					{
						
						q = q.Where(p => p.EmCode.Contains(c.entity.EmCode));
					}
					if (string.IsNullOrEmpty(c.entity.sNumber) == false)
					{
						
						q = q.Where(p => p.sNumber.Contains(c.entity.sNumber));
					}
					if (string.IsNullOrEmpty(c.entity.MemberName) == false)
					{
						
						q = q.Where(p => p.MemberName.Contains(c.entity.MemberName));
					}
					if (string.IsNullOrEmpty(c.entity.Relationship) == false)
					{
						
						q = q.Where(p => p.Relationship.Contains(c.entity.Relationship));
					}
					if (string.IsNullOrEmpty(c.entity.PoliticsCode) == false)
					{
						
						q = q.Where(p => p.PoliticsCode.Contains(c.entity.PoliticsCode));
					}
					if (string.IsNullOrEmpty(c.entity.DutyCode) == false)
					{
						
						q = q.Where(p => p.DutyCode.Contains(c.entity.DutyCode));
					}
					if (string.IsNullOrEmpty(c.entity.WorkDepartment) == false)
					{
						
						q = q.Where(p => p.WorkDepartment.Contains(c.entity.WorkDepartment));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.EmCode.Contains(c.key)
					|| l.sNumber.Contains(c.key)
					|| l.MemberName.Contains(c.key)
					|| l.Relationship.Contains(c.key)
					|| l.PoliticsCode.Contains(c.key)
					|| l.DutyCode.Contains(c.key)
					|| l.WorkDepartment.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<EmEmployeeFamily> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.EmCode.Contains(key)
					|| l.sNumber.Contains(key)
					|| l.MemberName.Contains(key)
					|| l.Relationship.Contains(key)
					|| l.PoliticsCode.Contains(key)
					|| l.DutyCode.Contains(key)
					|| l.WorkDepartment.Contains(key)
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




