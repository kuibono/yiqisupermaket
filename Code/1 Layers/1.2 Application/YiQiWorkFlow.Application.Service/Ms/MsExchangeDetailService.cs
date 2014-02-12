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
    public class MsExchangeDetailService:IMsExchangeDetailService
    {

        public IRepositoryGUID<MsExchangeDetail> EntityRepository { get; set; }

        [Transaction]
        public string Create(MsExchangeDetail entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public MsExchangeDetail GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<MsExchangeDetail> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(MsExchangeDetail entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(MsExchangeDetail entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<MsExchangeDetail> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<MsExchangeDetail> Search(SearchDtoBase<MsExchangeDetail> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.ExchangeNumber) == false)
					{
						
						q = q.Where(p => p.ExchangeNumber.Contains(c.entity.ExchangeNumber));
					}
					 if (c.entity.sNumber > 0)
					{
						q = q.Where(p => p.sNumber == c.entity.sNumber);
					}
					
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsName) == false)
					{
						
						q = q.Where(p => p.GoodsName.Contains(c.entity.GoodsName));
					}
					 if (c.entity.ExchangeQty > 0)
					{
						q = q.Where(p => p.ExchangeQty == c.entity.ExchangeQty);
					}
					
					 if (c.entity.ExchangePoints > 0)
					{
						q = q.Where(p => p.ExchangePoints == c.entity.ExchangePoints);
					}
					
					 if (c.entity.PointsTotal > 0)
					{
						q = q.Where(p => p.PointsTotal == c.entity.PointsTotal);
					}
					
					 if (c.entity.GrossMoney > 0)
					{
						q = q.Where(p => p.GrossMoney == c.entity.GrossMoney);
					}
					
					 if (c.entity.NontaxGrossMoney > 0)
					{
						q = q.Where(p => p.NontaxGrossMoney == c.entity.NontaxGrossMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.SysGuid) == false)
					{
						
						q = q.Where(p => p.SysGuid.Contains(c.entity.SysGuid));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.ExchangeNumber.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.GoodsName.Contains(c.key)
					|| l.SysGuid.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<MsExchangeDetail> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.ExchangeNumber.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.GoodsName.Contains(key)
					|| l.SysGuid.Contains(key)
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




