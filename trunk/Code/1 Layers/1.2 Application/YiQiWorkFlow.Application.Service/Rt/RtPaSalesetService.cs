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
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public class RtPaSalesetService:IRtPaSalesetService
    {

        public IRepositoryGUID<RtPaSaleset> EntityRepository { get; set; }

        [Transaction]
        public string Create(RtPaSaleset entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public RtPaSaleset GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<RtPaSaleset> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(RtPaSaleset entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(RtPaSaleset entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<RtPaSaleset> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<RtPaSaleset> Search(SearchDtoBase<RtPaSaleset> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					 if (c.entity.Mantissa > 0)
					{
						q = q.Where(p => p.Mantissa == c.entity.Mantissa);
					}
					
					if (string.IsNullOrEmpty(c.entity.MantissaMode) == false)
					{
						q = q.Where(p => p.MantissaMode.Contains(c.entity.MantissaMode));
					}
					if (string.IsNullOrEmpty(c.entity.IfReturnSale) == false)
					{
						q = q.Where(p => p.IfReturnSale.Contains(c.entity.IfReturnSale));
					}
					if (string.IsNullOrEmpty(c.entity.IfNegativeStock) == false)
					{
						q = q.Where(p => p.IfNegativeStock.Contains(c.entity.IfNegativeStock));
					}
					if (string.IsNullOrEmpty(c.entity.IfReturnPayway) == false)
					{
						q = q.Where(p => p.IfReturnPayway.Contains(c.entity.IfReturnPayway));
					}
					if (string.IsNullOrEmpty(c.entity.IfSalesman) == false)
					{
						q = q.Where(p => p.IfSalesman.Contains(c.entity.IfSalesman));
					}
					if (string.IsNullOrEmpty(c.entity.IfCounter) == false)
					{
						q = q.Where(p => p.IfCounter.Contains(c.entity.IfCounter));
					}
					if (string.IsNullOrEmpty(c.entity.PrintType) == false)
					{
						q = q.Where(p => p.PrintType.Contains(c.entity.PrintType));
					}
					if (string.IsNullOrEmpty(c.entity.IfBind) == false)
					{
						q = q.Where(p => p.IfBind.Contains(c.entity.IfBind));
					}
					if (string.IsNullOrEmpty(c.entity.IfEntertopay) == false)
					{
						q = q.Where(p => p.IfEntertopay.Contains(c.entity.IfEntertopay));
					}
					if (string.IsNullOrEmpty(c.entity.IfEntertormb) == false)
					{
						q = q.Where(p => p.IfEntertormb.Contains(c.entity.IfEntertormb));
					}
					if (string.IsNullOrEmpty(c.entity.IfEnglishSale) == false)
					{
						q = q.Where(p => p.IfEnglishSale.Contains(c.entity.IfEnglishSale));
					}
					if (string.IsNullOrEmpty(c.entity.Title1) == false)
					{
						q = q.Where(p => p.Title1.Contains(c.entity.Title1));
					}
					if (string.IsNullOrEmpty(c.entity.Title2) == false)
					{
						q = q.Where(p => p.Title2.Contains(c.entity.Title2));
					}
					if (string.IsNullOrEmpty(c.entity.Title3) == false)
					{
						q = q.Where(p => p.Title3.Contains(c.entity.Title3));
					}
					if (string.IsNullOrEmpty(c.entity.Title4) == false)
					{
						q = q.Where(p => p.Title4.Contains(c.entity.Title4));
					}
					if (string.IsNullOrEmpty(c.entity.Title5) == false)
					{
						q = q.Where(p => p.Title5.Contains(c.entity.Title5));
					}
					if (string.IsNullOrEmpty(c.entity.Pagefoot1) == false)
					{
						q = q.Where(p => p.Pagefoot1.Contains(c.entity.Pagefoot1));
					}
					if (string.IsNullOrEmpty(c.entity.Pagefoot2) == false)
					{
						q = q.Where(p => p.Pagefoot2.Contains(c.entity.Pagefoot2));
					}
					if (string.IsNullOrEmpty(c.entity.Pagefoot3) == false)
					{
						q = q.Where(p => p.Pagefoot3.Contains(c.entity.Pagefoot3));
					}
					if (string.IsNullOrEmpty(c.entity.Pagefoot4) == false)
					{
						q = q.Where(p => p.Pagefoot4.Contains(c.entity.Pagefoot4));
					}
					if (string.IsNullOrEmpty(c.entity.Pagefoot5) == false)
					{
						q = q.Where(p => p.Pagefoot5.Contains(c.entity.Pagefoot5));
					}
					if (string.IsNullOrEmpty(c.entity.IfEnName) == false)
					{
						q = q.Where(p => p.IfEnName.Contains(c.entity.IfEnName));
					}
					if (string.IsNullOrEmpty(c.entity.IfbName) == false)
					{
						q = q.Where(p => p.IfbName.Contains(c.entity.IfbName));
					}
					if (string.IsNullOrEmpty(c.entity.IfGoodsCode) == false)
					{
						q = q.Where(p => p.IfGoodsCode.Contains(c.entity.IfGoodsCode));
					}
					if (string.IsNullOrEmpty(c.entity.IfGoodsBarCode) == false)
					{
						q = q.Where(p => p.IfGoodsBarCode.Contains(c.entity.IfGoodsBarCode));
					}
					if (string.IsNullOrEmpty(c.entity.IfGoodsName) == false)
					{
						q = q.Where(p => p.IfGoodsName.Contains(c.entity.IfGoodsName));
					}
					if (string.IsNullOrEmpty(c.entity.IfGoodsSubName) == false)
					{
						q = q.Where(p => p.IfGoodsSubName.Contains(c.entity.IfGoodsSubName));
					}
					if (string.IsNullOrEmpty(c.entity.IfPackUnit) == false)
					{
						q = q.Where(p => p.IfPackUnit.Contains(c.entity.IfPackUnit));
					}
					if (string.IsNullOrEmpty(c.entity.IfPrepaid) == false)
					{
						q = q.Where(p => p.IfPrepaid.Contains(c.entity.IfPrepaid));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.MantissaMode.Contains(c.key)
					|| l.IfReturnSale.Contains(c.key)
					|| l.IfNegativeStock.Contains(c.key)
					|| l.IfReturnPayway.Contains(c.key)
					|| l.IfSalesman.Contains(c.key)
					|| l.IfCounter.Contains(c.key)
					|| l.PrintType.Contains(c.key)
					|| l.IfBind.Contains(c.key)
					|| l.IfEntertopay.Contains(c.key)
					|| l.IfEntertormb.Contains(c.key)
					|| l.IfEnglishSale.Contains(c.key)
					|| l.Title1.Contains(c.key)
					|| l.Title2.Contains(c.key)
					|| l.Title3.Contains(c.key)
					|| l.Title4.Contains(c.key)
					|| l.Title5.Contains(c.key)
					|| l.Pagefoot1.Contains(c.key)
					|| l.Pagefoot2.Contains(c.key)
					|| l.Pagefoot3.Contains(c.key)
					|| l.Pagefoot4.Contains(c.key)
					|| l.Pagefoot5.Contains(c.key)
					|| l.IfEnName.Contains(c.key)
					|| l.IfbName.Contains(c.key)
					|| l.IfGoodsCode.Contains(c.key)
					|| l.IfGoodsBarCode.Contains(c.key)
					|| l.IfGoodsName.Contains(c.key)
					|| l.IfGoodsSubName.Contains(c.key)
					|| l.IfPackUnit.Contains(c.key)
					|| l.IfPrepaid.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<RtPaSaleset> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.MantissaMode.Contains(key)
					|| l.IfReturnSale.Contains(key)
					|| l.IfNegativeStock.Contains(key)
					|| l.IfReturnPayway.Contains(key)
					|| l.IfSalesman.Contains(key)
					|| l.IfCounter.Contains(key)
					|| l.PrintType.Contains(key)
					|| l.IfBind.Contains(key)
					|| l.IfEntertopay.Contains(key)
					|| l.IfEntertormb.Contains(key)
					|| l.IfEnglishSale.Contains(key)
					|| l.Title1.Contains(key)
					|| l.Title2.Contains(key)
					|| l.Title3.Contains(key)
					|| l.Title4.Contains(key)
					|| l.Title5.Contains(key)
					|| l.Pagefoot1.Contains(key)
					|| l.Pagefoot2.Contains(key)
					|| l.Pagefoot3.Contains(key)
					|| l.Pagefoot4.Contains(key)
					|| l.Pagefoot5.Contains(key)
					|| l.IfEnName.Contains(key)
					|| l.IfbName.Contains(key)
					|| l.IfGoodsCode.Contains(key)
					|| l.IfGoodsBarCode.Contains(key)
					|| l.IfGoodsName.Contains(key)
					|| l.IfGoodsSubName.Contains(key)
					|| l.IfPackUnit.Contains(key)
					|| l.IfPrepaid.Contains(key)
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




