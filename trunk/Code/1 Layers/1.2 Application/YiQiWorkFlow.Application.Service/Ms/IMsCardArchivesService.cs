/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsCardArchivesService
    {
        string Create(MsCardArchives entity);

        MsCardArchives GetById(string id);

        IList<MsCardArchives> GetAll();

        void Update(MsCardArchives entity);

        /// <summary>
        /// 删除指定MsCardArchives
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsCardArchives entity);

        /// <summary>
        /// MsCardArchives
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsCardArchives> entitys);


        SearchResult<MsCardArchives> Search(SearchDtoBase<MsCardArchives> c);
		
		IList<MsCardArchives> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);

        #region 自定义方法

        /// <summary>
        /// 根据卡制作信息批量验证并保存
        /// </summary>
        /// <param name="msCardArchivesList"></param>
        /// <returns></returns>
        string SaveList(List<MsCardArchives> msCardArchivesList);

        /// <summary>
        /// 根据卡制作信息审核,激活卡信息状态为
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        bool ExamByMadeCardManage(MsMadecardManage m);

        #endregion

        
    }
}