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
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public class TgTourgroupManageService:ITgTourgroupManageService
    {

        public IRepository<TgTourgroupManage> EntityRepository { get; set; }

        [Transaction]
        public int Create(TgTourgroupManage entity)
        {
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public TgTourgroupManage GetById(int id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<TgTourgroupManage> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(TgTourgroupManage entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(TgTourgroupManage entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<TgTourgroupManage> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<TgTourgroupManage> Search(SearchDtoBase<TgTourgroupManage> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
					if (string.IsNullOrEmpty(c.entity.GroupNumber) == false)
					{
						q = q.Where(p => p.GroupNumber.Contains(c.entity.GroupNumber));
					}
					if (string.IsNullOrEmpty(c.entity.GroupTypeCode) == false)
					{
						q = q.Where(p => p.GroupTypeCode.Contains(c.entity.GroupTypeCode));
					}
					if (string.IsNullOrEmpty(c.entity.TaCode) == false)
					{
						q = q.Where(p => p.TaCode.Contains(c.entity.TaCode));
					}
					if (string.IsNullOrEmpty(c.entity.TaName) == false)
					{
						q = q.Where(p => p.TaName.Contains(c.entity.TaName));
					}
					if (string.IsNullOrEmpty(c.entity.TaTypeCode) == false)
					{
						q = q.Where(p => p.TaTypeCode.Contains(c.entity.TaTypeCode));
					}
					if (string.IsNullOrEmpty(c.entity.GuideCode) == false)
					{
						q = q.Where(p => p.GuideCode.Contains(c.entity.GuideCode));
					}
					if (string.IsNullOrEmpty(c.entity.GuideName) == false)
					{
						q = q.Where(p => p.GuideName.Contains(c.entity.GuideName));
					}
					if (string.IsNullOrEmpty(c.entity.GuideTacCode) == false)
					{
						q = q.Where(p => p.GuideTacCode.Contains(c.entity.GuideTacCode));
					}
					 if (c.entity.GuidePushRate > 0)
					{
						q = q.Where(p => p.GuidePushRate == c.entity.GuidePushRate);
					}
					
					 if (c.entity.GuidePushMoney > 0)
					{
						q = q.Where(p => p.GuidePushMoney == c.entity.GuidePushMoney);
					}
					
					 if (c.entity.PersonTimes > 0)
					{
						q = q.Where(p => p.PersonTimes == c.entity.PersonTimes);
					}
					
					 if (c.entity.DiscountRate > 0)
					{
						q = q.Where(p => p.DiscountRate == c.entity.DiscountRate);
					}
					
					if (string.IsNullOrEmpty(c.entity.ExpostorTacCode) == false)
					{
						q = q.Where(p => p.ExpostorTacCode.Contains(c.entity.ExpostorTacCode));
					}
					if (string.IsNullOrEmpty(c.entity.Expostor) == false)
					{
						q = q.Where(p => p.Expostor.Contains(c.entity.Expostor));
					}
					 if (c.entity.ExpostorPushRate > 0)
					{
						q = q.Where(p => p.ExpostorPushRate == c.entity.ExpostorPushRate);
					}
					
					 if (c.entity.ExpostorPushMoney > 0)
					{
						q = q.Where(p => p.ExpostorPushMoney == c.entity.ExpostorPushMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.Driver) == false)
					{
						q = q.Where(p => p.Driver.Contains(c.entity.Driver));
					}
					if (string.IsNullOrEmpty(c.entity.LicensePlate) == false)
					{
						q = q.Where(p => p.LicensePlate.Contains(c.entity.LicensePlate));
					}
					if (string.IsNullOrEmpty(c.entity.CarsGroup) == false)
					{
						q = q.Where(p => p.CarsGroup.Contains(c.entity.CarsGroup));
					}
					if (string.IsNullOrEmpty(c.entity.CarsTypeCode) == false)
					{
						q = q.Where(p => p.CarsTypeCode.Contains(c.entity.CarsTypeCode));
					}
					 if (c.entity.StopCharge > 0)
					{
						q = q.Where(p => p.StopCharge == c.entity.StopCharge);
					}
					
					if (string.IsNullOrEmpty(c.entity.CustomerFrom) == false)
					{
						q = q.Where(p => p.CustomerFrom.Contains(c.entity.CustomerFrom));
					}
					if (string.IsNullOrEmpty(c.entity.Comment) == false)
					{
						q = q.Where(p => p.Comment.Contains(c.entity.Comment));
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
					1==0
					|| l.GroupNumber.Contains(c.key)
					|| l.GroupTypeCode.Contains(c.key)
					|| l.TaCode.Contains(c.key)
					|| l.TaName.Contains(c.key)
					|| l.TaTypeCode.Contains(c.key)
					|| l.GuideCode.Contains(c.key)
					|| l.GuideName.Contains(c.key)
					|| l.GuideTacCode.Contains(c.key)
					|| l.ExpostorTacCode.Contains(c.key)
					|| l.Expostor.Contains(c.key)
					|| l.Driver.Contains(c.key)
					|| l.LicensePlate.Contains(c.key)
					|| l.CarsGroup.Contains(c.key)
					|| l.CarsTypeCode.Contains(c.key)
					|| l.CustomerFrom.Contains(c.key)
					|| l.Comment.Contains(c.key)
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
        public IList<TgTourgroupManage> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.GroupNumber.Contains(key)
					|| l.GroupTypeCode.Contains(key)
					|| l.TaCode.Contains(key)
					|| l.TaName.Contains(key)
					|| l.TaTypeCode.Contains(key)
					|| l.GuideCode.Contains(key)
					|| l.GuideName.Contains(key)
					|| l.GuideTacCode.Contains(key)
					|| l.ExpostorTacCode.Contains(key)
					|| l.Expostor.Contains(key)
					|| l.Driver.Contains(key)
					|| l.LicensePlate.Contains(key)
					|| l.CarsGroup.Contains(key)
					|| l.CarsTypeCode.Contains(key)
					|| l.CustomerFrom.Contains(key)
					|| l.Comment.Contains(key)
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
			var int_ids = ids.ToList().Select(p => { return Convert.ToInt32(p); }).ToList();
            var q = EntityRepository.LinqQuery.Where(p => int_ids.Contains(p.Id));
            foreach (var each in q)
            {
                Delete(each);
            }
        }
    }
}




