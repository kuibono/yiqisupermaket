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
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public class FbAdjustClassGoodsService:IFbAdjustClassGoodsService
    {

        public IRepositoryGUID<FbAdjustClassGoods> EntityRepository { get; set; }

        [Transaction]
        public string Create(FbAdjustClassGoods entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public FbAdjustClassGoods GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<FbAdjustClassGoods> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(FbAdjustClassGoods entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(FbAdjustClassGoods entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<FbAdjustClassGoods> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<FbAdjustClassGoods> Search(SearchDtoBase<FbAdjustClassGoods> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.AdjustNumber) == false)
					{
						q = q.Where(p => p.AdjustNumber.Contains(c.entity.AdjustNumber));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.GbCodeOld) == false)
					{
						q = q.Where(p => p.GbCodeOld.Contains(c.entity.GbCodeOld));
					}
					if (string.IsNullOrEmpty(c.entity.GmCodeOld) == false)
					{
						q = q.Where(p => p.GmCodeOld.Contains(c.entity.GmCodeOld));
					}
					if (string.IsNullOrEmpty(c.entity.GsCodeOld) == false)
					{
						q = q.Where(p => p.GsCodeOld.Contains(c.entity.GsCodeOld));
					}
					if (string.IsNullOrEmpty(c.entity.GlCodeOld) == false)
					{
						q = q.Where(p => p.GlCodeOld.Contains(c.entity.GlCodeOld));
					}
					if (string.IsNullOrEmpty(c.entity.GbCode) == false)
					{
						q = q.Where(p => p.GbCode.Contains(c.entity.GbCode));
					}
					if (string.IsNullOrEmpty(c.entity.GmCode) == false)
					{
						q = q.Where(p => p.GmCode.Contains(c.entity.GmCode));
					}
					if (string.IsNullOrEmpty(c.entity.GsCode) == false)
					{
						q = q.Where(p => p.GsCode.Contains(c.entity.GsCode));
					}
					if (string.IsNullOrEmpty(c.entity.GlCode) == false)
					{
						q = q.Where(p => p.GlCode.Contains(c.entity.GlCode));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.AdjustNumber.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.GbCodeOld.Contains(c.key)
					|| l.GmCodeOld.Contains(c.key)
					|| l.GsCodeOld.Contains(c.key)
					|| l.GlCodeOld.Contains(c.key)
					|| l.GbCode.Contains(c.key)
					|| l.GmCode.Contains(c.key)
					|| l.GsCode.Contains(c.key)
					|| l.GlCode.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<FbAdjustClassGoods> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.AdjustNumber.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.GbCodeOld.Contains(key)
					|| l.GmCodeOld.Contains(key)
					|| l.GsCodeOld.Contains(key)
					|| l.GlCodeOld.Contains(key)
					|| l.GbCode.Contains(key)
					|| l.GmCode.Contains(key)
					|| l.GsCode.Contains(key)
					|| l.GlCode.Contains(key)
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




