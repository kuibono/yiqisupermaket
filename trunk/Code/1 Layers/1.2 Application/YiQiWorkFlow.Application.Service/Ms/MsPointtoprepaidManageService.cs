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
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public class MsPointtoprepaidManageService:IMsPointtoprepaidManageService
    {

        public IRepository<MsPointtoprepaidManage> EntityRepository { get; set; }

        [Transaction]
        public int Create(MsPointtoprepaidManage entity)
        {
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public MsPointtoprepaidManage GetById(int id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<MsPointtoprepaidManage> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(MsPointtoprepaidManage entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(MsPointtoprepaidManage entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<MsPointtoprepaidManage> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<MsPointtoprepaidManage> Search(SearchDtoBase<MsPointtoprepaidManage> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
					if (string.IsNullOrEmpty(c.entity.CardNumber) == false)
					{
						q = q.Where(p => p.CardNumber.Contains(c.entity.CardNumber));
					}
					if (string.IsNullOrEmpty(c.entity.SurfaceNumber) == false)
					{
						q = q.Where(p => p.SurfaceNumber.Contains(c.entity.SurfaceNumber));
					}
					if (string.IsNullOrEmpty(c.entity.MsCode) == false)
					{
						q = q.Where(p => p.MsCode.Contains(c.entity.MsCode));
					}
					if (string.IsNullOrEmpty(c.entity.MsName) == false)
					{
						q = q.Where(p => p.MsName.Contains(c.entity.MsName));
					}
					if (string.IsNullOrEmpty(c.entity.CardCode) == false)
					{
						q = q.Where(p => p.CardCode.Contains(c.entity.CardCode));
					}
					if (string.IsNullOrEmpty(c.entity.CardName) == false)
					{
						q = q.Where(p => p.CardName.Contains(c.entity.CardName));
					}
					 if (c.entity.CurrentPoints > 0)
					{
						q = q.Where(p => p.CurrentPoints == c.entity.CurrentPoints);
					}
					
					 if (c.entity.ExchangePoints > 0)
					{
						q = q.Where(p => p.ExchangePoints == c.entity.ExchangePoints);
					}
					
					 if (c.entity.SurplusPoints > 0)
					{
						q = q.Where(p => p.SurplusPoints == c.entity.SurplusPoints);
					}
					
					 if (c.entity.PrepaidMoney > 0)
					{
						q = q.Where(p => p.PrepaidMoney == c.entity.PrepaidMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.Operator) == false)
					{
						q = q.Where(p => p.Operator.Contains(c.entity.Operator));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.CardNumber.Contains(c.key)
					|| l.SurfaceNumber.Contains(c.key)
					|| l.MsCode.Contains(c.key)
					|| l.MsName.Contains(c.key)
					|| l.CardCode.Contains(c.key)
					|| l.CardName.Contains(c.key)
					|| l.Operator.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<MsPointtoprepaidManage> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.CardNumber.Contains(key)
					|| l.SurfaceNumber.Contains(key)
					|| l.MsCode.Contains(key)
					|| l.MsName.Contains(key)
					|| l.CardCode.Contains(key)
					|| l.CardName.Contains(key)
					|| l.Operator.Contains(key)
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




