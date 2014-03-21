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
    public class SysEnterpriseArchivesService : ISysEnterpriseArchivesService
    {
        public IRepositoryGUID<SysEnterpriseArchives> EntityRepository { get; set; }

        [Transaction]
        public string Create(SysEnterpriseArchives entity)
        {
            if (entity.HaveId == false)
            {
                entity.GenerateId();
                entity.EnCode = GenerateEnterpriseCode();
                entity.LastVersion = "1";
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public SysEnterpriseArchives GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<SysEnterpriseArchives> GetAll()
        {
            var result = EntityRepository.LinqQuery.ToList();

            return result;
        }

        [Transaction]
        public void Update(SysEnterpriseArchives entity)
        {
            if (!string.IsNullOrEmpty(entity.LastVersion))
            {
                entity.LastVersion = "" + Convert.ToInt32(entity.LastVersion) + 1; 
            }
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(SysEnterpriseArchives entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<SysEnterpriseArchives> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }

        [Transaction]
        public SearchResult<SysEnterpriseArchives> Search(SearchDtoBase<SysEnterpriseArchives> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
                if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
                if (string.IsNullOrEmpty(c.entity.EnCode) == false)
                {
                    q = q.Where(p => p.EnCode.Contains(c.entity.EnCode));
                }
                if (string.IsNullOrEmpty(c.entity.EnName) == false)
                {
                    q = q.Where(p => p.EnName.Contains(c.entity.EnName));
                }
                if (string.IsNullOrEmpty(c.entity.EnComName) == false)
                {
                    q = q.Where(p => p.EnComName.Contains(c.entity.EnComName));
                }
                if (string.IsNullOrEmpty(c.entity.EnType) == false)
                {
                    q = q.Where(p => p.EnType.Contains(c.entity.EnType));
                }
                if (string.IsNullOrEmpty(c.entity.EnCharacter) == false)
                {
                    q = q.Where(p => p.EnCharacter.Contains(c.entity.EnCharacter));
                }
                if (c.entity.DealArea > 0)
                {
                    q = q.Where(p => p.DealArea == c.entity.DealArea);
                }

                if (string.IsNullOrEmpty(c.entity.RegisterAddress) == false)
                {
                    q = q.Where(p => p.RegisterAddress.Contains(c.entity.RegisterAddress));
                }
                if (string.IsNullOrEmpty(c.entity.CurrentVersion) == false)
                {
                    q = q.Where(p => p.CurrentVersion.Contains(c.entity.CurrentVersion));
                }
                if (string.IsNullOrEmpty(c.entity.LastVersion) == false)
                {
                    q = q.Where(p => p.LastVersion.Contains(c.entity.LastVersion));
                }

            }
            if (string.IsNullOrEmpty(c.key) == false)
            {
                q = from l in q
                    where
                    l.Id.Contains(c.key)
                    || l.EnCode.Contains(c.key)
                    || l.EnName.Contains(c.key)
                    || l.EnComName.Contains(c.key)
                    || l.EnType.Contains(c.key)
                    || l.EnCharacter.Contains(c.key)
                    || l.RegisterAddress.Contains(c.key)
                    || l.CurrentVersion.Contains(c.key)
                    || l.LastVersion.Contains(c.key)
                    select l;


            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }

        [Transaction]
        public IList<SysEnterpriseArchives> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key) == false)
            {
                q = from l in q
                    where
                    l.Id.Contains(key)
                    || l.EnCode.Contains(key)
                    || l.EnName.Contains(key)
                    || l.EnComName.Contains(key)
                    || l.EnType.Contains(key)
                    || l.EnCharacter.Contains(key)
                    || l.RegisterAddress.Contains(key)
                    || l.CurrentVersion.Contains(key)
                    || l.LastVersion.Contains(key)
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

        public string GenerateEnterpriseCode()
        {
            string maxCardTypeCode = GetMaxEnterpriseCode();

            if (string.IsNullOrEmpty(maxCardTypeCode))
            {
                return "0000";
            }
            else
            {
                int maxCardTypeCodeInt = Convert.ToInt32(maxCardTypeCode);

                return (maxCardTypeCodeInt + 1).ToString("0000");
            }
        }

        private string GetMaxEnterpriseCode()
        {
            string enCode = EntityRepository.LinqQuery.Max(x => x.EnCode);

            if (string.IsNullOrEmpty(enCode))
            {
                return string.Empty;
            }
            else
            {
                return enCode;
            }
        }
    }
}