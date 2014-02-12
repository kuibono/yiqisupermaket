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
    public class SysLoginPowerService:ISysLoginPowerService
    {

        public IRepositoryGUID<SysLoginPower> EntityRepository { get; set; }

        [Transaction]
        public string Create(SysLoginPower entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public SysLoginPower GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<SysLoginPower> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(SysLoginPower entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(SysLoginPower entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<SysLoginPower> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<SysLoginPower> Search(SearchDtoBase<SysLoginPower> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.EmName) == false)
					{
						
						q = q.Where(p => p.EmName.Contains(c.entity.EmName));
					}
					if (string.IsNullOrEmpty(c.entity.UserName) == false)
					{
						
						q = q.Where(p => p.UserName.Contains(c.entity.UserName));
					}
					if (string.IsNullOrEmpty(c.entity.UserPw) == false)
					{
						
						q = q.Where(p => p.UserPw.Contains(c.entity.UserPw));
					}
					if (string.IsNullOrEmpty(c.entity.IfCash) == false)
					{
						
						q = q.Where(p => p.IfCash.Contains(c.entity.IfCash));
					}
					if (string.IsNullOrEmpty(c.entity.CashFunction) == false)
					{
						
						q = q.Where(p => p.CashFunction.Contains(c.entity.CashFunction));
					}
					if (string.IsNullOrEmpty(c.entity.UserState) == false)
					{
						
						q = q.Where(p => p.UserState.Contains(c.entity.UserState));
					}
					 if (c.entity.MaxDiscount > 0)
					{
						q = q.Where(p => p.MaxDiscount == c.entity.MaxDiscount);
					}
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.EmName.Contains(c.key)
					|| l.UserName.Contains(c.key)
					|| l.UserPw.Contains(c.key)
					|| l.IfCash.Contains(c.key)
					|| l.CashFunction.Contains(c.key)
					|| l.UserState.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<SysLoginPower> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.EmCode.Contains(key)
					|| l.EmName.Contains(key)
					|| l.UserName.Contains(key)
					|| l.UserPw.Contains(key)
					|| l.IfCash.Contains(key)
					|| l.CashFunction.Contains(key)
					|| l.UserState.Contains(key)
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




