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
    public class FbGoodsBarCodeService:IFbGoodsBarCodeService
    {

        public IRepositoryGUID<FbGoodsBarCode> EntityRepository { get; set; }

        [Transaction]
        public string Create(FbGoodsBarCode entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public FbGoodsBarCode GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<FbGoodsBarCode> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(FbGoodsBarCode entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(FbGoodsBarCode entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<FbGoodsBarCode> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<FbGoodsBarCode> Search(SearchDtoBase<FbGoodsBarCode> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsBarCode) == false)
					{
						q = q.Where(p => p.GoodsBarCode.Contains(c.entity.GoodsBarCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsSubCode) == false)
					{
						q = q.Where(p => p.GoodsSubCode.Contains(c.entity.GoodsSubCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsName) == false)
					{
						q = q.Where(p => p.GoodsName.Contains(c.entity.GoodsName));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsSubName) == false)
					{
						q = q.Where(p => p.GoodsSubName.Contains(c.entity.GoodsSubName));
					}
					if (string.IsNullOrEmpty(c.entity.PyCode) == false)
					{
						q = q.Where(p => p.PyCode.Contains(c.entity.PyCode));
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
					if (string.IsNullOrEmpty(c.entity.OwnerType) == false)
					{
						q = q.Where(p => p.OwnerType.Contains(c.entity.OwnerType));
					}
					if (string.IsNullOrEmpty(c.entity.SupCode) == false)
					{
						q = q.Where(p => p.SupCode.Contains(c.entity.SupCode));
					}
					if (string.IsNullOrEmpty(c.entity.OpCode) == false)
					{
						q = q.Where(p => p.OpCode.Contains(c.entity.OpCode));
					}
					 if (c.entity.PoolRate > 0)
					{
						q = q.Where(p => p.PoolRate == c.entity.PoolRate);
					}
					
					 if (c.entity.PackCoef > 0)
					{
						q = q.Where(p => p.PackCoef == c.entity.PackCoef);
					}
					
					if (string.IsNullOrEmpty(c.entity.PackUnitCode) == false)
					{
						q = q.Where(p => p.PackUnitCode.Contains(c.entity.PackUnitCode));
					}
					if (string.IsNullOrEmpty(c.entity.QtyType) == false)
					{
						q = q.Where(p => p.QtyType.Contains(c.entity.QtyType));
					}
					if (string.IsNullOrEmpty(c.entity.PriceType) == false)
					{
						q = q.Where(p => p.PriceType.Contains(c.entity.PriceType));
					}
					 if (c.entity.SalePrice > 0)
					{
						q = q.Where(p => p.SalePrice == c.entity.SalePrice);
					}
					
					 if (c.entity.VipPrice > 0)
					{
						q = q.Where(p => p.VipPrice == c.entity.VipPrice);
					}
					
					 if (c.entity.TradePrice > 0)
					{
						q = q.Where(p => p.TradePrice == c.entity.TradePrice);
					}
					
					if (string.IsNullOrEmpty(c.entity.GoodsState) == false)
					{
						q = q.Where(p => p.GoodsState.Contains(c.entity.GoodsState));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.GoodsBarCode.Contains(c.key)
					|| l.GoodsSubCode.Contains(c.key)
					|| l.GoodsName.Contains(c.key)
					|| l.GoodsSubName.Contains(c.key)
					|| l.PyCode.Contains(c.key)
					|| l.GbCode.Contains(c.key)
					|| l.GmCode.Contains(c.key)
					|| l.GsCode.Contains(c.key)
					|| l.GlCode.Contains(c.key)
					|| l.OwnerType.Contains(c.key)
					|| l.SupCode.Contains(c.key)
					|| l.OpCode.Contains(c.key)
					|| l.PackUnitCode.Contains(c.key)
					|| l.QtyType.Contains(c.key)
					|| l.PriceType.Contains(c.key)
					|| l.GoodsState.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<FbGoodsBarCode> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.GoodsBarCode.Contains(key)
					|| l.GoodsSubCode.Contains(key)
					|| l.GoodsName.Contains(key)
					|| l.GoodsSubName.Contains(key)
					|| l.PyCode.Contains(key)
					|| l.GbCode.Contains(key)
					|| l.GmCode.Contains(key)
					|| l.GsCode.Contains(key)
					|| l.GlCode.Contains(key)
					|| l.OwnerType.Contains(key)
					|| l.SupCode.Contains(key)
					|| l.OpCode.Contains(key)
					|| l.PackUnitCode.Contains(key)
					|| l.QtyType.Contains(key)
					|| l.PriceType.Contains(key)
					|| l.GoodsState.Contains(key)
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




