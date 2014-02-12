/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:07
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public class TgTravelArchivesPushtacService:ITgTravelArchivesPushtacService
    {

        public IRepositoryGUID<TgTravelArchivesPushtac> EntityRepository { get; set; }

        [Transaction]
        public string Create(TgTravelArchivesPushtac entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public TgTravelArchivesPushtac GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<TgTravelArchivesPushtac> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(TgTravelArchivesPushtac entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(TgTravelArchivesPushtac entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<TgTravelArchivesPushtac> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<TgTravelArchivesPushtac> Search(SearchDtoBase<TgTravelArchivesPushtac> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.TaCode) == false)
					{
						
						q = q.Where(p => p.TaCode.Contains(c.entity.TaCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsClassCode) == false)
					{
						
						q = q.Where(p => p.GoodsClassCode.Contains(c.entity.GoodsClassCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsClassName) == false)
					{
						
						q = q.Where(p => p.GoodsClassName.Contains(c.entity.GoodsClassName));
					}
					 if (c.entity.PushRate > 0)
					{
						q = q.Where(p => p.PushRate == c.entity.PushRate);
					}
					
					 if (c.entity.AccountRate > 0)
					{
						q = q.Where(p => p.AccountRate == c.entity.AccountRate);
					}
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.TaCode.Contains(c.key)
					|| l.GoodsClassCode.Contains(c.key)
					|| l.GoodsClassName.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<TgTravelArchivesPushtac> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.TaCode.Contains(key)
					|| l.GoodsClassCode.Contains(key)
					|| l.GoodsClassName.Contains(key)
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




