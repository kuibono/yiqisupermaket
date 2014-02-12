/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:07
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public class MsExchangeManageService:IMsExchangeManageService
    {

        public IRepositoryGUID<MsExchangeManage> EntityRepository { get; set; }

        [Transaction]
        public string Create(MsExchangeManage entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public MsExchangeManage GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<MsExchangeManage> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(MsExchangeManage entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(MsExchangeManage entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<MsExchangeManage> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<MsExchangeManage> Search(SearchDtoBase<MsExchangeManage> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					 if (c.entity.ExFlowNumber > 0)
					{
						q = q.Where(p => p.ExFlowNumber == c.entity.ExFlowNumber);
					}
					
					if (string.IsNullOrEmpty(c.entity.ExchangeNumber) == false)
					{
						
						q = q.Where(p => p.ExchangeNumber.Contains(c.entity.ExchangeNumber));
					}
					if (string.IsNullOrEmpty(c.entity.CardNumber) == false)
					{
						
						q = q.Where(p => p.CardNumber.Contains(c.entity.CardNumber));
					}
					if (string.IsNullOrEmpty(c.entity.MsCode) == false)
					{
						
						q = q.Where(p => p.MsCode.Contains(c.entity.MsCode));
					}
					if (string.IsNullOrEmpty(c.entity.MsName) == false)
					{
						
						q = q.Where(p => p.MsName.Contains(c.entity.MsName));
					}
					 if (c.entity.CurrentPoints > 0)
					{
						q = q.Where(p => p.CurrentPoints == c.entity.CurrentPoints);
					}
					
					 if (c.entity.ExchangePoints > 0)
					{
						q = q.Where(p => p.ExchangePoints == c.entity.ExchangePoints);
					}
					
					 if (c.entity.SurplusPoints > 0)
					{
						q = q.Where(p => p.SurplusPoints == c.entity.SurplusPoints);
					}
					
					if (string.IsNullOrEmpty(c.entity.Operator) == false)
					{
						
						q = q.Where(p => p.Operator.Contains(c.entity.Operator));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.ExchangeNumber.Contains(c.key)
					|| l.CardNumber.Contains(c.key)
					|| l.MsCode.Contains(c.key)
					|| l.MsName.Contains(c.key)
					|| l.Operator.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<MsExchangeManage> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.ExchangeNumber.Contains(key)
					|| l.CardNumber.Contains(key)
					|| l.MsCode.Contains(key)
					|| l.MsName.Contains(key)
					|| l.Operator.Contains(key)
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




