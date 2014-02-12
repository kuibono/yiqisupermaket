/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:07
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public class OpPaWarehouseService:IOpPaWarehouseService
    {

        public IRepositoryGUID<OpPaWarehouse> EntityRepository { get; set; }

        [Transaction]
        public string Create(OpPaWarehouse entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public OpPaWarehouse GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<OpPaWarehouse> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(OpPaWarehouse entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(OpPaWarehouse entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<OpPaWarehouse> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<OpPaWarehouse> Search(SearchDtoBase<OpPaWarehouse> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					if (string.IsNullOrEmpty(c.entity.WhName) == false)
					{
						
						q = q.Where(p => p.WhName.Contains(c.entity.WhName));
					}
					 if (c.entity.WhArea > 0)
					{
						q = q.Where(p => p.WhArea == c.entity.WhArea);
					}
					
					if (string.IsNullOrEmpty(c.entity.IfMainWh) == false)
					{
						
						q = q.Where(p => p.IfMainWh.Contains(c.entity.IfMainWh));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.WhCode.Contains(c.key)
					|| l.WhName.Contains(c.key)
					|| l.IfMainWh.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<OpPaWarehouse> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.WhName.Contains(key)
					|| l.IfMainWh.Contains(key)
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




