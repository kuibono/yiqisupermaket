/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:07
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public class RtPaPosService:IRtPaPosService
    {

        public IRepositoryGUID<RtPaPos> EntityRepository { get; set; }

        [Transaction]
        public string Create(RtPaPos entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public RtPaPos GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<RtPaPos> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(RtPaPos entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(RtPaPos entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<RtPaPos> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<RtPaPos> Search(SearchDtoBase<RtPaPos> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.PosName) == false)
					{
						
						q = q.Where(p => p.PosName.Contains(c.entity.PosName));
					}
					if (string.IsNullOrEmpty(c.entity.PosIp) == false)
					{
						
						q = q.Where(p => p.PosIp.Contains(c.entity.PosIp));
					}
					if (string.IsNullOrEmpty(c.entity.PosState) == false)
					{
						
						q = q.Where(p => p.PosState.Contains(c.entity.PosState));
					}
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					if (string.IsNullOrEmpty(c.entity.CdType) == false)
					{
						
						q = q.Where(p => p.CdType.Contains(c.entity.CdType));
					}
					if (string.IsNullOrEmpty(c.entity.CdPort) == false)
					{
						
						q = q.Where(p => p.CdPort.Contains(c.entity.CdPort));
					}
					if (string.IsNullOrEmpty(c.entity.pType) == false)
					{
						
						q = q.Where(p => p.pType.Contains(c.entity.pType));
					}
					if (string.IsNullOrEmpty(c.entity.pPort) == false)
					{
						
						q = q.Where(p => p.pPort.Contains(c.entity.pPort));
					}
					 if (c.entity.pWidth > 0)
					{
						q = q.Where(p => p.pWidth == c.entity.pWidth);
					}
					
					if (string.IsNullOrEmpty(c.entity.CbType) == false)
					{
						
						q = q.Where(p => p.CbType.Contains(c.entity.CbType));
					}
					if (string.IsNullOrEmpty(c.entity.CbPort) == false)
					{
						
						q = q.Where(p => p.CbPort.Contains(c.entity.CbPort));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.PosName.Contains(c.key)
					|| l.PosIp.Contains(c.key)
					|| l.PosState.Contains(c.key)
					|| l.WhCode.Contains(c.key)
					|| l.CdType.Contains(c.key)
					|| l.CdPort.Contains(c.key)
					|| l.pType.Contains(c.key)
					|| l.pPort.Contains(c.key)
					|| l.CbType.Contains(c.key)
					|| l.CbPort.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<RtPaPos> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.Posid.Contains(key)
					|| l.PosName.Contains(key)
					|| l.PosIp.Contains(key)
					|| l.PosState.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.CdType.Contains(key)
					|| l.CdPort.Contains(key)
					|| l.pType.Contains(key)
					|| l.pPort.Contains(key)
					|| l.CbType.Contains(key)
					|| l.CbPort.Contains(key)
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




