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
    public class AcDayGoodsJournalAccountService:IAcDayGoodsJournalAccountService
    {

        public IRepositoryGUID<AcDayGoodsJournalAccount> EntityRepository { get; set; }

        [Transaction]
        public string Create(AcDayGoodsJournalAccount entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public AcDayGoodsJournalAccount GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<AcDayGoodsJournalAccount> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(AcDayGoodsJournalAccount entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(AcDayGoodsJournalAccount entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<AcDayGoodsJournalAccount> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<AcDayGoodsJournalAccount> Search(SearchDtoBase<AcDayGoodsJournalAccount> c)
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
					
					 if (c.entity.InitQty > 0)
					{
						q = q.Where(p => p.InitQty == c.entity.InitQty);
					}
					
					 if (c.entity.InitMoney > 0)
					{
						q = q.Where(p => p.InitMoney == c.entity.InitMoney);
					}
					
					 if (c.entity.NontaxInitMoney > 0)
					{
						q = q.Where(p => p.NontaxInitMoney == c.entity.NontaxInitMoney);
					}
					
					 if (c.entity.PurchaseQty > 0)
					{
						q = q.Where(p => p.PurchaseQty == c.entity.PurchaseQty);
					}
					
					 if (c.entity.PurchaseMoney > 0)
					{
						q = q.Where(p => p.PurchaseMoney == c.entity.PurchaseMoney);
					}
					
					 if (c.entity.NontaxPurchaseMoney > 0)
					{
						q = q.Where(p => p.NontaxPurchaseMoney == c.entity.NontaxPurchaseMoney);
					}
					
					 if (c.entity.ReturnQty > 0)
					{
						q = q.Where(p => p.ReturnQty == c.entity.ReturnQty);
					}
					
					 if (c.entity.ReturnMoney > 0)
					{
						q = q.Where(p => p.ReturnMoney == c.entity.ReturnMoney);
					}
					
					 if (c.entity.NontaxReturnMoney > 0)
					{
						q = q.Where(p => p.NontaxReturnMoney == c.entity.NontaxReturnMoney);
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
					
					 if (c.entity.AlinQty > 0)
					{
						q = q.Where(p => p.AlinQty == c.entity.AlinQty);
					}
					
					 if (c.entity.AlinMoney > 0)
					{
						q = q.Where(p => p.AlinMoney == c.entity.AlinMoney);
					}
					
					 if (c.entity.NontaxAlinMoney > 0)
					{
						q = q.Where(p => p.NontaxAlinMoney == c.entity.NontaxAlinMoney);
					}
					
					 if (c.entity.AloutQty > 0)
					{
						q = q.Where(p => p.AloutQty == c.entity.AloutQty);
					}
					
					 if (c.entity.AloutMoney > 0)
					{
						q = q.Where(p => p.AloutMoney == c.entity.AloutMoney);
					}
					
					 if (c.entity.NontaxAloutMoney > 0)
					{
						q = q.Where(p => p.NontaxAloutMoney == c.entity.NontaxAloutMoney);
					}
					
					 if (c.entity.LossQty > 0)
					{
						q = q.Where(p => p.LossQty == c.entity.LossQty);
					}
					
					 if (c.entity.LossMoney > 0)
					{
						q = q.Where(p => p.LossMoney == c.entity.LossMoney);
					}
					
					 if (c.entity.NontaxLossMoney > 0)
					{
						q = q.Where(p => p.NontaxLossMoney == c.entity.NontaxLossMoney);
					}
					
					 if (c.entity.AdjustQty > 0)
					{
						q = q.Where(p => p.AdjustQty == c.entity.AdjustQty);
					}
					
					 if (c.entity.AdjustMoney > 0)
					{
						q = q.Where(p => p.AdjustMoney == c.entity.AdjustMoney);
					}
					
					 if (c.entity.NontaxAdjustMoney > 0)
					{
						q = q.Where(p => p.NontaxAdjustMoney == c.entity.NontaxAdjustMoney);
					}
					
					 if (c.entity.GrossMoney > 0)
					{
						q = q.Where(p => p.GrossMoney == c.entity.GrossMoney);
					}
					
					 if (c.entity.NontaxGrossMoney > 0)
					{
						q = q.Where(p => p.NontaxGrossMoney == c.entity.NontaxGrossMoney);
					}
					
					 if (c.entity.StockQty > 0)
					{
						q = q.Where(p => p.StockQty == c.entity.StockQty);
					}
					
					 if (c.entity.StockMoney > 0)
					{
						q = q.Where(p => p.StockMoney == c.entity.StockMoney);
					}
					
					 if (c.entity.NontaxStockMoney > 0)
					{
						q = q.Where(p => p.NontaxStockMoney == c.entity.NontaxStockMoney);
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
        public IList<AcDayGoodsJournalAccount> Search(string key, int pageSize = 20, int pageIndex = 1)
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




