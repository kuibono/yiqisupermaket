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
    public class TgGuideArchivesService:ITgGuideArchivesService
    {

        public IRepository<TgGuideArchives> EntityRepository { get; set; }

        [Transaction]
        public int Create(TgGuideArchives entity)
        {
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public TgGuideArchives GetById(int id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<TgGuideArchives> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(TgGuideArchives entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(TgGuideArchives entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<TgGuideArchives> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<TgGuideArchives> Search(SearchDtoBase<TgGuideArchives> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
					if (string.IsNullOrEmpty(c.entity.GuideName) == false)
					{
						q = q.Where(p => p.GuideName.Contains(c.entity.GuideName));
					}
					if (string.IsNullOrEmpty(c.entity.PyCode) == false)
					{
						q = q.Where(p => p.PyCode.Contains(c.entity.PyCode));
					}
					if (string.IsNullOrEmpty(c.entity.GuideType) == false)
					{
						q = q.Where(p => p.GuideType.Contains(c.entity.GuideType));
					}
					if (string.IsNullOrEmpty(c.entity.GuideId) == false)
					{
						q = q.Where(p => p.GuideId.Contains(c.entity.GuideId));
					}
					if (string.IsNullOrEmpty(c.entity.ContactPhone) == false)
					{
						q = q.Where(p => p.ContactPhone.Contains(c.entity.ContactPhone));
					}
					if (string.IsNullOrEmpty(c.entity.TaCode) == false)
					{
						q = q.Where(p => p.TaCode.Contains(c.entity.TaCode));
					}
					if (string.IsNullOrEmpty(c.entity.TaName) == false)
					{
						q = q.Where(p => p.TaName.Contains(c.entity.TaName));
					}
					if (string.IsNullOrEmpty(c.entity.TacCode) == false)
					{
						q = q.Where(p => p.TacCode.Contains(c.entity.TacCode));
					}
					 if (c.entity.PushRate > 0)
					{
						q = q.Where(p => p.PushRate == c.entity.PushRate);
					}
					
					 if (c.entity.PushMoney > 0)
					{
						q = q.Where(p => p.PushMoney == c.entity.PushMoney);
					}
					
					if (string.IsNullOrEmpty(c.entity.LicensePlate) == false)
					{
						q = q.Where(p => p.LicensePlate.Contains(c.entity.LicensePlate));
					}
					if (string.IsNullOrEmpty(c.entity.Comment) == false)
					{
						q = q.Where(p => p.Comment.Contains(c.entity.Comment));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.GuideName.Contains(c.key)
					|| l.PyCode.Contains(c.key)
					|| l.GuideType.Contains(c.key)
					|| l.GuideId.Contains(c.key)
					|| l.ContactPhone.Contains(c.key)
					|| l.TaCode.Contains(c.key)
					|| l.TaName.Contains(c.key)
					|| l.TacCode.Contains(c.key)
					|| l.LicensePlate.Contains(c.key)
					|| l.Comment.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<TgGuideArchives> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
					1==0
					|| l.GuideName.Contains(key)
					|| l.PyCode.Contains(key)
					|| l.GuideType.Contains(key)
					|| l.GuideId.Contains(key)
					|| l.ContactPhone.Contains(key)
					|| l.TaCode.Contains(key)
					|| l.TaName.Contains(key)
					|| l.TacCode.Contains(key)
					|| l.LicensePlate.Contains(key)
					|| l.Comment.Contains(key)
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




