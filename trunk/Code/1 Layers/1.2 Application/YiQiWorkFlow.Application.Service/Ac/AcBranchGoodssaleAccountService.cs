/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:06
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public class AcBranchGoodssaleAccountService:IAcBranchGoodssaleAccountService
    {

        public IRepositoryGUID<AcBranchGoodssaleAccount> EntityRepository { get; set; }

        [Transaction]
        public string Create(AcBranchGoodssaleAccount entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public AcBranchGoodssaleAccount GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<AcBranchGoodssaleAccount> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(AcBranchGoodssaleAccount entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(AcBranchGoodssaleAccount entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<AcBranchGoodssaleAccount> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<AcBranchGoodssaleAccount> Search(SearchDtoBase<AcBranchGoodssaleAccount> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					 if (c.entity.RtFlowNumber > 0)
					{
						q = q.Where(p => p.RtFlowNumber == c.entity.RtFlowNumber);
					}
					
					if (string.IsNullOrEmpty(c.entity.EnCode) == false)
					{
						
						q = q.Where(p => p.EnCode.Contains(c.entity.EnCode));
					}
					if (string.IsNullOrEmpty(c.entity.bCode) == false)
					{
						
						q = q.Where(p => p.bCode.Contains(c.entity.bCode));
					}
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					if (string.IsNullOrEmpty(c.entity.RtDate) == false)
					{
						
						q = q.Where(p => p.RtDate.Contains(c.entity.RtDate));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsBarCode) == false)
					{
						
						q = q.Where(p => p.GoodsBarCode.Contains(c.entity.GoodsBarCode));
					}
					if (string.IsNullOrEmpty(c.entity.OpCode) == false)
					{
						
						q = q.Where(p => p.OpCode.Contains(c.entity.OpCode));
					}
					 if (c.entity.SalePrice > 0)
					{
						q = q.Where(p => p.SalePrice == c.entity.SalePrice);
					}
					
					 if (c.entity.SaleQty > 0)
					{
						q = q.Where(p => p.SaleQty == c.entity.SaleQty);
					}
					
					 if (c.entity.SaleMoney > 0)
					{
						q = q.Where(p => p.SaleMoney == c.entity.SaleMoney);
					}
					
					 if (c.entity.DiscountMoney > 0)
					{
						q = q.Where(p => p.DiscountMoney == c.entity.DiscountMoney);
					}
					
					 if (c.entity.NontaxSaleMoney > 0)
					{
						q = q.Where(p => p.NontaxSaleMoney == c.entity.NontaxSaleMoney);
					}
					
					 if (c.entity.PurchasePrice > 0)
					{
						q = q.Where(p => p.PurchasePrice == c.entity.PurchasePrice);
					}
					
					 if (c.entity.NontaxPurchasePrice > 0)
					{
						q = q.Where(p => p.NontaxPurchasePrice == c.entity.NontaxPurchasePrice);
					}
					
					 if (c.entity.CostMoney > 0)
					{
						q = q.Where(p => p.CostMoney == c.entity.CostMoney);
					}
					
					 if (c.entity.NontaxCostMoney > 0)
					{
						q = q.Where(p => p.NontaxCostMoney == c.entity.NontaxCostMoney);
					}
					
					 if (c.entity.GrossMoney > 0)
					{
						q = q.Where(p => p.GrossMoney == c.entity.GrossMoney);
					}
					
					 if (c.entity.NontaxGrossMoney > 0)
					{
						q = q.Where(p => p.NontaxGrossMoney == c.entity.NontaxGrossMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.SupCode) == false)
					{
						
						q = q.Where(p => p.SupCode.Contains(c.entity.SupCode));
					}
					 if (c.entity.PoolRate > 0)
					{
						q = q.Where(p => p.PoolRate == c.entity.PoolRate);
					}
					
					 if (c.entity.OutputTax > 0)
					{
						q = q.Where(p => p.OutputTax == c.entity.OutputTax);
					}
					
					if (string.IsNullOrEmpty(c.entity.IfPromotion) == false)
					{
						
						q = q.Where(p => p.IfPromotion.Contains(c.entity.IfPromotion));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.EnCode.Contains(c.key)
					|| l.bCode.Contains(c.key)
					|| l.WhCode.Contains(c.key)
					|| l.RtDate.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.GoodsBarCode.Contains(c.key)
					|| l.OpCode.Contains(c.key)
					|| l.SupCode.Contains(c.key)
					|| l.IfPromotion.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<AcBranchGoodssaleAccount> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.Id.Contains(key)
					|| l.EnCode.Contains(key)
					|| l.bCode.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.RtDate.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.GoodsBarCode.Contains(key)
					|| l.OpCode.Contains(key)
					|| l.SupCode.Contains(key)
					|| l.IfPromotion.Contains(key)
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




