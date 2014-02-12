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
    public class AcDayGoodsstockJournalAccountService:IAcDayGoodsstockJournalAccountService
    {

        public IRepositoryGUID<AcDayGoodsstockJournalAccount> EntityRepository { get; set; }

        [Transaction]
        public string Create(AcDayGoodsstockJournalAccount entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public AcDayGoodsstockJournalAccount GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<AcDayGoodsstockJournalAccount> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(AcDayGoodsstockJournalAccount entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(AcDayGoodsstockJournalAccount entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<AcDayGoodsstockJournalAccount> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<AcDayGoodsstockJournalAccount> Search(SearchDtoBase<AcDayGoodsstockJournalAccount> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					 if (c.entity.AcFlowNumber > 0)
					{
						q = q.Where(p => p.AcFlowNumber == c.entity.AcFlowNumber);
					}
					
					if (string.IsNullOrEmpty(c.entity.AcDate) == false)
					{
						
						q = q.Where(p => p.AcDate.Contains(c.entity.AcDate));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.OpCode) == false)
					{
						
						q = q.Where(p => p.OpCode.Contains(c.entity.OpCode));
					}
					 if (c.entity.PurchasePrice > 0)
					{
						q = q.Where(p => p.PurchasePrice == c.entity.PurchasePrice);
					}
					
					 if (c.entity.NontaxPurchasePrice > 0)
					{
						q = q.Where(p => p.NontaxPurchasePrice == c.entity.NontaxPurchasePrice);
					}
					
					 if (c.entity.SalePrice > 0)
					{
						q = q.Where(p => p.SalePrice == c.entity.SalePrice);
					}
					
					 if (c.entity.InitQty > 0)
					{
						q = q.Where(p => p.InitQty == c.entity.InitQty);
					}
					
					 if (c.entity.InitMoney > 0)
					{
						q = q.Where(p => p.InitMoney == c.entity.InitMoney);
					}
					
					 if (c.entity.InitSaleMoney > 0)
					{
						q = q.Where(p => p.InitSaleMoney == c.entity.InitSaleMoney);
					}
					
					 if (c.entity.PurchaseQty > 0)
					{
						q = q.Where(p => p.PurchaseQty == c.entity.PurchaseQty);
					}
					
					 if (c.entity.PurchaseMoney > 0)
					{
						q = q.Where(p => p.PurchaseMoney == c.entity.PurchaseMoney);
					}
					
					 if (c.entity.PurchaseSaleMoney > 0)
					{
						q = q.Where(p => p.PurchaseSaleMoney == c.entity.PurchaseSaleMoney);
					}
					
					 if (c.entity.ReturnQty > 0)
					{
						q = q.Where(p => p.ReturnQty == c.entity.ReturnQty);
					}
					
					 if (c.entity.ReturnMoney > 0)
					{
						q = q.Where(p => p.ReturnMoney == c.entity.ReturnMoney);
					}
					
					 if (c.entity.ReturnSaleMoney > 0)
					{
						q = q.Where(p => p.ReturnSaleMoney == c.entity.ReturnSaleMoney);
					}
					
					 if (c.entity.SaleQty > 0)
					{
						q = q.Where(p => p.SaleQty == c.entity.SaleQty);
					}
					
					 if (c.entity.SaleMoney > 0)
					{
						q = q.Where(p => p.SaleMoney == c.entity.SaleMoney);
					}
					
					 if (c.entity.NontaxSaleMoney > 0)
					{
						q = q.Where(p => p.NontaxSaleMoney == c.entity.NontaxSaleMoney);
					}
					
					 if (c.entity.SupplyQty > 0)
					{
						q = q.Where(p => p.SupplyQty == c.entity.SupplyQty);
					}
					
					 if (c.entity.SupplyMoney > 0)
					{
						q = q.Where(p => p.SupplyMoney == c.entity.SupplyMoney);
					}
					
					 if (c.entity.SupplySaleMoney > 0)
					{
						q = q.Where(p => p.SupplySaleMoney == c.entity.SupplySaleMoney);
					}
					
					 if (c.entity.SreturnQty > 0)
					{
						q = q.Where(p => p.SreturnQty == c.entity.SreturnQty);
					}
					
					 if (c.entity.SreturnMoney > 0)
					{
						q = q.Where(p => p.SreturnMoney == c.entity.SreturnMoney);
					}
					
					 if (c.entity.SreturnSaleMoney > 0)
					{
						q = q.Where(p => p.SreturnSaleMoney == c.entity.SreturnSaleMoney);
					}
					
					 if (c.entity.LossQty > 0)
					{
						q = q.Where(p => p.LossQty == c.entity.LossQty);
					}
					
					 if (c.entity.LossMoney > 0)
					{
						q = q.Where(p => p.LossMoney == c.entity.LossMoney);
					}
					
					 if (c.entity.LossSaleMoney > 0)
					{
						q = q.Where(p => p.LossSaleMoney == c.entity.LossSaleMoney);
					}
					
					 if (c.entity.AdjustQty > 0)
					{
						q = q.Where(p => p.AdjustQty == c.entity.AdjustQty);
					}
					
					 if (c.entity.AdjustMoney > 0)
					{
						q = q.Where(p => p.AdjustMoney == c.entity.AdjustMoney);
					}
					
					 if (c.entity.AdjustSaleMoney > 0)
					{
						q = q.Where(p => p.AdjustSaleMoney == c.entity.AdjustSaleMoney);
					}
					
					 if (c.entity.GrossMoney > 0)
					{
						q = q.Where(p => p.GrossMoney == c.entity.GrossMoney);
					}
					
					 if (c.entity.NontaxGrossMoney > 0)
					{
						q = q.Where(p => p.NontaxGrossMoney == c.entity.NontaxGrossMoney);
					}
					
					 if (c.entity.AdjustsaleMoney > 0)
					{
						q = q.Where(p => p.AdjustsaleMoney == c.entity.AdjustsaleMoney);
					}
					
					 if (c.entity.StockQty > 0)
					{
						q = q.Where(p => p.StockQty == c.entity.StockQty);
					}
					
					 if (c.entity.StockMoney > 0)
					{
						q = q.Where(p => p.StockMoney == c.entity.StockMoney);
					}
					
					 if (c.entity.StockSaleMoney > 0)
					{
						q = q.Where(p => p.StockSaleMoney == c.entity.StockSaleMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.SupCode) == false)
					{
						
						q = q.Where(p => p.SupCode.Contains(c.entity.SupCode));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.AcDate.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.OpCode.Contains(c.key)
					|| l.SupCode.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<AcDayGoodsstockJournalAccount> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.AcDate.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.OpCode.Contains(key)
					|| l.SupCode.Contains(key)
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




