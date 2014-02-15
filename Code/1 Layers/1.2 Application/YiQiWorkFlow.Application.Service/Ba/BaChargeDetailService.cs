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
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public class BaChargeDetailService:IBaChargeDetailService
    {

        public IRepository<BaChargeDetail> EntityRepository { get; set; }

        [Transaction]
        public int Create(BaChargeDetail entity)
        {
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public BaChargeDetail GetById(int id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<BaChargeDetail> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(BaChargeDetail entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(BaChargeDetail entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<BaChargeDetail> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<BaChargeDetail> Search(SearchDtoBase<BaChargeDetail> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
					if (string.IsNullOrEmpty(c.entity.ChargeNumber) == false)
					{
						q = q.Where(p => p.ChargeNumber.Contains(c.entity.ChargeNumber));
					}
					if (string.IsNullOrEmpty(c.entity.ChargeCode) == false)
					{
						q = q.Where(p => p.ChargeCode.Contains(c.entity.ChargeCode));
					}
					if (string.IsNullOrEmpty(c.entity.ChargeName) == false)
					{
						q = q.Where(p => p.ChargeName.Contains(c.entity.ChargeName));
					}
					 if (c.entity.ChargeStandard > 0)
					{
						q = q.Where(p => p.ChargeStandard == c.entity.ChargeStandard);
					}
					
					if (string.IsNullOrEmpty(c.entity.Comment) == false)
					{
						q = q.Where(p => p.Comment.Contains(c.entity.Comment));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.ChargeNumber.Contains(c.key)
					|| l.ChargeCode.Contains(c.key)
					|| l.ChargeName.Contains(c.key)
					|| l.Comment.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<BaChargeDetail> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.ChargeNumber.Contains(key)
					|| l.ChargeCode.Contains(key)
					|| l.ChargeName.Contains(key)
					|| l.Comment.Contains(key)
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




