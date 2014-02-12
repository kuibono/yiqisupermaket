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
    public class MsUpgradeCardDetailService:IMsUpgradeCardDetailService
    {

        public IRepositoryGUID<MsUpgradeCardDetail> EntityRepository { get; set; }

        [Transaction]
        public string Create(MsUpgradeCardDetail entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public MsUpgradeCardDetail GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<MsUpgradeCardDetail> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(MsUpgradeCardDetail entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(MsUpgradeCardDetail entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<MsUpgradeCardDetail> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<MsUpgradeCardDetail> Search(SearchDtoBase<MsUpgradeCardDetail> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.UpgradeNumber) == false)
					{
						
						q = q.Where(p => p.UpgradeNumber.Contains(c.entity.UpgradeNumber));
					}
					if (string.IsNullOrEmpty(c.entity.CardNumber) == false)
					{
						
						q = q.Where(p => p.CardNumber.Contains(c.entity.CardNumber));
					}
					if (string.IsNullOrEmpty(c.entity.SurfaceNumber) == false)
					{
						
						q = q.Where(p => p.SurfaceNumber.Contains(c.entity.SurfaceNumber));
					}
					if (string.IsNullOrEmpty(c.entity.CardCodeOld) == false)
					{
						
						q = q.Where(p => p.CardCodeOld.Contains(c.entity.CardCodeOld));
					}
					if (string.IsNullOrEmpty(c.entity.CardNameOld) == false)
					{
						
						q = q.Where(p => p.CardNameOld.Contains(c.entity.CardNameOld));
					}
					if (string.IsNullOrEmpty(c.entity.CardCode) == false)
					{
						
						q = q.Where(p => p.CardCode.Contains(c.entity.CardCode));
					}
					if (string.IsNullOrEmpty(c.entity.CardName) == false)
					{
						
						q = q.Where(p => p.CardName.Contains(c.entity.CardName));
					}
					 if (c.entity.DeductPoints > 0)
					{
						q = q.Where(p => p.DeductPoints == c.entity.DeductPoints);
					}
					
					 if (c.entity.TotalPoints > 0)
					{
						q = q.Where(p => p.TotalPoints == c.entity.TotalPoints);
					}
					
					 if (c.entity.ExchangePoints > 0)
					{
						q = q.Where(p => p.ExchangePoints == c.entity.ExchangePoints);
					}
					
					 if (c.entity.CurrentPoints > 0)
					{
						q = q.Where(p => p.CurrentPoints == c.entity.CurrentPoints);
					}
					
					 if (c.entity.ClearPoints > 0)
					{
						q = q.Where(p => p.ClearPoints == c.entity.ClearPoints);
					}
					
					if (string.IsNullOrEmpty(c.entity.CardState) == false)
					{
						
						q = q.Where(p => p.CardState.Contains(c.entity.CardState));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.UpgradeNumber.Contains(c.key)
					|| l.CardNumber.Contains(c.key)
					|| l.SurfaceNumber.Contains(c.key)
					|| l.CardCodeOld.Contains(c.key)
					|| l.CardNameOld.Contains(c.key)
					|| l.CardCode.Contains(c.key)
					|| l.CardName.Contains(c.key)
					|| l.CardState.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<MsUpgradeCardDetail> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.UpgradeNumber.Contains(key)
					|| l.CardNumber.Contains(key)
					|| l.SurfaceNumber.Contains(key)
					|| l.CardCodeOld.Contains(key)
					|| l.CardNameOld.Contains(key)
					|| l.CardCode.Contains(key)
					|| l.CardName.Contains(key)
					|| l.CardState.Contains(key)
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




