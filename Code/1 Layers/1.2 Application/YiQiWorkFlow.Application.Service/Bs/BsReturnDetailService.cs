/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:06
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public class BsReturnDetailService:IBsReturnDetailService
    {

        public IRepositoryGUID<BsReturnDetail> EntityRepository { get; set; }

        [Transaction]
        public string Create(BsReturnDetail entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public BsReturnDetail GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<BsReturnDetail> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(BsReturnDetail entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(BsReturnDetail entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<BsReturnDetail> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<BsReturnDetail> Search(SearchDtoBase<BsReturnDetail> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.ReNumber) == false)
					{
						
						q = q.Where(p => p.ReNumber.Contains(c.entity.ReNumber));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsBarCode) == false)
					{
						
						q = q.Where(p => p.GoodsBarCode.Contains(c.entity.GoodsBarCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.Specification) == false)
					{
						
						q = q.Where(p => p.Specification.Contains(c.entity.Specification));
					}
					if (string.IsNullOrEmpty(c.entity.PackUnitCode) == false)
					{
						
						q = q.Where(p => p.PackUnitCode.Contains(c.entity.PackUnitCode));
					}
					 if (c.entity.PackQty > 0)
					{
						q = q.Where(p => p.PackQty == c.entity.PackQty);
					}
					
					 if (c.entity.PackCoef > 0)
					{
						q = q.Where(p => p.PackCoef == c.entity.PackCoef);
					}
					
					 if (c.entity.ReturnQty > 0)
					{
						q = q.Where(p => p.ReturnQty == c.entity.ReturnQty);
					}
					
					 if (c.entity.SupplyPrice > 0)
					{
						q = q.Where(p => p.SupplyPrice == c.entity.SupplyPrice);
					}
					
					 if (c.entity.SupplyMoney > 0)
					{
						q = q.Where(p => p.SupplyMoney == c.entity.SupplyMoney);
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
					|| l.ReNumber.Contains(c.key)
					|| l.GoodsBarCode.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.Specification.Contains(c.key)
					|| l.PackUnitCode.Contains(c.key)
					|| l.SysGuid.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<BsReturnDetail> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.ReNumber.Contains(key)
					|| l.GoodsBarCode.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.Specification.Contains(key)
					|| l.PackUnitCode.Contains(key)
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




