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
    public class MsCardtypeGoodsPointsService:IMsCardtypeGoodsPointsService
    {

        public IRepositoryGUID<MsCardtypeGoodsPoints> EntityRepository { get; set; }

        [Transaction]
        public string Create(MsCardtypeGoodsPoints entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public MsCardtypeGoodsPoints GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<MsCardtypeGoodsPoints> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(MsCardtypeGoodsPoints entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(MsCardtypeGoodsPoints entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<MsCardtypeGoodsPoints> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<MsCardtypeGoodsPoints> Search(SearchDtoBase<MsCardtypeGoodsPoints> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.CardCode) == false)
					{
						q = q.Where(p => p.CardCode.Contains(c.entity.CardCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsName) == false)
					{
						q = q.Where(p => p.GoodsName.Contains(c.entity.GoodsName));
					}
					 if (c.entity.ExpendBase > 0)
					{
						q = q.Where(p => p.ExpendBase == c.entity.ExpendBase);
					}
					
					 if (c.entity.PointsValues > 0)
					{
						q = q.Where(p => p.PointsValues == c.entity.PointsValues);
					}
					
					if (string.IsNullOrEmpty(c.entity.SysGuid) == false)
					{
						q = q.Where(p => p.SysGuid.Contains(c.entity.SysGuid));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.CardCode.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.GoodsName.Contains(c.key)
					|| l.SysGuid.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<MsCardtypeGoodsPoints> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.CardCode.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.GoodsName.Contains(key)
					|| l.SysGuid.Contains(key)
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




