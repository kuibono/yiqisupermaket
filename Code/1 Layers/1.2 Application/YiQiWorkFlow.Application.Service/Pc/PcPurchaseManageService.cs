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
using YiQiWorkFlow.Domain.Pc;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Pc
{
    public class PcPurchaseManageService:IPcPurchaseManageService
    {

        public IRepositoryGUID<PcPurchaseManage> EntityRepository { get; set; }

        [Transaction]
        public string Create(PcPurchaseManage entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public PcPurchaseManage GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<PcPurchaseManage> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(PcPurchaseManage entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(PcPurchaseManage entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<PcPurchaseManage> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<PcPurchaseManage> Search(SearchDtoBase<PcPurchaseManage> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.SupCode) == false)
					{
						q = q.Where(p => p.SupCode.Contains(c.entity.SupCode));
					}
					if (string.IsNullOrEmpty(c.entity.EnCode) == false)
					{
						q = q.Where(p => p.EnCode.Contains(c.entity.EnCode));
					}
					if (string.IsNullOrEmpty(c.entity.PcForm) == false)
					{
						q = q.Where(p => p.PcForm.Contains(c.entity.PcForm));
					}
					if (string.IsNullOrEmpty(c.entity.dCode) == false)
					{
						q = q.Where(p => p.dCode.Contains(c.entity.dCode));
					}
					if (string.IsNullOrEmpty(c.entity.bCode) == false)
					{
						q = q.Where(p => p.bCode.Contains(c.entity.bCode));
					}
					if (string.IsNullOrEmpty(c.entity.PcType) == false)
					{
						q = q.Where(p => p.PcType.Contains(c.entity.PcType));
					}
					if (string.IsNullOrEmpty(c.entity.PcMode) == false)
					{
						q = q.Where(p => p.PcMode.Contains(c.entity.PcMode));
					}
					if (string.IsNullOrEmpty(c.entity.WhCode) == false)
					{
						q = q.Where(p => p.WhCode.Contains(c.entity.WhCode));
					}
					if (string.IsNullOrEmpty(c.entity.IfCheck) == false)
					{
						q = q.Where(p => p.IfCheck.Contains(c.entity.IfCheck));
					}
					if (string.IsNullOrEmpty(c.entity.IfPutin) == false)
					{
						q = q.Where(p => p.IfPutin.Contains(c.entity.IfPutin));
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
					|| l.SupCode.Contains(c.key)
					|| l.EnCode.Contains(c.key)
					|| l.PcForm.Contains(c.key)
					|| l.dCode.Contains(c.key)
					|| l.bCode.Contains(c.key)
					|| l.PcType.Contains(c.key)
					|| l.PcMode.Contains(c.key)
					|| l.WhCode.Contains(c.key)
					|| l.IfCheck.Contains(c.key)
					|| l.IfPutin.Contains(c.key)
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
        public IList<PcPurchaseManage> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.SupCode.Contains(key)
					|| l.EnCode.Contains(key)
					|| l.PcForm.Contains(key)
					|| l.dCode.Contains(key)
					|| l.bCode.Contains(key)
					|| l.PcType.Contains(key)
					|| l.PcMode.Contains(key)
					|| l.WhCode.Contains(key)
					|| l.IfCheck.Contains(key)
					|| l.IfPutin.Contains(key)
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




