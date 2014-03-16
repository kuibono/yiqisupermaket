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
using System.Web.Script.Serialization;
using System.IO;
namespace YiQiWorkFlow.Application.Service.Fb
{
    public class FbSupplierArchivesService:IFbSupplierArchivesService
    {

        public IRepositoryGUID<FbSupplierArchives> EntityRepository { get; set; }

        [Transaction]
        public string Create(FbSupplierArchives entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            string result = EntityRepository.Save(entity);
            SaveAllToJson();
            return result;
        }

        [Transaction]
        public FbSupplierArchives GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        public IList<FbSupplierArchives> GetById(IList<string> ids)
        {
            return EntityRepository.LinqQuery.Where(p => ids.Contains(p.Id)).ToList();
        }

        [Transaction]
        public IList<FbSupplierArchives> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void SaveOrUpdate(FbSupplierArchives entity)
        {
            EntityRepository.SaveOrUpdate(entity);
            SaveAllToJson();
        }
        [Transaction]
        public void Update(FbSupplierArchives entity)
        {
            EntityRepository.Update(entity);
            SaveAllToJson();
        }
        /// <summary>
        /// 保存为 /Data/FbSupplierArchives.json
        /// </summary>
        [Transaction]
        public void SaveAllToJson()
        {
            JavaScriptSerializer jser = new JavaScriptSerializer();
            string json = jser.Serialize(GetAll());
            string file = System.Web.HttpContext.Current.Server.MapPath("/Data/FbSupplierArchives.json");
            FileInfo _file = new FileInfo(file);
            if (_file.Directory.Exists == false)
            {
                _file.Directory.Create();
            }
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(json);
            }
        }

        [Transaction]
        public void Delete(FbSupplierArchives entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<FbSupplierArchives> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<FbSupplierArchives> Search(SearchDtoBase<FbSupplierArchives> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.SupName) == false)
					{
						q = q.Where(p => p.SupName.Contains(c.entity.SupName));
					}
					if (string.IsNullOrEmpty(c.entity.PyCode) == false)
					{
						q = q.Where(p => p.PyCode.Contains(c.entity.PyCode));
					}
					if (string.IsNullOrEmpty(c.entity.SupTypeCode) == false)
					{
						q = q.Where(p => p.SupTypeCode.Contains(c.entity.SupTypeCode));
					}
					if (string.IsNullOrEmpty(c.entity.Functionary) == false)
					{
						q = q.Where(p => p.Functionary.Contains(c.entity.Functionary));
					}
					if (string.IsNullOrEmpty(c.entity.FunctionaryPhone) == false)
					{
						q = q.Where(p => p.FunctionaryPhone.Contains(c.entity.FunctionaryPhone));
					}
					if (string.IsNullOrEmpty(c.entity.Linkman) == false)
					{
						q = q.Where(p => p.Linkman.Contains(c.entity.Linkman));
					}
					if (string.IsNullOrEmpty(c.entity.ContactPhone) == false)
					{
						q = q.Where(p => p.ContactPhone.Contains(c.entity.ContactPhone));
					}
					if (string.IsNullOrEmpty(c.entity.ContactAddress) == false)
					{
						q = q.Where(p => p.ContactAddress.Contains(c.entity.ContactAddress));
					}
					if (string.IsNullOrEmpty(c.entity.OfficePhone) == false)
					{
						q = q.Where(p => p.OfficePhone.Contains(c.entity.OfficePhone));
					}
					if (string.IsNullOrEmpty(c.entity.FaxPhone) == false)
					{
						q = q.Where(p => p.FaxPhone.Contains(c.entity.FaxPhone));
					}
					if (string.IsNullOrEmpty(c.entity.eMail) == false)
					{
						q = q.Where(p => p.eMail.Contains(c.entity.eMail));
					}
					if (string.IsNullOrEmpty(c.entity.Postalcode) == false)
					{
						q = q.Where(p => p.Postalcode.Contains(c.entity.Postalcode));
					}
					if (string.IsNullOrEmpty(c.entity.OpenAccount) == false)
					{
						q = q.Where(p => p.OpenAccount.Contains(c.entity.OpenAccount));
					}
					if (string.IsNullOrEmpty(c.entity.BankAccount) == false)
					{
						q = q.Where(p => p.BankAccount.Contains(c.entity.BankAccount));
					}
					if (string.IsNullOrEmpty(c.entity.TaxNumber) == false)
					{
						q = q.Where(p => p.TaxNumber.Contains(c.entity.TaxNumber));
					}
					if (string.IsNullOrEmpty(c.entity.OpCode) == false)
					{
						q = q.Where(p => p.OpCode.Contains(c.entity.OpCode));
					}
					if (string.IsNullOrEmpty(c.entity.StockVoucher) == false)
					{
						q = q.Where(p => p.StockVoucher.Contains(c.entity.StockVoucher));
					}
					 if (c.entity.InputTax > 0)
					{
						q = q.Where(p => p.InputTax == c.entity.InputTax);
					}
					
