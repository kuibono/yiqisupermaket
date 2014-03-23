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
using System.Data;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public class FbAdjustSupplierService:IFbAdjustSupplierService
    {

        public IRepositoryGUID<FbAdjustSupplier> EntityRepository { get; set; }
        public IRepositoryGUID<FbAdjustSupplierGoods> SupplierGoodsRepository { get; set; }
        public IRepositoryGUID<FbGoodsArchivesSupplier> GoodsSupplierRepository { get; set; }
        public IRepositoryGUID<FbGoodsArchives> GoodsRepository { get; set; }
        [Transaction]
        public string Create(FbAdjustSupplier entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public FbAdjustSupplier GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public void ExameByNumber(string number)
        {
            var sup_goods = SupplierGoodsRepository.LinqQuery.Where(p => p.AdjustNumber == number);
            foreach (var item in sup_goods)
            {
                SupplierGoodsRepository.Update(item);

                //更改商品的主供货商
                var sups=GoodsSupplierRepository.LinqQuery.Where(p => p.GoodsCode == item.GoodsCode && p.SupCode == item.SupCodeOld);
                foreach (var sup in sups)
                {
                    sup.SupCode = item.SupCode;
                    sup.SupName = item.SupName;
                    //sup.GoodsCode=item.GoodsCode
                    sup.IfExamine = "1";
                    sup.IfMainSupplier = "1";
                    sup.InputTax = item.InputTax;
                    sup.NontaxPurchasePrice = item.NontaxPurchasePrice;
                    sup.OfferMin = item.OfferMin;
                    sup.OfferMode = item.OfferMode;
                    sup.OpCode = item.OpCode;
                    sup.PoolRate = item.PoolRate;
                    sup.PurchasePrice = item.PurchasePrice;
                    sup.PyCode = item.PyCode;
                    //sup.SupCode=
                    GoodsSupplierRepository.Update(sup);

                    //更新商品表的主供货商
                    var goods = GoodsRepository.LinqQuery.Where(p => p.Id == item.GoodsCode);
                    foreach (var good in goods)
                    {
                        good.SupCode = item.SupCode;
                        good.InputTax = item.InputTax;
                        good.NontaxPurchasePrice = item.NontaxPurchasePrice;
                        good.OfferMin = item.OfferMin;
                        good.OfferMode = item.OfferMode;
                        good.OpCode = item.OpCode;
                        good.PoolRate = item.PoolRate;
                        good.PurchasePrice = item.PurchasePrice;
                        GoodsRepository.Update(good);
                    }
                }
                
            }
        }

        [Transaction]
        public IList<FbAdjustSupplier> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(FbAdjustSupplier entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(FbAdjustSupplier entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<FbAdjustSupplier> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<FbAdjustSupplier> Search(SearchDtoBase<FbAdjustSupplier> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.AdjustReason) == false)
					{
						q = q.Where(p => p.AdjustReason.Contains(c.entity.AdjustReason));
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
					|| l.AdjustReason.Contains(c.key)
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
        public IList<FbAdjustSupplier> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.AdjustReason.Contains(key)
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
                (new FbAdjustSupplier()).GetSqlHelper().ExecuteNonQuery(CommandType.Text, string.Format("delete from fb_adjust_supplier_goods where adjust_number=N'{0}'", each.Id));
                Delete(each);
            }
        }
    }
}



