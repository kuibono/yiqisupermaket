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
    public class BaPaSubjectService:IBaPaSubjectService
    {

        public IRepository<BaPaSubject> EntityRepository { get; set; }

        [Transaction]
        public int Create(BaPaSubject entity)
        {
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public BaPaSubject GetById(int id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<BaPaSubject> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(BaPaSubject entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(BaPaSubject entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<BaPaSubject> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<BaPaSubject> Search(SearchDtoBase<BaPaSubject> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
					if (string.IsNullOrEmpty(c.entity.OperatType) == false)
					{
						q = q.Where(p => p.OperatType.Contains(c.entity.OperatType));
					}
					if (string.IsNullOrEmpty(c.entity.OpCode) == false)
					{
						q = q.Where(p => p.OpCode.Contains(c.entity.OpCode));
					}
					if (string.IsNullOrEmpty(c.entity.sNumber) == false)
					{
						q = q.Where(p => p.sNumber.Contains(c.entity.sNumber));
					}
					if (string.IsNullOrEmpty(c.entity.DebitCredit) == false)
					{
						q = q.Where(p => p.DebitCredit.Contains(c.entity.DebitCredit));
					}
					 if (c.entity.InputTax > 0)
					{
						q = q.Where(p => p.InputTax == c.entity.InputTax);
					}
					
					if (string.IsNullOrEmpty(c.entity.SubjectCode) == false)
					{
						q = q.Where(p => p.SubjectCode.Contains(c.entity.SubjectCode));
					}
					if (string.IsNullOrEmpty(c.entity.IfTax) == false)
					{
						q = q.Where(p => p.IfTax.Contains(c.entity.IfTax));
					}
					if (string.IsNullOrEmpty(c.entity.IfDept) == false)
					{
						q = q.Where(p => p.IfDept.Contains(c.entity.IfDept));
					}
					if (string.IsNullOrEmpty(c.entity.IfSupplier) == false)
					{
						q = q.Where(p => p.IfSupplier.Contains(c.entity.IfSupplier));
					}
					if (string.IsNullOrEmpty(c.entity.IfKind) == false)
					{
						q = q.Where(p => p.IfKind.Contains(c.entity.IfKind));
					}
					if (string.IsNullOrEmpty(c.entity.IfRate) == false)
					{
						q = q.Where(p => p.IfRate.Contains(c.entity.IfRate));
					}
					if (string.IsNullOrEmpty(c.entity.IfAntitone) == false)
					{
						q = q.Where(p => p.IfAntitone.Contains(c.entity.IfAntitone));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.OperatType.Contains(c.key)
					|| l.OpCode.Contains(c.key)
					|| l.sNumber.Contains(c.key)
					|| l.DebitCredit.Contains(c.key)
					|| l.SubjectCode.Contains(c.key)
					|| l.IfTax.Contains(c.key)
					|| l.IfDept.Contains(c.key)
					|| l.IfSupplier.Contains(c.key)
					|| l.IfKind.Contains(c.key)
					|| l.IfRate.Contains(c.key)
					|| l.IfAntitone.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<BaPaSubject> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.OperatType.Contains(key)
					|| l.OpCode.Contains(key)
					|| l.sNumber.Contains(key)
					|| l.DebitCredit.Contains(key)
					|| l.SubjectCode.Contains(key)
					|| l.IfTax.Contains(key)
					|| l.IfDept.Contains(key)
					|| l.IfSupplier.Contains(key)
					|| l.IfKind.Contains(key)
					|| l.IfRate.Contains(key)
					|| l.IfAntitone.Contains(key)
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




