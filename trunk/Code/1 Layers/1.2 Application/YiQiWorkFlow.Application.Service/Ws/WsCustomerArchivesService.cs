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
using YiQiWorkFlow.Domain.Ws;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ws
{
    public class WsCustomerArchivesService : IWsCustomerArchivesService
    {

        public IRepositoryGUID<WsCustomerArchives> EntityRepository { get; set; }

        [Transaction]
        public string Create(WsCustomerArchives entity)
        {
            if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public WsCustomerArchives GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<WsCustomerArchives> GetAll()
        {
            var result = EntityRepository.LinqQuery.ToList();

            return result;
        }


        [Transaction]
        public void Update(WsCustomerArchives entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(WsCustomerArchives entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<WsCustomerArchives> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<WsCustomerArchives> Search(SearchDtoBase<WsCustomerArchives> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
                if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
                if (string.IsNullOrEmpty(c.entity.CustName) == false)
                {
                    q = q.Where(p => p.CustName.Contains(c.entity.CustName));
                }
                if (string.IsNullOrEmpty(c.entity.PyCode) == false)
                {
                    q = q.Where(p => p.PyCode.Contains(c.entity.PyCode));
                }
                if (string.IsNullOrEmpty(c.entity.CustTypeCode) == false)
                {
                    q = q.Where(p => p.CustTypeCode.Contains(c.entity.CustTypeCode));
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
                if (string.IsNullOrEmpty(c.entity.PayMode) == false)
                {
                    q = q.Where(p => p.PayMode.Contains(c.entity.PayMode));
                }
                if (string.IsNullOrEmpty(c.entity.BalanceMode) == false)
                {
                    q = q.Where(p => p.BalanceMode.Contains(c.entity.BalanceMode));
                }
                if (string.IsNullOrEmpty(c.entity.BalancePeriod) == false)
                {
                    q = q.Where(p => p.BalancePeriod.Contains(c.entity.BalancePeriod));
                }
                if (c.entity.BalanceDay > 0)
                {
                    q = q.Where(p => p.BalanceDay == c.entity.BalanceDay);
                }

                if (string.IsNullOrEmpty(c.entity.SalePeriod) == false)
                {
                    q = q.Where(p => p.SalePeriod.Contains(c.entity.SalePeriod));
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
            if (string.IsNullOrEmpty(c.key) == false)
            {
                q = from l in q
                    where
                    l.Id.Contains(c.key)
                    || l.CustName.Contains(c.key)
                    || l.PyCode.Contains(c.key)
                    || l.CustTypeCode.Contains(c.key)
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
                    || l.PayMode.Contains(c.key)
                    || l.BalanceMode.Contains(c.key)
                    || l.BalancePeriod.Contains(c.key)
                    || l.SalePeriod.Contains(c.key)
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
        public IList<WsCustomerArchives> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key) == false)
            {
                q = from l in q
                    where
                    l.Id.Contains(key)
                    || l.CustName.Contains(key)
                    || l.PyCode.Contains(key)
                    || l.CustTypeCode.Contains(key)
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
                    || l.PayMode.Contains(key)
                    || l.BalanceMode.Contains(key)
                    || l.BalancePeriod.Contains(key)
                    || l.SalePeriod.Contains(key)
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
            var q = EntityRepository.LinqQuery.Where(p => ids.Contains(p.Id));
            foreach (var each in q)
            {
                Delete(each);
            }
        }

        [Transaction(ReadOnly = true)]
        public string GenerateCustomerCode()
        {
            string maxCode = GetMaxCode();

            if (string.IsNullOrEmpty(maxCode))
            {
                return "00001";
            }
            else
            {
                int maxCodeInt = Convert.ToInt32(maxCode);

                return (maxCodeInt + 1).ToString("00000");
            }
        }

        private string GetMaxCode()
        {
            string maxCardCode = EntityRepository.LinqQuery.Max(x => x.Id);

            if (string.IsNullOrEmpty(maxCardCode))
            {
                return string.Empty;
            }
            else
            {
                return maxCardCode;
            }
        }
    }
}