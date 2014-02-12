/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:06
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public class BaOfferAccountService:IBaOfferAccountService
    {

        public IRepositoryGUID<BaOfferAccount> EntityRepository { get; set; }

        [Transaction]
        public string Create(BaOfferAccount entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public BaOfferAccount GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<BaOfferAccount> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(BaOfferAccount entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(BaOfferAccount entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<BaOfferAccount> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<BaOfferAccount> Search(SearchDtoBase<BaOfferAccount> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.EnCode) == false)
					{
						
						q = q.Where(p => p.EnCode.Contains(c.entity.EnCode));
					}
					if (string.IsNullOrEmpty(c.entity.SupCode) == false)
					{
						
						q = q.Where(p => p.SupCode.Contains(c.entity.SupCode));
					}
					 if (c.entity.AccountMoney > 0)
					{
						q = q.Where(p => p.AccountMoney == c.entity.AccountMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.IfAblebalance) == false)
					{
						
						q = q.Where(p => p.IfAblebalance.Contains(c.entity.IfAblebalance));
					}
					if (string.IsNullOrEmpty(c.entity.IfBalance) == false)
					{
						
						q = q.Where(p => p.IfBalance.Contains(c.entity.IfBalance));
					}
					if (string.IsNullOrEmpty(c.entity.BaNumber) == false)
					{
						
						q = q.Where(p => p.BaNumber.Contains(c.entity.BaNumber));
					}
					 if (c.entity.BaMoney > 0)
					{
						q = q.Where(p => p.BaMoney == c.entity.BaMoney);
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
					|| l.EnCode.Contains(c.key)
					|| l.SupCode.Contains(c.key)
					|| l.IfAblebalance.Contains(c.key)
					|| l.IfBalance.Contains(c.key)
					|| l.BaNumber.Contains(c.key)
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
        public IList<BaOfferAccount> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.AcNumber.Contains(key)
					|| l.EnCode.Contains(key)
					|| l.SupCode.Contains(key)
					|| l.IfAblebalance.Contains(key)
					|| l.IfBalance.Contains(key)
					|| l.BaNumber.Contains(key)
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




