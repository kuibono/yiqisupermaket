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
    public class FbGoodsArchivesService:IFbGoodsArchivesService
    {

        public IRepositoryGUID<FbGoodsArchives> EntityRepository { get; set; }

        [Transaction]
        public string Create(FbGoodsArchives entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public FbGoodsArchives GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<FbGoodsArchives> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(FbGoodsArchives entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(FbGoodsArchives entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<FbGoodsArchives> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<FbGoodsArchives> Search(SearchDtoBase<FbGoodsArchives> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.GoodsBarCode) == false)
					{
						
						q = q.Where(p => p.GoodsBarCode.Contains(c.entity.GoodsBarCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsSubCode) == false)
					{
						
						q = q.Where(p => p.GoodsSubCode.Contains(c.entity.GoodsSubCode));
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
					if (string.IsNullOrEmpty(c.entity.GoodsType) == false)
					{
						
						q = q.Where(p => p.GoodsType.Contains(c.entity.GoodsType));
					}
					if (string.IsNullOrEmpty(c.entity.CheckMode) == false)
					{
						
						q = q.Where(p => p.CheckMode.Contains(c.entity.CheckMode));
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
					if (string.IsNullOrEmpty(c.entity.GoodsState) == false)
					{
						
						q = q.Where(p => p.GoodsState.Contains(c.entity.GoodsState));
					}
					if (string.IsNullOrEmpty(c.entity.ProducingArea) == false)
					{
						
						q = q.Where(p => p.ProducingArea.Contains(c.entity.ProducingArea));
					}
					if (string.IsNullOrEmpty(c.entity.ArticleNumber) == false)
					{
						
						q = q.Where(p => p.ArticleNumber.Contains(c.entity.ArticleNumber));
					}
					if (string.IsNullOrEmpty(c.entity.Specification) == false)
					{
						
						q = q.Where(p => p.Specification.Contains(c.entity.Specification));
					}
					if (string.IsNullOrEmpty(c.entity.ShelfLife) == false)
					{
						
						q = q.Where(p => p.ShelfLife.Contains(c.entity.ShelfLife));
					}
					if (string.IsNullOrEmpty(c.entity.PackUnitCode) == false)
					{
						
						q = q.Where(p => p.PackUnitCode.Contains(c.entity.PackUnitCode));
					}
					if (string.IsNullOrEmpty(c.entity.OfferMode) == false)
					{
						
						q = q.Where(p => p.OfferMode.Contains(c.entity.OfferMode));
					}
					 if (c.entity.PackCoef > 0)
					{
						q = q.Where(p => p.PackCoef == c.entity.PackCoef);
					}
					
					 if (c.entity.OfferMin > 0)
					{
						q = q.Where(p => p.OfferMin == c.entity.OfferMin);
					}
					
					 if (c.entity.InputTax > 0)
					{
						q = q.Where(p => p.InputTax == c.entity.InputTax);
					}
					
					 if (c.entity.OutputTax > 0)
					{
						q = q.Where(p => p.OutputTax == c.entity.OutputTax);
					}
					
					 if (c.entity.StockUpperLimit > 0)
					{
						q = q.Where(p => p.StockUpperLimit == c.entity.StockUpperLimit);
					}
					
					 if (c.entity.StockLowerLimit > 0)
					{
						q = q.Where(p => p.StockLowerLimit == c.entity.StockLowerLimit);
					}
					
					if (string.IsNullOrEmpty(c.entity.UnderFloorCode) == false)
					{
						
						q = q.Where(p => p.UnderFloorCode.Contains(c.entity.UnderFloorCode));
					}
					if (string.IsNullOrEmpty(c.entity.UnderCounterCode) == false)
					{
						
						q = q.Where(p => p.UnderCounterCode.Contains(c.entity.UnderCounterCode));
					}
					if (string.IsNullOrEmpty(c.entity.CheckUnitCode) == false)
					{
						
						q = q.Where(p => p.CheckUnitCode.Contains(c.entity.CheckUnitCode));
					}
					 if (c.entity.PurchasePrice > 0)
					{
						q = q.Where(p => p.PurchasePrice == c.entity.PurchasePrice);
					}
					
					 if (c.entity.NontaxPurchasePrice > 0)
					{
						q = q.Where(p => p.NontaxPurchasePrice == c.entity.NontaxPurchasePrice);
					}
					
					 if (c.entity.AvgCost > 0)
					{
						q = q.Where(p => p.AvgCost == c.entity.AvgCost);
					}
					
					 if (c.entity.NontaxAvgCost > 0)
					{
						q = q.Where(p => p.NontaxAvgCost == c.entity.NontaxAvgCost);
					}
					
					 if (c.entity.GrossRate > 0)
					{
						q = q.Where(p => p.GrossRate == c.entity.GrossRate);
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
					|| l.GoodsBarCode.Contains(c.key)
					|| l.GoodsSubCode.Contains(c.key)
					|| l.GbCode.Contains(c.key)
					|| l.GmCode.Contains(c.key)
					|| l.GsCode.Contains(c.key)
					|| l.GlCode.Contains(c.key)
					|| l.GoodsType.Contains(c.key)
					|| l.CheckMode.Contains(c.key)
					|| l.SupCode.Contains(c.key)
					|| l.OpCode.Contains(c.key)
					|| l.GoodsName.Contains(c.key)
					|| l.GoodsSubName.Contains(c.key)
					|| l.PyCode.Contains(c.key)
					|| l.GoodsState.Contains(c.key)
					|| l.ProducingArea.Contains(c.key)
					|| l.ArticleNumber.Contains(c.key)
					|| l.Specification.Contains(c.key)
					|| l.ShelfLife.Contains(c.key)
					|| l.PackUnitCode.Contains(c.key)
					|| l.OfferMode.Contains(c.key)
					|| l.UnderFloorCode.Contains(c.key)
					|| l.UnderCounterCode.Contains(c.key)
					|| l.CheckUnitCode.Contains(c.key)
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
        public IList<FbGoodsArchives> Search(string key, int pageSize = 20, int pageIndex = 1)
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
					|| l.GbCode.Contains(key)
					|| l.GmCode.Contains(key)
					|| l.GsCode.Contains(key)
					|| l.GlCode.Contains(key)
					|| l.GoodsType.Contains(key)
					|| l.CheckMode.Contains(key)
					|| l.SupCode.Contains(key)
					|| l.OpCode.Contains(key)
					|| l.GoodsName.Contains(key)
					|| l.GoodsSubName.Contains(key)
					|| l.PyCode.Contains(key)
					|| l.GoodsState.Contains(key)
					|| l.ProducingArea.Contains(key)
					|| l.ArticleNumber.Contains(key)
					|| l.Specification.Contains(key)
					|| l.ShelfLife.Contains(key)
					|| l.PackUnitCode.Contains(key)
					|| l.OfferMode.Contains(key)
					|| l.UnderFloorCode.Contains(key)
					|| l.UnderCounterCode.Contains(key)
					|| l.CheckUnitCode.Contains(key)
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




