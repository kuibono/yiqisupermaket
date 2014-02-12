/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:07
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Ws;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ws
{
    public class WsPaCustomerTypeService:IWsPaCustomerTypeService
    {

        public IRepositoryGUID<WsPaCustomerType> EntityRepository { get; set; }

        [Transaction]
        public string Create(WsPaCustomerType entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public WsPaCustomerType GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<WsPaCustomerType> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(WsPaCustomerType entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(WsPaCustomerType entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<WsPaCustomerType> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<WsPaCustomerType> Search(SearchDtoBase<WsPaCustomerType> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.CustTypeCode) == false)
					{
						
						q = q.Where(p => p.CustTypeCode.Contains(c.entity.CustTypeCode));
					}
					if (string.IsNullOrEmpty(c.entity.CustTypeName) == false)
					{
						
						q = q.Where(p => p.CustTypeName.Contains(c.entity.CustTypeName));
					}
					if (string.IsNullOrEmpty(c.entity.WsType) == false)
					{
						
						q = q.Where(p => p.WsType.Contains(c.entity.WsType));
					}
					 if (c.entity.DiscountRate > 0)
					{
						q = q.Where(p => p.DiscountRate == c.entity.DiscountRate);
					}
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.CustTypeCode.Contains(c.key)
					|| l.CustTypeName.Contains(c.key)
					|| l.WsType.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<WsPaCustomerType> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.CustTypeCode.Contains(key)
					|| l.CustTypeName.Contains(key)
					|| l.WsType.Contains(key)
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




