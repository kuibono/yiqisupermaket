/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:06
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public class FbPaBaseSetService:IFbPaBaseSetService
    {

        public IRepositoryGUID<FbPaBaseSet> EntityRepository { get; set; }

        [Transaction]
        public string Create(FbPaBaseSet entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public FbPaBaseSet GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<FbPaBaseSet> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(FbPaBaseSet entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(FbPaBaseSet entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<FbPaBaseSet> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<FbPaBaseSet> Search(SearchDtoBase<FbPaBaseSet> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					 if (c.entity.GoodsGbLen > 0)
					{
						q = q.Where(p => p.GoodsGbLen == c.entity.GoodsGbLen);
					}
					
					 if (c.entity.GoodsGmLen > 0)
					{
						q = q.Where(p => p.GoodsGmLen == c.entity.GoodsGmLen);
					}
					
					 if (c.entity.GoodsGsLen > 0)
					{
						q = q.Where(p => p.GoodsGsLen == c.entity.GoodsGsLen);
					}
					
					 if (c.entity.GoodsGlLen > 0)
					{
						q = q.Where(p => p.GoodsGlLen == c.entity.GoodsGlLen);
					}
					
					 if (c.entity.GoodsClassLevel > 0)
					{
						q = q.Where(p => p.GoodsClassLevel == c.entity.GoodsClassLevel);
					}
					
					 if (c.entity.GoodsLen > 0)
					{
						q = q.Where(p => p.GoodsLen == c.entity.GoodsLen);
					}
					
					if (string.IsNullOrEmpty(c.entity.GoodsPrefix) == false)
					{
						
						q = q.Where(p => p.GoodsPrefix.Contains(c.entity.GoodsPrefix));
					}
					 if (c.entity.SupLen > 0)
					{
						q = q.Where(p => p.SupLen == c.entity.SupLen);
					}
					
					if (string.IsNullOrEmpty(c.entity.SupPrefixType) == false)
					{
						
						q = q.Where(p => p.SupPrefixType.Contains(c.entity.SupPrefixType));
					}
					if (string.IsNullOrEmpty(c.entity.SupPrefixContent) == false)
					{
						
						q = q.Where(p => p.SupPrefixContent.Contains(c.entity.SupPrefixContent));
					}
					 if (c.entity.PurchasePreciseLen > 0)
					{
						q = q.Where(p => p.PurchasePreciseLen == c.entity.PurchasePreciseLen);
					}
					
					 if (c.entity.SalePreciseLen > 0)
					{
						q = q.Where(p => p.SalePreciseLen == c.entity.SalePreciseLen);
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
					|| l.GoodsPrefix.Contains(c.key)
					|| l.SupPrefixType.Contains(c.key)
					|| l.SupPrefixContent.Contains(c.key)
					|| l.Operator.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<FbPaBaseSet> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.GoodsPrefix.Contains(key)
					|| l.SupPrefixType.Contains(key)
					|| l.SupPrefixContent.Contains(key)
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




