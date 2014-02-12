/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:06
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public class FbGoodsArchivesBarService:IFbGoodsArchivesBarService
    {

        public IRepositoryGUID<FbGoodsArchivesBar> EntityRepository { get; set; }

        [Transaction]
        public string Create(FbGoodsArchivesBar entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public FbGoodsArchivesBar GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<FbGoodsArchivesBar> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(FbGoodsArchivesBar entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(FbGoodsArchivesBar entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<FbGoodsArchivesBar> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<FbGoodsArchivesBar> Search(SearchDtoBase<FbGoodsArchivesBar> c)
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
					if (string.IsNullOrEmpty(c.entity.GoodsBarName) == false)
					{
						
						q = q.Where(p => p.GoodsBarName.Contains(c.entity.GoodsBarName));
					}
					if (string.IsNullOrEmpty(c.entity.PackUnitCode) == false)
					{
						
						q = q.Where(p => p.PackUnitCode.Contains(c.entity.PackUnitCode));
					}
					 if (c.entity.PackCoef > 0)
					{
						q = q.Where(p => p.PackCoef == c.entity.PackCoef);
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
					
					 if (c.entity.PushRate > 0)
					{
						q = q.Where(p => p.PushRate == c.entity.PushRate);
					}
					
					if (string.IsNullOrEmpty(c.entity.IfMainBar) == false)
					{
						
						q = q.Where(p => p.IfMainBar.Contains(c.entity.IfMainBar));
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
					|| l.GoodsCode.Contains(c.key)
					|| l.GoodsBarCode.Contains(c.key)
					|| l.GoodsBarName.Contains(c.key)
					|| l.PackUnitCode.Contains(c.key)
					|| l.QtyType.Contains(c.key)
					|| l.PriceType.Contains(c.key)
					|| l.IfMainBar.Contains(c.key)
					|| l.IfExamine.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<FbGoodsArchivesBar> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.GoodsBarCode.Contains(key)
					|| l.GoodsBarName.Contains(key)
					|| l.PackUnitCode.Contains(key)
					|| l.QtyType.Contains(key)
					|| l.PriceType.Contains(key)
					|| l.IfMainBar.Contains(key)
					|| l.IfExamine.Contains(key)
					|| l.Id.Contains(key)
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




