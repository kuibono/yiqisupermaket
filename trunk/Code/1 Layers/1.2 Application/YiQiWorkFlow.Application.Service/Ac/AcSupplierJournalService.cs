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
    public class AcSupplierJournalService:IAcSupplierJournalService
    {

        public IRepositoryGUID<AcSupplierJournal> EntityRepository { get; set; }

        [Transaction]
        public string Create(AcSupplierJournal entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public AcSupplierJournal GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<AcSupplierJournal> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(AcSupplierJournal entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(AcSupplierJournal entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<AcSupplierJournal> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<AcSupplierJournal> Search(SearchDtoBase<AcSupplierJournal> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					 if (c.entity.SupFlowNumber > 0)
					{
						q = q.Where(p => p.SupFlowNumber == c.entity.SupFlowNumber);
					}
					
					if (string.IsNullOrEmpty(c.entity.SupCode) == false)
					{
						
						q = q.Where(p => p.SupCode.Contains(c.entity.SupCode));
					}
					if (string.IsNullOrEmpty(c.entity.AcDate) == false)
					{
						
						q = q.Where(p => p.AcDate.Contains(c.entity.AcDate));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsBarCode) == false)
					{
						
						q = q.Where(p => p.GoodsBarCode.Contains(c.entity.GoodsBarCode));
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
					
					 if (c.entity.GrossMoney > 0)
					{
						q = q.Where(p => p.GrossMoney == c.entity.GrossMoney);
					}
					
					 if (c.entity.NontaxGrossMoney > 0)
					{
						q = q.Where(p => p.NontaxGrossMoney == c.entity.NontaxGrossMoney);
					}
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.SupCode.Contains(c.key)
					|| l.AcDate.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.GoodsBarCode.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<AcSupplierJournal> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.SupCode.Contains(key)
					|| l.AcDate.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.GoodsBarCode.Contains(key)
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




