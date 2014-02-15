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
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public class FbGoodsArchivesPartsService:IFbGoodsArchivesPartsService
    {

        public IRepositoryGUID<FbGoodsArchivesParts> EntityRepository { get; set; }

        [Transaction]
        public string Create(FbGoodsArchivesParts entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public FbGoodsArchivesParts GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<FbGoodsArchivesParts> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(FbGoodsArchivesParts entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(FbGoodsArchivesParts entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<FbGoodsArchivesParts> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<FbGoodsArchivesParts> Search(SearchDtoBase<FbGoodsArchivesParts> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.GoodsCode) == false)
					{
						q = q.Where(p => p.GoodsCode.Contains(c.entity.GoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsBarCode) == false)
					{
						q = q.Where(p => p.GoodsBarCode.Contains(c.entity.GoodsBarCode));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsCodePart) == false)
					{
						q = q.Where(p => p.GoodsCodePart.Contains(c.entity.GoodsCodePart));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsBarCodePart) == false)
					{
						q = q.Where(p => p.GoodsBarCodePart.Contains(c.entity.GoodsBarCodePart));
					}
					if (string.IsNullOrEmpty(c.entity.GoodsBarName) == false)
					{
						q = q.Where(p => p.GoodsBarName.Contains(c.entity.GoodsBarName));
					}
					if (string.IsNullOrEmpty(c.entity.PackUnitCode) == false)
					{
						q = q.Where(p => p.PackUnitCode.Contains(c.entity.PackUnitCode));
					}
					 if (c.entity.PartCoef > 0)
					{
						q = q.Where(p => p.PartCoef == c.entity.PartCoef);
					}
					
					if (string.IsNullOrEmpty(c.entity.IfExamine) == false)
					{
						q = q.Where(p => p.IfExamine.Contains(c.entity.IfExamine));
					}
					if (string.IsNullOrEmpty(c.entity.SysGuid) == false)
					{
						q = q.Where(p => p.SysGuid.Contains(c.entity.SysGuid));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.GoodsCode.Contains(c.key)
					|| l.GoodsBarCode.Contains(c.key)
					|| l.GoodsCodePart.Contains(c.key)
					|| l.GoodsBarCodePart.Contains(c.key)
					|| l.GoodsBarName.Contains(c.key)
					|| l.PackUnitCode.Contains(c.key)
					|| l.IfExamine.Contains(c.key)
					|| l.SysGuid.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<FbGoodsArchivesParts> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.GoodsCode.Contains(key)
					|| l.GoodsBarCode.Contains(key)
					|| l.GoodsCodePart.Contains(key)
					|| l.GoodsBarCodePart.Contains(key)
					|| l.GoodsBarName.Contains(key)
					|| l.PackUnitCode.Contains(key)
					|| l.IfExamine.Contains(key)
					|| l.SysGuid.Contains(key)
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




