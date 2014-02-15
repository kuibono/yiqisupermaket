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
using YiQiWorkFlow.Domain.Em;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Em
{
    public class EmEmployeeArchivesService:IEmEmployeeArchivesService
    {

        public IRepositoryGUID<EmEmployeeArchives> EntityRepository { get; set; }

        [Transaction]
        public string Create(EmEmployeeArchives entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public EmEmployeeArchives GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<EmEmployeeArchives> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(EmEmployeeArchives entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(EmEmployeeArchives entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<EmEmployeeArchives> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<EmEmployeeArchives> Search(SearchDtoBase<EmEmployeeArchives> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.EmName) == false)
					{
						q = q.Where(p => p.EmName.Contains(c.entity.EmName));
					}
					if (string.IsNullOrEmpty(c.entity.NameUsed) == false)
					{
						q = q.Where(p => p.NameUsed.Contains(c.entity.NameUsed));
					}
					if (string.IsNullOrEmpty(c.entity.Sex) == false)
					{
						q = q.Where(p => p.Sex.Contains(c.entity.Sex));
					}
					if (string.IsNullOrEmpty(c.entity.PoliticsCode) == false)
					{
						q = q.Where(p => p.PoliticsCode.Contains(c.entity.PoliticsCode));
					}
					if (string.IsNullOrEmpty(c.entity.NationCode) == false)
					{
						q = q.Where(p => p.NationCode.Contains(c.entity.NationCode));
					}
					if (string.IsNullOrEmpty(c.entity.EducationCode) == false)
					{
						q = q.Where(p => p.EducationCode.Contains(c.entity.EducationCode));
					}
					if (string.IsNullOrEmpty(c.entity.ProfessionalTitleCode) == false)
					{
						q = q.Where(p => p.ProfessionalTitleCode.Contains(c.entity.ProfessionalTitleCode));
					}
					if (string.IsNullOrEmpty(c.entity.IfMarried) == false)
					{
						q = q.Where(p => p.IfMarried.Contains(c.entity.IfMarried));
					}
					if (string.IsNullOrEmpty(c.entity.NativePlace) == false)
					{
						q = q.Where(p => p.NativePlace.Contains(c.entity.NativePlace));
					}
					if (string.IsNullOrEmpty(c.entity.Idcard) == false)
					{
						q = q.Where(p => p.Idcard.Contains(c.entity.Idcard));
					}
					if (string.IsNullOrEmpty(c.entity.FamilyPhone) == false)
					{
						q = q.Where(p => p.FamilyPhone.Contains(c.entity.FamilyPhone));
					}
					if (string.IsNullOrEmpty(c.entity.Handset) == false)
					{
						q = q.Where(p => p.Handset.Contains(c.entity.Handset));
					}
					if (string.IsNullOrEmpty(c.entity.eMail) == false)
					{
						q = q.Where(p => p.eMail.Contains(c.entity.eMail));
					}
					if (string.IsNullOrEmpty(c.entity.FamilyAddress) == false)
					{
						q = q.Where(p => p.FamilyAddress.Contains(c.entity.FamilyAddress));
					}
					if (string.IsNullOrEmpty(c.entity.Postalcode) == false)
					{
						q = q.Where(p => p.Postalcode.Contains(c.entity.Postalcode));
					}
					if (string.IsNullOrEmpty(c.entity.GraduateAcademy) == false)
					{
						q = q.Where(p => p.GraduateAcademy.Contains(c.entity.GraduateAcademy));
					}
					if (string.IsNullOrEmpty(c.entity.dCode) == false)
					{
						q = q.Where(p => p.dCode.Contains(c.entity.dCode));
					}
					if (string.IsNullOrEmpty(c.entity.bCode) == false)
					{
						q = q.Where(p => p.bCode.Contains(c.entity.bCode));
					}
					if (string.IsNullOrEmpty(c.entity.DutyCode) == false)
					{
						q = q.Where(p => p.DutyCode.Contains(c.entity.DutyCode));
					}
					if (string.IsNullOrEmpty(c.entity.BankAccount) == false)
					{
						q = q.Where(p => p.BankAccount.Contains(c.entity.BankAccount));
					}
					if (string.IsNullOrEmpty(c.entity.PensionAccount) == false)
					{
						q = q.Where(p => p.PensionAccount.Contains(c.entity.PensionAccount));
					}
					if (string.IsNullOrEmpty(c.entity.EmState) == false)
					{
						q = q.Where(p => p.EmState.Contains(c.entity.EmState));
					}
					 if (c.entity.Stature > 0)
					{
						q = q.Where(p => p.Stature == c.entity.Stature);
					}
					
					 if (c.entity.Width > 0)
					{
						q = q.Where(p => p.Width == c.entity.Width);
					}
					
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.EmName.Contains(c.key)
					|| l.NameUsed.Contains(c.key)
					|| l.Sex.Contains(c.key)
					|| l.PoliticsCode.Contains(c.key)
					|| l.NationCode.Contains(c.key)
					|| l.EducationCode.Contains(c.key)
					|| l.ProfessionalTitleCode.Contains(c.key)
					|| l.IfMarried.Contains(c.key)
					|| l.NativePlace.Contains(c.key)
					|| l.Idcard.Contains(c.key)
					|| l.FamilyPhone.Contains(c.key)
					|| l.Handset.Contains(c.key)
					|| l.eMail.Contains(c.key)
					|| l.FamilyAddress.Contains(c.key)
					|| l.Postalcode.Contains(c.key)
					|| l.GraduateAcademy.Contains(c.key)
					|| l.dCode.Contains(c.key)
					|| l.bCode.Contains(c.key)
					|| l.DutyCode.Contains(c.key)
					|| l.BankAccount.Contains(c.key)
					|| l.PensionAccount.Contains(c.key)
					|| l.EmState.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<EmEmployeeArchives> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.EmName.Contains(key)
					|| l.NameUsed.Contains(key)
					|| l.Sex.Contains(key)
					|| l.PoliticsCode.Contains(key)
					|| l.NationCode.Contains(key)
					|| l.EducationCode.Contains(key)
					|| l.ProfessionalTitleCode.Contains(key)
					|| l.IfMarried.Contains(key)
					|| l.NativePlace.Contains(key)
					|| l.Idcard.Contains(key)
					|| l.FamilyPhone.Contains(key)
					|| l.Handset.Contains(key)
					|| l.eMail.Contains(key)
					|| l.FamilyAddress.Contains(key)
					|| l.Postalcode.Contains(key)
					|| l.GraduateAcademy.Contains(key)
					|| l.dCode.Contains(key)
					|| l.bCode.Contains(key)
					|| l.DutyCode.Contains(key)
					|| l.BankAccount.Contains(key)
					|| l.PensionAccount.Contains(key)
					|| l.EmState.Contains(key)
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




