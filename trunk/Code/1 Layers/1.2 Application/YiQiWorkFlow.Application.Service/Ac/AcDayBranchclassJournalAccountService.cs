/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:49
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public class AcDayBranchclassJournalAccountService:IAcDayBranchclassJournalAccountService
    {

        public IRepository<AcDayBranchclassJournalAccount> EntityRepository { get; set; }

        [Transaction]
        public int Create(AcDayBranchclassJournalAccount entity)
        {
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public AcDayBranchclassJournalAccount GetById(int id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<AcDayBranchclassJournalAccount> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(AcDayBranchclassJournalAccount entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(AcDayBranchclassJournalAccount entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<AcDayBranchclassJournalAccount> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<AcDayBranchclassJournalAccount> Search(SearchDtoBase<AcDayBranchclassJournalAccount> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
					if (string.IsNullOrEmpty(c.entity.AcDate) == false)
					{
						q = q.Where(p => p.AcDate.Contains(c.entity.AcDate));
					}
					if (string.IsNullOrEmpty(c.entity.bCode) == false)
					{
						q = q.Where(p => p.bCode.Contains(c.entity.bCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsClassCode) == false)
					{
						q = q.Where(p => p.GoodsClassCode.Contains(c.entity.GoodsClassCode));
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
					
					 if (c.entity.SupplyQty > 0)
					{
						q = q.Where(p => p.SupplyQty == c.entity.SupplyQty);
					}
					
					 if (c.entity.SupplyMoney > 0)
					{
						q = q.Where(p => p.SupplyMoney == c.entity.SupplyMoney);
					}
					
					 if (c.entity.NontaxSupplyMoney > 0)
					{
						q = q.Where(p => p.NontaxSupplyMoney == c.entity.NontaxSupplyMoney);
					}
					
					 if (c.entity.SpReturnQty > 0)
					{
						q = q.Where(p => p.SpReturnQty == c.entity.SpReturnQty);
					}
					
					 if (c.entity.SpReturnMoney > 0)
					{
						q = q.Where(p => p.SpReturnMoney == c.entity.SpReturnMoney);
					}
					
					 if (c.entity.NontaxSpReturnMoney > 0)
					{
						q = q.Where(p => p.NontaxSpReturnMoney == c.entity.NontaxSpReturnMoney);
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
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.AcDate.Contains(c.key)
					|| l.bCode.Contains(c.key)
					|| l.GoodsClassCode.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<AcDayBranchclassJournalAccount> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.AcDate.Contains(key)
					|| l.bCode.Contains(key)
					|| l.GoodsClassCode.Contains(key)
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




