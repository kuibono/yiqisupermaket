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
    public class MsCardArchivesService : IMsCardArchivesService
    {

        public IRepositoryGUID<MsCardArchives> EntityRepository { get; set; }

        [Transaction]
        public string Create(MsCardArchives entity)
        {
            if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public MsCardArchives GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<MsCardArchives> GetAll()
        {
            var result = EntityRepository.LinqQuery.ToList();

            return result;
        }


        [Transaction]
        public void Update(MsCardArchives entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(MsCardArchives entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<MsCardArchives> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<MsCardArchives> Search(SearchDtoBase<MsCardArchives> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
                if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
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
                if (string.IsNullOrEmpty(c.entity.MsName) == false)
                {
                    q = q.Where(p => p.MsName.Contains(c.entity.MsName));
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

                if (c.entity.TotalMoney > 0)
                {
                    q = q.Where(p => p.TotalMoney == c.entity.TotalMoney);
                }

                if (c.entity.TotalExpendTimes > 0)
                {
                    q = q.Where(p => p.TotalExpendTimes == c.entity.TotalExpendTimes);
                }

                if (c.entity.LastExpendMoney > 0)
                {
                    q = q.Where(p => p.LastExpendMoney == c.entity.LastExpendMoney);
                }

                if (c.entity.TotalPoints > 0)
                {
                    q = q.Where(p => p.TotalPoints == c.entity.TotalPoints);
                }

                if (c.entity.ExchangePoints > 0)
                {
                    q = q.Where(p => p.ExchangePoints == c.entity.ExchangePoints);
                }

                if (c.entity.CurrentPoints > 0)
                {
                    q = q.Where(p => p.CurrentPoints == c.entity.CurrentPoints);
                }

                if (c.entity.ClearPoints > 0)
                {
                    q = q.Where(p => p.ClearPoints == c.entity.ClearPoints);
                }

                if (string.IsNullOrEmpty(c.entity.PrepaidPassword) == false)
                {
                    q = q.Where(p => p.PrepaidPassword.Contains(c.entity.PrepaidPassword));
                }
                if (c.entity.TotalPrepaid > 0)
                {
                    q = q.Where(p => p.TotalPrepaid == c.entity.TotalPrepaid);
                }

                if (c.entity.CurrentPrepaid > 0)
                {
                    q = q.Where(p => p.CurrentPrepaid == c.entity.CurrentPrepaid);
                }

                if (string.IsNullOrEmpty(c.entity.CurrentPrepaidEncrypt) == false)
                {
                    q = q.Where(p => p.CurrentPrepaidEncrypt.Contains(c.entity.CurrentPrepaidEncrypt));
                }
                if (c.entity.UsePrepaid > 0)
                {
                    q = q.Where(p => p.UsePrepaid == c.entity.UsePrepaid);
                }

                if (c.entity.LimitTimes > 0)
                {
                    q = q.Where(p => p.LimitTimes == c.entity.LimitTimes);
                }

                if (c.entity.SaleTimes > 0)
                {
                    q = q.Where(p => p.SaleTimes == c.entity.SaleTimes);
                }

                if (string.IsNullOrEmpty(c.entity.Operator) == false)
                {
                    q = q.Where(p => p.Operator.Contains(c.entity.Operator));
                }

            }
            if (string.IsNullOrEmpty(c.key) == false)
            {
                q = from l in q
                    where
                    l.Id.Contains(c.key)
                    || l.SurfaceNumber.Contains(c.key)
                    || l.MsCode.Contains(c.key)
                    || l.CardCode.Contains(c.key)
                    || l.CardName.Contains(c.key)
                    || l.MsName.Contains(c.key)
                    || l.CardState.Contains(c.key)
                    || l.PrepaidPassword.Contains(c.key)
                    || l.CurrentPrepaidEncrypt.Contains(c.key)
                    || l.Operator.Contains(c.key)
                    select l;


            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }

        [Transaction]
        public IList<MsCardArchives> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key) == false)
            {
                q = from l in q
                    where
                    l.Id.Contains(key)
                    || l.SurfaceNumber.Contains(key)
                    || l.MsCode.Contains(key)
                    || l.CardCode.Contains(key)
                    || l.CardName.Contains(key)
                    || l.MsName.Contains(key)
                    || l.CardState.Contains(key)
                    || l.PrepaidPassword.Contains(key)
                    || l.CurrentPrepaidEncrypt.Contains(key)
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


        [Transaction]
        public string SaveList(List<MsCardArchives> msCardArchivesList)
        {
            string result = string.Empty;

            List<string> cardSurfaceNumberList = msCardArchivesList.Select(x => x.SurfaceNumber).ToList();
            bool flag = EntityRepository.LinqQuery.Any(x => cardSurfaceNumberList.Contains(x.SurfaceNumber));

            if (flag)
            {
                // 返回错误信息
                foreach (var item in msCardArchivesList)
                {
                    if (EntityRepository.LinqQuery.Any(x => x.SurfaceNumber.Equals(item.SurfaceNumber)))
                    {
                        result += "卡号码: " + item.SurfaceNumber + " 重复,无法保存" + Environment.NewLine; 
                    }
                }
            }
            else
            {
                // 保存
                foreach (var item in msCardArchivesList)
                {
                    Create(item);
                }
            }

            return result;
        }
    }
}