					if (string.IsNullOrEmpty(c.entity.BalanceMode) == false)
					{
						q = q.Where(p => p.BalanceMode.Contains(c.entity.BalanceMode));
					}
					if (string.IsNullOrEmpty(c.entity.PayMode) == false)
					{
						q = q.Where(p => p.PayMode.Contains(c.entity.PayMode));
					}
					if (string.IsNullOrEmpty(c.entity.BalancePeriod) == false)
					{
						q = q.Where(p => p.BalancePeriod.Contains(c.entity.BalancePeriod));
					}
					 if (c.entity.BalanceDay > 0)
					{
						q = q.Where(p => p.BalanceDay == c.entity.BalanceDay);
					}
					
					if (string.IsNullOrEmpty(c.entity.OfferMode) == false)
					{
						q = q.Where(p => p.OfferMode.Contains(c.entity.OfferMode));
					}
					 if (c.entity.DeliveryDays > 0)
					{
						q = q.Where(p => p.DeliveryDays == c.entity.DeliveryDays);
					}
					
					 if (c.entity.PoolRate > 0)
					{
						q = q.Where(p => p.PoolRate == c.entity.PoolRate);
					}
					
					 if (c.entity.FloorsMoney > 0)
					{
						q = q.Where(p => p.FloorsMoney == c.entity.FloorsMoney);
					}
					
					 if (c.entity.ExcessRate > 0)
					{
						q = q.Where(p => p.ExcessRate == c.entity.ExcessRate);
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
					|| l.SupName.Contains(c.key)
					|| l.PyCode.Contains(c.key)
					|| l.SupTypeCode.Contains(c.key)
					|| l.Functionary.Contains(c.key)
					|| l.FunctionaryPhone.Contains(c.key)
					|| l.Linkman.Contains(c.key)
					|| l.ContactPhone.Contains(c.key)
					|| l.ContactAddress.Contains(c.key)
					|| l.OfficePhone.Contains(c.key)
					|| l.FaxPhone.Contains(c.key)
					|| l.eMail.Contains(c.key)
					|| l.Postalcode.Contains(c.key)
					|| l.OpenAccount.Contains(c.key)
					|| l.BankAccount.Contains(c.key)
					|| l.TaxNumber.Contains(c.key)
					|| l.OpCode.Contains(c.key)
					|| l.StockVoucher.Contains(c.key)
					|| l.BalanceMode.Contains(c.key)
					|| l.PayMode.Contains(c.key)
					|| l.BalancePeriod.Contains(c.key)
					|| l.OfferMode.Contains(c.key)
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
        public IList<FbSupplierArchives> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.SupName.Contains(key)
					|| l.PyCode.Contains(key)
					|| l.SupTypeCode.Contains(key)
					|| l.Functionary.Contains(key)
					|| l.FunctionaryPhone.Contains(key)
					|| l.Linkman.Contains(key)
					|| l.ContactPhone.Contains(key)
					|| l.ContactAddress.Contains(key)
					|| l.OfficePhone.Contains(key)
					|| l.FaxPhone.Contains(key)
					|| l.eMail.Contains(key)
					|| l.Postalcode.Contains(key)
					|| l.OpenAccount.Contains(key)
					|| l.BankAccount.Contains(key)
					|| l.TaxNumber.Contains(key)
					|| l.OpCode.Contains(key)
					|| l.StockVoucher.Contains(key)
					|| l.BalanceMode.Contains(key)
					|| l.PayMode.Contains(key)
					|| l.BalancePeriod.Contains(key)
					|| l.OfferMode.Contains(key)
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




