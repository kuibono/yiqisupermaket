/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:07
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public class TgTravelArchivesService:ITgTravelArchivesService
    {

        public IRepositoryGUID<TgTravelArchives> EntityRepository { get; set; }

        [Transaction]
        public string Create(TgTravelArchives entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public TgTravelArchives GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<TgTravelArchives> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(TgTravelArchives entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(TgTravelArchives entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<TgTravelArchives> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<TgTravelArchives> Search(SearchDtoBase<TgTravelArchives> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.TaName) == false)
					{
						
						q = q.Where(p => p.TaName.Contains(c.entity.TaName));
					}
					if (string.IsNullOrEmpty(c.entity.PyCode) == false)
					{
						
						q = q.Where(p => p.PyCode.Contains(c.entity.PyCode));
					}
					if (string.IsNullOrEmpty(c.entity.TaTypeCode) == false)
					{
						
						q = q.Where(p => p.TaTypeCode.Contains(c.entity.TaTypeCode));
					}
					 if (c.entity.PushRate > 0)
					{
						q = q.Where(p => p.PushRate == c.entity.PushRate);
					}
					
					 if (c.entity.PushMoney > 0)
					{
						q = q.Where(p => p.PushMoney == c.entity.PushMoney);
					}
					
					 if (c.entity.PushMoneyAccount > 0)
					{
						q = q.Where(p => p.PushMoneyAccount == c.entity.PushMoneyAccount);
					}
					
					 if (c.entity.TaReturnsRate > 0)
					{
						q = q.Where(p => p.TaReturnsRate == c.entity.TaReturnsRate);
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
					if (string.IsNullOrEmpty(c.entity.PrintType) == false)
					{
						
						q = q.Where(p => p.PrintType.Contains(c.entity.PrintType));
					}
					if (string.IsNullOrEmpty(c.entity.IfPrint) == false)
					{
						
						q = q.Where(p => p.IfPrint.Contains(c.entity.IfPrint));
					}
					if (string.IsNullOrEmpty(c.entity.CarsType) == false)
					{
						
						q = q.Where(p => p.CarsType.Contains(c.entity.CarsType));
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
                    l.Id.Contains(c.key)
					|| l.TaName.Contains(c.key)
					|| l.PyCode.Contains(c.key)
					|| l.TaTypeCode.Contains(c.key)
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
					|| l.PrintType.Contains(c.key)
					|| l.IfPrint.Contains(c.key)
					|| l.CarsType.Contains(c.key)
					|| l.Comment.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<TgTravelArchives> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.TaCode.Contains(key)
					|| l.TaName.Contains(key)
					|| l.PyCode.Contains(key)
					|| l.TaTypeCode.Contains(key)
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
					|| l.PrintType.Contains(key)
					|| l.IfPrint.Contains(key)
					|| l.CarsType.Contains(key)
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
            var q = EntityRepository.LinqQuery.Where(p => ids.Contains(p.Id));
            foreach (var each in q)
            {
                Delete(each);
            }
        }
    }
}




