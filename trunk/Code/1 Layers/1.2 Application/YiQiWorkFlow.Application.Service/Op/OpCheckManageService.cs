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
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public class OpCheckManageService:IOpCheckManageService
    {

        public IRepositoryGUID<OpCheckManage> EntityRepository { get; set; }

        [Transaction]
        public string Create(OpCheckManage entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public OpCheckManage GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<OpCheckManage> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(OpCheckManage entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(OpCheckManage entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<OpCheckManage> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<OpCheckManage> Search(SearchDtoBase<OpCheckManage> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.CkType) == false)
					{
						q = q.Where(p => p.CkType.Contains(c.entity.CkType));
					}
					if (string.IsNullOrEmpty(c.entity.CkOrgan) == false)
					{
						q = q.Where(p => p.CkOrgan.Contains(c.entity.CkOrgan));
					}
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					if (string.IsNullOrEmpty(c.entity.CkArea) == false)
					{
						q = q.Where(p => p.CkArea.Contains(c.entity.CkArea));
					}
					if (string.IsNullOrEmpty(c.entity.IfTransfer) == false)
					{
						q = q.Where(p => p.IfTransfer.Contains(c.entity.IfTransfer));
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
					|| l.CkType.Contains(c.key)
					|| l.CkOrgan.Contains(c.key)
					|| l.WhCode.Contains(c.key)
					|| l.CkArea.Contains(c.key)
					|| l.IfTransfer.Contains(c.key)
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
        public IList<OpCheckManage> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.CkType.Contains(key)
					|| l.CkOrgan.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.CkArea.Contains(key)
					|| l.IfTransfer.Contains(key)
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




