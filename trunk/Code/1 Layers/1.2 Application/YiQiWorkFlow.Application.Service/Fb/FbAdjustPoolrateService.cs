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
    public class FbAdjustPoolrateService:IFbAdjustPoolrateService
    {

        public IRepositoryGUID<FbAdjustPoolrate> EntityRepository { get; set; }
        public IRepositoryGUID<FbAdjustPoolrateGoods> PoolrateGoodsRepository { get; set; }
        public IRepositoryGUID<FbGoodsArchivesSupplier> GoodsSupplierRepository { get; set; }
        public IRepositoryGUID<FbGoodsArchives> GoodsRepository { get; set; }

        [Transaction]
        public string Create(FbAdjustPoolrate entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public FbAdjustPoolrate GetById(string id)
        {
            return EntityRepository.Get(id);
        }
        [Transaction]
        public void ExameByNumber(string id)
        {
            var poolRateGoods = PoolrateGoodsRepository.LinqQuery.Where(p => p.AdjustNumber == id);
            foreach (var rategood in poolRateGoods)
            {
                var goods = GoodsRepository.LinqQuery.Where(p => p.Id == rategood.GoodsCode).ToList();
                goods.ForEach(p => {
                    p.PoolRate = rategood.PoolRate;
                    GoodsRepository.Update(p);
                });
                var goodssup = GoodsSupplierRepository.LinqQuery.Where(p => p.GoodsCode == rategood.GoodsCode && p.SupCode == rategood.SupCode && p.IfMainSupplier=="1").ToList();
                goodssup.ForEach(p => {
                    p.PoolRate = rategood.PoolRate;
                    GoodsSupplierRepository.Update(p);
                });
                //foreach (var good in goods)
                //{
                //    good.
                //}
            }
        }

        [Transaction]
        public IList<FbAdjustPoolrate> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(FbAdjustPoolrate entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(FbAdjustPoolrate entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<FbAdjustPoolrate> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<FbAdjustPoolrate> Search(SearchDtoBase<FbAdjustPoolrate> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.AdjustReason) == false)
					{
						q = q.Where(p => p.AdjustReason.Contains(c.entity.AdjustReason));
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
					|| l.AdjustReason.Contains(c.key)
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
        public IList<FbAdjustPoolrate> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.AdjustReason.Contains(key)
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




