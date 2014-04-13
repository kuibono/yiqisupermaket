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
    public class MsUpdateCardManageService:IMsUpdateCardManageService
    {

        public IRepositoryGUID<MsUpdateCardManage> EntityRepository { get; set; }

        [Transaction]
        public string Create(MsUpdateCardManage entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public MsUpdateCardManage GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<MsUpdateCardManage> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(MsUpdateCardManage entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(MsUpdateCardManage entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<MsUpdateCardManage> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<MsUpdateCardManage> Search(SearchDtoBase<MsUpdateCardManage> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.UpdateNumber) == false)
					{
						q = q.Where(p => p.UpdateNumber.Contains(c.entity.UpdateNumber));
					}
					if (string.IsNullOrEmpty(c.entity.EnCode) == false)
					{
						q = q.Where(p => p.EnCode.Contains(c.entity.EnCode));
					}
					if (string.IsNullOrEmpty(c.entity.UpdateReason) == false)
					{
						q = q.Where(p => p.UpdateReason.Contains(c.entity.UpdateReason));
					}
					if (string.IsNullOrEmpty(c.entity.CardNumberOld) == false)
					{
						q = q.Where(p => p.CardNumberOld.Contains(c.entity.CardNumberOld));
					}
					if (string.IsNullOrEmpty(c.entity.SurfaceNumberOld) == false)
					{
						q = q.Where(p => p.SurfaceNumberOld.Contains(c.entity.SurfaceNumberOld));
					}
					if (string.IsNullOrEmpty(c.entity.CardNumber) == false)
					{
						q = q.Where(p => p.CardNumber.Contains(c.entity.CardNumber));
					}
					if (string.IsNullOrEmpty(c.entity.SurfaceNumber) == false)
					{
						q = q.Where(p => p.SurfaceNumber.Contains(c.entity.SurfaceNumber));
					}
					if (string.IsNullOrEmpty(c.entity.MsCode) == false)
					{
						q = q.Where(p => p.MsCode.Contains(c.entity.MsCode));
					}
					if (string.IsNullOrEmpty(c.entity.CardCode) == false)
					{
						q = q.Where(p => p.CardCode.Contains(c.entity.CardCode));
					}
					if (string.IsNullOrEmpty(c.entity.CardName) == false)
					{
						q = q.Where(p => p.CardName.Contains(c.entity.CardName));
					}
					if (string.IsNullOrEmpty(c.entity.CardState) == false)
					{
						q = q.Where(p => p.CardState.Contains(c.entity.CardState));
					}
					 if (c.entity.TransactCharge > 0)
					{
						q = q.Where(p => p.TransactCharge == c.entity.TransactCharge);
					}
					
					 if (c.entity.DepositMoney > 0)
					{
						q = q.Where(p => p.DepositMoney == c.entity.DepositMoney);
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
					|| l.UpdateNumber.Contains(c.key)
					|| l.EnCode.Contains(c.key)
					|| l.UpdateReason.Contains(c.key)
					|| l.CardNumberOld.Contains(c.key)
					|| l.SurfaceNumberOld.Contains(c.key)
					|| l.CardNumber.Contains(c.key)
					|| l.SurfaceNumber.Contains(c.key)
					|| l.MsCode.Contains(c.key)
					|| l.CardCode.Contains(c.key)
					|| l.CardName.Contains(c.key)
					|| l.CardState.Contains(c.key)
					|| l.Operator.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<MsUpdateCardManage> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.UpdateNumber.Contains(key)
					|| l.EnCode.Contains(key)
					|| l.UpdateReason.Contains(key)
					|| l.CardNumberOld.Contains(key)
					|| l.SurfaceNumberOld.Contains(key)
					|| l.CardNumber.Contains(key)
					|| l.SurfaceNumber.Contains(key)
					|| l.MsCode.Contains(key)
					|| l.CardCode.Contains(key)
					|| l.CardName.Contains(key)
					|| l.CardState.Contains(key)
					|| l.Operator.Contains(key)
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

        public string GenerateUpdateNumber()
        {
            string maxUpdateNumber = GetMaxCardtypeCode();

            if (string.IsNullOrEmpty(maxUpdateNumber))
            {
                return "560000000001";
            }
            else
            {
                int maxmaxUpdateNumberInt = Convert.ToInt32(maxUpdateNumber.Replace("56",""));

                return "56" + (maxmaxUpdateNumberInt + 1).ToString("0000000000");
            }
        }

        private string GetMaxCardtypeCode()
        {
            string maxUpdateNumber = EntityRepository.LinqQuery.Max(x => x.UpdateNumber);

            if (string.IsNullOrEmpty(maxUpdateNumber))
            {
                return string.Empty;
            }
            else
            {
                return maxUpdateNumber;
            }
        }

    }
}




