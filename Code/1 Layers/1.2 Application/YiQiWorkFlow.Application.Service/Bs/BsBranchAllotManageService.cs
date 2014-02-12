/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:06
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public class BsBranchAllotManageService:IBsBranchAllotManageService
    {

        public IRepositoryGUID<BsBranchAllotManage> EntityRepository { get; set; }

        [Transaction]
        public string Create(BsBranchAllotManage entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public BsBranchAllotManage GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<BsBranchAllotManage> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(BsBranchAllotManage entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(BsBranchAllotManage entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<BsBranchAllotManage> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<BsBranchAllotManage> Search(SearchDtoBase<BsBranchAllotManage> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.bCodeOut) == false)
					{
						
						q = q.Where(p => p.bCodeOut.Contains(c.entity.bCodeOut));
					}
					if (string.IsNullOrEmpty(c.entity.WhCodeOut) == false)
					{
						
						q = q.Where(p => p.WhCodeOut.Contains(c.entity.WhCodeOut));
					}
					if (string.IsNullOrEmpty(c.entity.bCodeIn) == false)
					{
						
						q = q.Where(p => p.bCodeIn.Contains(c.entity.bCodeIn));
					}
					if (string.IsNullOrEmpty(c.entity.WhCodeIn) == false)
					{
						
						q = q.Where(p => p.WhCodeIn.Contains(c.entity.WhCodeIn));
					}
					if (string.IsNullOrEmpty(c.entity.Operator) == false)
					{
						
						q = q.Where(p => p.Operator.Contains(c.entity.Operator));
					}
					if (string.IsNullOrEmpty(c.entity.Assessor) == false)
					{
						
						q = q.Where(p => p.Assessor.Contains(c.entity.Assessor));
					}
					if (string.IsNullOrEmpty(c.entity.IfExamine) == false)
					{
						
						q = q.Where(p => p.IfExamine.Contains(c.entity.IfExamine));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.bCodeOut.Contains(c.key)
					|| l.WhCodeOut.Contains(c.key)
					|| l.bCodeIn.Contains(c.key)
					|| l.WhCodeIn.Contains(c.key)
					|| l.Operator.Contains(c.key)
					|| l.Assessor.Contains(c.key)
					|| l.IfExamine.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<BsBranchAllotManage> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.AlNumber.Contains(key)
					|| l.bCodeOut.Contains(key)
					|| l.WhCodeOut.Contains(key)
					|| l.bCodeIn.Contains(key)
					|| l.WhCodeIn.Contains(key)
					|| l.Operator.Contains(key)
					|| l.Assessor.Contains(key)
					|| l.IfExamine.Contains(key)
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




