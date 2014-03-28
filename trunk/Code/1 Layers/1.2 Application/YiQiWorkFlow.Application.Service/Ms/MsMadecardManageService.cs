/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public class MsMadecardManageService:IMsMadecardManageService
    {

        public IRepositoryGUID<MsMadecardManage> EntityRepository { get; set; }

        [Transaction]
        public string Create(MsMadecardManage entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public MsMadecardManage GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<MsMadecardManage> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(MsMadecardManage entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(MsMadecardManage entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<MsMadecardManage> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<MsMadecardManage> Search(SearchDtoBase<MsMadecardManage> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.CardCode) == false)
					{
						q = q.Where(p => p.CardCode.Contains(c.entity.CardCode));
					}
					 if (c.entity.BeginCardNumber > 0)
					{
						q = q.Where(p => p.BeginCardNumber == c.entity.BeginCardNumber);
					}
					
					 if (c.entity.EndCardNumber > 0)
					{
						q = q.Where(p => p.EndCardNumber == c.entity.EndCardNumber);
					}
					
					 if (c.entity.MadeQty > 0)
					{
						q = q.Where(p => p.MadeQty == c.entity.MadeQty);
					}
					
					if (string.IsNullOrEmpty(c.entity.EffectiveType) == false)
					{
						q = q.Where(p => p.EffectiveType.Contains(c.entity.EffectiveType));
					}
					if (string.IsNullOrEmpty(c.entity.IfMade) == false)
					{
						q = q.Where(p => p.IfMade.Contains(c.entity.IfMade));
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
					|| l.CardCode.Contains(c.key)
					|| l.EffectiveType.Contains(c.key)
					|| l.IfMade.Contains(c.key)
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
        public IList<MsMadecardManage> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.CardCode.Contains(key)
					|| l.EffectiveType.Contains(key)
					|| l.IfMade.Contains(key)
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

        public string ExamMadecardManage(MsMadecardManage entity)
        {
            string result = string.Empty;
            // 判断

            return result;
        }
    }
}