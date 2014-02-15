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
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public class TgGroupCallService:ITgGroupCallService
    {

        public IRepository<TgGroupCall> EntityRepository { get; set; }

        [Transaction]
        public int Create(TgGroupCall entity)
        {
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public TgGroupCall GetById(int id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<TgGroupCall> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(TgGroupCall entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(TgGroupCall entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<TgGroupCall> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<TgGroupCall> Search(SearchDtoBase<TgGroupCall> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
					if (string.IsNullOrEmpty(c.entity.CallType) == false)
					{
						q = q.Where(p => p.CallType.Contains(c.entity.CallType));
					}
					if (string.IsNullOrEmpty(c.entity.ItemsCode) == false)
					{
						q = q.Where(p => p.ItemsCode.Contains(c.entity.ItemsCode));
					}
					if (string.IsNullOrEmpty(c.entity.ItemsName) == false)
					{
						q = q.Where(p => p.ItemsName.Contains(c.entity.ItemsName));
					}
					if (string.IsNullOrEmpty(c.entity.CallContent) == false)
					{
						q = q.Where(p => p.CallContent.Contains(c.entity.CallContent));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.CallType.Contains(c.key)
					|| l.ItemsCode.Contains(c.key)
					|| l.ItemsName.Contains(c.key)
					|| l.CallContent.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<TgGroupCall> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.CallType.Contains(key)
					|| l.ItemsCode.Contains(key)
					|| l.ItemsName.Contains(key)
					|| l.CallContent.Contains(key)
                    select l;
					
                
            }
            q = q.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            var result = q.ToList();
            return result.ToList();
        }

        [Transaction]
        public void Delete(IList<string> ids)
        {
			var int_ids = ids.ToList().Select(p => { return Convert.ToInt32(p); }).ToList();
            var q = EntityRepository.LinqQuery.Where(p => int_ids.Contains(p.Id));
            foreach (var each in q)
            {
                Delete(each);
            }
        }
    }
}




