/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:07
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Linq;
using NSH.Core.Domain;
using Spring.Transaction.Interceptor;
using YiQiWorkFlow.Domain.Tf;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tf
{
    public class TfDataDownloadService:ITfDataDownloadService
    {

        public IRepositoryGUID<TfDataDownload> EntityRepository { get; set; }

        [Transaction]
        public string Create(TfDataDownload entity)
        {
			if (entity.HaveId == false)
            {
                entity.GenerateId();
            }
            return EntityRepository.Save(entity);
        }

        [Transaction]
        public TfDataDownload GetById(string id)
        {
            return EntityRepository.Get(id);
        }

        [Transaction]
        public IList<TfDataDownload> GetAll()
        {
            var result=EntityRepository.LinqQuery.ToList();
           
            return result;
        }


        [Transaction]
        public void Update(TfDataDownload entity)
        {
            EntityRepository.Update(entity);
        }

        [Transaction]
        public void Delete(TfDataDownload entity)
        {
            EntityRepository.Delete(entity);
        }

        [Transaction]
        public void Delete(IEnumerable<TfDataDownload> entitys)
        {
            foreach (var entity in entitys)
            {
                EntityRepository.Delete(entity);
            }
        }


        [Transaction]
        public SearchResult<TfDataDownload> Search(SearchDtoBase<TfDataDownload> c)
        {
            var q = EntityRepository.LinqQuery;
            if (c.entity != null)
            {
				
				if (string.IsNullOrEmpty(c.entity.Id) == false)
                {
                    q = q.Where(p => p.Id.Contains(c.entity.Id));
                }
					if (string.IsNullOrEmpty(c.entity.DownloadTablename) == false)
					{
						
						q = q.Where(p => p.DownloadTablename.Contains(c.entity.DownloadTablename));
					}
					if (string.IsNullOrEmpty(c.entity.DownloadBranchcode) == false)
					{
						
						q = q.Where(p => p.DownloadBranchcode.Contains(c.entity.DownloadBranchcode));
					}
					if (string.IsNullOrEmpty(c.entity.DownloadKeyvalue) == false)
					{
						
						q = q.Where(p => p.DownloadKeyvalue.Contains(c.entity.DownloadKeyvalue));
					}
                
            }
			if (string.IsNullOrEmpty(c.key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(c.key)
					|| l.DownloadTablename.Contains(c.key)
					|| l.DownloadBranchcode.Contains(c.key)
					|| l.DownloadKeyvalue.Contains(c.key)
                    select l;
					
                
            }
            int count = q.Count();

            q = q.Skip((c.pageIndex - 1) * c.pageSize).Take(c.pageSize);
            var result = q.ToList();
            return result.ToSearchResult(count);
        }
		
		[Transaction]
        public IList<TfDataDownload> Search(string key, int pageSize = 20, int pageIndex = 1)
        {
            var q = EntityRepository.LinqQuery;
            if (string.IsNullOrEmpty(key)==false)
            {
				q = from l in q
                    where 
                    l.Id.Contains(key)
					|| l.DownloadId.Contains(key)
					|| l.DownloadTablename.Contains(key)
					|| l.DownloadBranchcode.Contains(key)
					|| l.DownloadKeyvalue.Contains(key)
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




