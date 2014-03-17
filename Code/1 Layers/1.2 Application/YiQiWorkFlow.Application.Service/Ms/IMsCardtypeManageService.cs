/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsCardtypeManageService
    {
        string Create(MsCardtypeManage entity);

        MsCardtypeManage GetById(string id);

        IList<MsCardtypeManage> GetAll();

        void Update(MsCardtypeManage entity);

        /// <summary>
        /// 删除指定MsCardtypeManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsCardtypeManage entity);

        /// <summary>
        /// MsCardtypeManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsCardtypeManage> entitys);

        SearchResult<MsCardtypeManage> Search(SearchDtoBase<MsCardtypeManage> c);

        IList<MsCardtypeManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);

        #region 自定义方法

        /// <summary>
        /// 生成新的卡类型Code (规则:00001 开始 每次递增 1)
        /// </summary>
        /// <returns></returns>
        string GenerateCardtypeCode();

        #endregion
    }
}