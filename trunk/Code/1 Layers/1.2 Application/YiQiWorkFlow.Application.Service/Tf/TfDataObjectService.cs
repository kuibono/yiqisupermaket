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
using YiQiWorkFlow.Domain.Tf;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tf
{
    public class TfDataObjectService:ITfDataObjectService
    {

        public IRepositoryGUID<TfDataObject> EntityRepository { get; set; }

        [Transaction]
        public string Create(TfDataObject entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public TfDataObject GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<TfDataObject> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(TfDataObject entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(TfDataObject entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<TfDataObject> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<TfDataObject> Search(SearchDtoBase<TfDataObject> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.ObjectId) == false)
					{
						q = q.Where(p => p.ObjectId.Contains(c.entity.ObjectId));
					}
					if (string.IsNullOrEmpty(c.entity.ObjectName) == false)
					{
						q = q.Where(p => p.ObjectName.Contains(c.entity.ObjectName));
					}
					if (string.IsNullOrEmpty(c.entity.ObjectMain) == false)
					{
						q = q.Where(p => p.ObjectMain.Contains(c.entity.ObjectMain));
					}
					if (string.IsNullOrEmpty(c.entity.ObjectMaincolumn) == false)
					{
						q = q.Where(p => p.ObjectMaincolumn.Contains(c.entity.ObjectMaincolumn));
					}
					if (string.IsNullOrEmpty(c.entity.ObjectForeigncolumn) == false)
					{
						q = q.Where(p => p.ObjectForeigncolumn.Contains(c.entity.ObjectForeigncolumn));
					}
					if (string.IsNullOrEmpty(c.entity.ObjectDump) == false)
					{
						q = q.Where(p => p.ObjectDump.Contains(c.entity.ObjectDump));
					}
					if (string.IsNullOrEmpty(c.entity.ObjectKeycolumn) == false)
					{
						q = q.Where(p => p.ObjectKeycolumn.Contains(c.entity.ObjectKeycolumn));
					}
					if (string.IsNullOrEmpty(c.entity.ObjectBranchcodecolumn) == false)
					{
						q = q.Where(p => p.ObjectBranchcodecolumn.Contains(c.entity.ObjectBranchcodecolumn));
					}
					if (string.IsNullOrEmpty(c.entity.ObjectDescription) == false)
					{
						q = q.Where(p => p.ObjectDescription.Contains(c.entity.ObjectDescription));
					}
					if (string.IsNullOrEmpty(c.entity.ObjectDirection) == false)
					{
						q = q.Where(p => p.ObjectDirection.Contains(c.entity.ObjectDirection));
					}
					if (string.IsNullOrEmpty(c.entity.ObjectCondition) == false)
					{
						q = q.Where(p => p.ObjectCondition.Contains(c.entity.ObjectCondition));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.ObjectId.Contains(c.key)
					|| l.ObjectName.Contains(c.key)
					|| l.ObjectMain.Contains(c.key)
					|| l.ObjectMaincolumn.Contains(c.key)
					|| l.ObjectForeigncolumn.Contains(c.key)
					|| l.ObjectDump.Contains(c.key)
					|| l.ObjectKeycolumn.Contains(c.key)
					|| l.ObjectBranchcodecolumn.Contains(c.key)
					|| l.ObjectDescription.Contains(c.key)
					|| l.ObjectDirection.Contains(c.key)
					|| l.ObjectCondition.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<TfDataObject> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.ObjectId.Contains(key)
					|| l.ObjectName.Contains(key)
					|| l.ObjectMain.Contains(key)
					|| l.ObjectMaincolumn.Contains(key)
					|| l.ObjectForeigncolumn.Contains(key)
					|| l.ObjectDump.Contains(key)
					|| l.ObjectKeycolumn.Contains(key)
					|| l.ObjectBranchcodecolumn.Contains(key)
					|| l.ObjectDescription.Contains(key)
					|| l.ObjectDirection.Contains(key)
					|| l.ObjectCondition.Contains(key)
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




