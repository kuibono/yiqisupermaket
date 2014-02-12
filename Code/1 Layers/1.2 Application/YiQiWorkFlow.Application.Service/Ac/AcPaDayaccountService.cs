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
    public class AcPaDayaccountService:IAcPaDayaccountService
    {

        public IRepositoryGUID<AcPaDayaccount> EntityRepository { get; set; }

        [Transaction]
        public string Create(AcPaDayaccount entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public AcPaDayaccount GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<AcPaDayaccount> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(AcPaDayaccount entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(AcPaDayaccount entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<AcPaDayaccount> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<AcPaDayaccount> Search(SearchDtoBase<AcPaDayaccount> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					 if (c.entity.LastRtFlowNumber > 0)
					{
						q = q.Where(p => p.LastRtFlowNumber == c.entity.LastRtFlowNumber);
					}
					
					 if (c.entity.CurrentRtFlowNumber > 0)
					{
						q = q.Where(p => p.CurrentRtFlowNumber == c.entity.CurrentRtFlowNumber);
					}
					
					 if (c.entity.LastWsFlowNumber > 0)
					{
						q = q.Where(p => p.LastWsFlowNumber == c.entity.LastWsFlowNumber);
					}
					
					 if (c.entity.CurrentWsFlowNumber > 0)
					{
						q = q.Where(p => p.CurrentWsFlowNumber == c.entity.CurrentWsFlowNumber);
					}
					
					 if (c.entity.LastPiFlowNumber > 0)
					{
						q = q.Where(p => p.LastPiFlowNumber == c.entity.LastPiFlowNumber);
					}
					
					 if (c.entity.CurrentPiFlowNumber > 0)
					{
						q = q.Where(p => p.CurrentPiFlowNumber == c.entity.CurrentPiFlowNumber);
					}
					
					 if (c.entity.LastPoFlowNumber > 0)
					{
						q = q.Where(p => p.LastPoFlowNumber == c.entity.LastPoFlowNumber);
					}
					
					 if (c.entity.CurrentPoFlowNumber > 0)
					{
						q = q.Where(p => p.CurrentPoFlowNumber == c.entity.CurrentPoFlowNumber);
					}
					
					 if (c.entity.LastAlFlowNumber > 0)
					{
						q = q.Where(p => p.LastAlFlowNumber == c.entity.LastAlFlowNumber);
					}
					
					 if (c.entity.CurrentAlFlowNumber > 0)
					{
						q = q.Where(p => p.CurrentAlFlowNumber == c.entity.CurrentAlFlowNumber);
					}
					
					 if (c.entity.LastLoFlowNumber > 0)
					{
						q = q.Where(p => p.LastLoFlowNumber == c.entity.LastLoFlowNumber);
					}
					
					 if (c.entity.CurrentLoFlowNumber > 0)
					{
						q = q.Where(p => p.CurrentLoFlowNumber == c.entity.CurrentLoFlowNumber);
					}
					
					 if (c.entity.LastAdFlowNumber > 0)
					{
						q = q.Where(p => p.LastAdFlowNumber == c.entity.LastAdFlowNumber);
					}
					
					 if (c.entity.CurrentAdFlowNumber > 0)
					{
						q = q.Where(p => p.CurrentAdFlowNumber == c.entity.CurrentAdFlowNumber);
					}
					
					 if (c.entity.LastExFlowNumber > 0)
					{
						q = q.Where(p => p.LastExFlowNumber == c.entity.LastExFlowNumber);
					}
					
					 if (c.entity.CurrentExFlowNumber > 0)
					{
						q = q.Where(p => p.CurrentExFlowNumber == c.entity.CurrentExFlowNumber);
					}
					
					 if (c.entity.LastScFlowNumber > 0)
					{
						q = q.Where(p => p.LastScFlowNumber == c.entity.LastScFlowNumber);
					}
					
					 if (c.entity.CurrentScFlowNumber > 0)
					{
						q = q.Where(p => p.CurrentScFlowNumber == c.entity.CurrentScFlowNumber);
					}
					
					 if (c.entity.LastSpFlowNumber > 0)
					{
						q = q.Where(p => p.LastSpFlowNumber == c.entity.LastSpFlowNumber);
					}
					
					 if (c.entity.CurrentSpFlowNumber > 0)
					{
						q = q.Where(p => p.CurrentSpFlowNumber == c.entity.CurrentSpFlowNumber);
					}
					
					 if (c.entity.LastReFlowNumber > 0)
					{
						q = q.Where(p => p.LastReFlowNumber == c.entity.LastReFlowNumber);
					}
					
					 if (c.entity.CurrentReFlowNumber > 0)
					{
						q = q.Where(p => p.CurrentReFlowNumber == c.entity.CurrentReFlowNumber);
					}
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<AcPaDayaccount> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
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




