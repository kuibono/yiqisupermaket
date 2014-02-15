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
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public class SysPrintDesignService:ISysPrintDesignService
    {

        public IRepositoryGUID<SysPrintDesign> EntityRepository { get; set; }

        [Transaction]
        public string Create(SysPrintDesign entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public SysPrintDesign GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<SysPrintDesign> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(SysPrintDesign entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(SysPrintDesign entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<SysPrintDesign> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<SysPrintDesign> Search(SearchDtoBase<SysPrintDesign> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.DwObject) == false)
					{
						q = q.Where(p => p.DwObject.Contains(c.entity.DwObject));
					}
					if (string.IsNullOrEmpty(c.entity.TemplateName) == false)
					{
						q = q.Where(p => p.TemplateName.Contains(c.entity.TemplateName));
					}
					if (string.IsNullOrEmpty(c.entity.IfMain) == false)
					{
						q = q.Where(p => p.IfMain.Contains(c.entity.IfMain));
					}
					if (string.IsNullOrEmpty(c.entity.DataObject) == false)
					{
						q = q.Where(p => p.DataObject.Contains(c.entity.DataObject));
					}
					if (string.IsNullOrEmpty(c.entity.ObContent) == false)
					{
						q = q.Where(p => p.ObContent.Contains(c.entity.ObContent));
					}
					if (string.IsNullOrEmpty(c.entity.ObFontFace) == false)
					{
						q = q.Where(p => p.ObFontFace.Contains(c.entity.ObFontFace));
					}
					 if (c.entity.ObFontHeight > 0)
					{
						q = q.Where(p => p.ObFontHeight == c.entity.ObFontHeight);
					}
					
					 if (c.entity.ObFontWeight > 0)
					{
						q = q.Where(p => p.ObFontWeight == c.entity.ObFontWeight);
					}
					
					if (string.IsNullOrEmpty(c.entity.ObFontItalic) == false)
					{
						q = q.Where(p => p.ObFontItalic.Contains(c.entity.ObFontItalic));
					}
					if (string.IsNullOrEmpty(c.entity.ObFontUnderline) == false)
					{
						q = q.Where(p => p.ObFontUnderline.Contains(c.entity.ObFontUnderline));
					}
					 if (c.entity.ObColor > 0)
					{
						q = q.Where(p => p.ObColor == c.entity.ObColor);
					}
					
					if (string.IsNullOrEmpty(c.entity.IfVisible) == false)
					{
						q = q.Where(p => p.IfVisible.Contains(c.entity.IfVisible));
					}
					 if (c.entity.Obx > 0)
					{
						q = q.Where(p => p.Obx == c.entity.Obx);
					}
					
					 if (c.entity.Oby > 0)
					{
						q = q.Where(p => p.Oby == c.entity.Oby);
					}
					
					 if (c.entity.ObWidth > 0)
					{
						q = q.Where(p => p.ObWidth == c.entity.ObWidth);
					}
					
					 if (c.entity.ObHeight > 0)
					{
						q = q.Where(p => p.ObHeight == c.entity.ObHeight);
					}
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.DwObject.Contains(c.key)
					|| l.TemplateName.Contains(c.key)
					|| l.IfMain.Contains(c.key)
					|| l.DataObject.Contains(c.key)
					|| l.ObContent.Contains(c.key)
					|| l.ObFontFace.Contains(c.key)
					|| l.ObFontItalic.Contains(c.key)
					|| l.ObFontUnderline.Contains(c.key)
					|| l.IfVisible.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<SysPrintDesign> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.DwObject.Contains(key)
					|| l.TemplateName.Contains(key)
					|| l.IfMain.Contains(key)
					|| l.DataObject.Contains(key)
					|| l.ObContent.Contains(key)
					|| l.ObFontFace.Contains(key)
					|| l.ObFontItalic.Contains(key)
					|| l.ObFontUnderline.Contains(key)
					|| l.IfVisible.Contains(key)
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




