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
    public class BsReturnManageFlowService:IBsReturnManageFlowService
    {

        public IRepositoryGUID<BsReturnManageFlow> EntityRepository { get; set; }

        [Transaction]
        public string Create(BsReturnManageFlow entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public BsReturnManageFlow GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<BsReturnManageFlow> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(BsReturnManageFlow entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(BsReturnManageFlow entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<BsReturnManageFlow> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<BsReturnManageFlow> Search(SearchDtoBase<BsReturnManageFlow> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					 if (c.entity.ReFlowNumber > 0)
					{
						q = q.Where(p => p.ReFlowNumber == c.entity.ReFlowNumber);
					}
					
					if (string.IsNullOrEmpty(c.entity.bCode) == false)
					{
						
						q = q.Where(p => p.bCode.Contains(c.entity.bCode));
					}
					if (string.IsNullOrEmpty(c.entity.EnCode) == false)
					{
						
						q = q.Where(p => p.EnCode.Contains(c.entity.EnCode));
					}
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					if (string.IsNullOrEmpty(c.entity.WhCodeIn) == false)
					{
						
						q = q.Where(p => p.WhCodeIn.Contains(c.entity.WhCodeIn));
					}
					if (string.IsNullOrEmpty(c.entity.SpType) == false)
					{
						
						q = q.Where(p => p.SpType.Contains(c.entity.SpType));
					}
					 if (c.entity.ReturnMoney > 0)
					{
						q = q.Where(p => p.ReturnMoney == c.entity.ReturnMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.IfBalance) == false)
					{
						
						q = q.Where(p => p.IfBalance.Contains(c.entity.IfBalance));
					}
					if (string.IsNullOrEmpty(c.entity.BaNumber) == false)
					{
						
						q = q.Where(p => p.BaNumber.Contains(c.entity.BaNumber));
					}
					 if (c.entity.BaMoney > 0)
					{
						q = q.Where(p => p.BaMoney == c.entity.BaMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.Operator) == false)
					{
						
						q = q.Where(p => p.Operator.Contains(c.entity.Operator));
					}
					if (string.IsNullOrEmpty(c.entity.Assessor) == false)
					{
						
						q = q.Where(p => p.Assessor.Contains(c.entity.Assessor));
					}
					if (string.IsNullOrEmpty(c.entity.IfExamine) == false)
					{
						
						q = q.Where(p => p.IfExamine.Contains(c.entity.IfExamine));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.bCode.Contains(c.key)
					|| l.EnCode.Contains(c.key)
					|| l.WhCode.Contains(c.key)
					|| l.WhCodeIn.Contains(c.key)
					|| l.SpType.Contains(c.key)
					|| l.IfBalance.Contains(c.key)
					|| l.BaNumber.Contains(c.key)
					|| l.Operator.Contains(c.key)
					|| l.Assessor.Contains(c.key)
					|| l.IfExamine.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<BsReturnManageFlow> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.ReNumber.Contains(key)
					|| l.bCode.Contains(key)
					|| l.EnCode.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.WhCodeIn.Contains(key)
					|| l.SpType.Contains(key)
					|| l.IfBalance.Contains(key)
					|| l.BaNumber.Contains(key)
					|| l.Operator.Contains(key)
					|| l.Assessor.Contains(key)
					|| l.IfExamine.Contains(key)
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




