using Microsoft.EntityFrameworkCore;
using PL_Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PL_CoreFrame.Data.EF
{
    public class DAL<Mo, Entity> : IDAL<Mo>
                     where Entity : class, new()
    {
        

        public DAL(IEfRepository<Entity> aIEfRepository)
        {
            this._repository = aIEfRepository;
        }

        /// <summary>
        /// 数据操作上下文对象.
        /// </summary>
        /// <value>
        /// The DbContext.
        /// </value>
        protected DbContext DbContext
        {
            get { return _repository.CurrentDbContext; }
        }


        /// <summary>
        /// EF的数据操作类
        /// </summary>
        /// <value>
        /// The Ef repository.
        /// </value>
        protected IEfRepository<Entity> EfRepository
        {
            get { return _repository; }
        }


        /// <summary>
        /// 从Model到数据实体
        /// </summary>
        /// <param name="aModel">a model.</param>
        /// <returns>
        /// 返回 <seealso cref="Entity" />。
        /// </returns>
        /// <author>
        /// Dongde
        /// </author>
        /// <remarks>
        /// 2016/8/24 [Dongde] 创建。
        /// </remarks>
        protected virtual Entity GetEntity_MapperFromModel(Mo aModel)
        {
            if (aModel != null)
                return AutoMapper.Mapper.Map<Mo, Entity>(aModel);
            else
                return default(Entity);
        }


        /// <summary>
        /// 从数据实体到Model
        /// </summary>
        /// <param name="aEntity">a entity.</param>
        /// <returns>
        /// 返回 <seealso cref="M" />。
        /// </returns>
        /// <author>
        /// Dongde
        /// </author>
        /// <remarks>
        /// 2016/8/24 [Dongde] 创建。
        /// </remarks>
        protected virtual Mo GetModel_MapperFromEntity(Entity aEntity)
        {
            if (aEntity != null)
                return AutoMapper.Mapper.Map<Entity, Mo>(aEntity);
            else
                return default(Mo);
        }

        protected virtual string Base_Create(Mo aModel)
        {
            using (TransactionScope tans = new TransactionScope())
            {
                try
                {
                    _repository.Create(GetEntity_MapperFromModel(aModel));
                    _repository.Flush();
                    tans.Complete();
                    return string.Empty;
                }
                catch (Exception aException)
                {               
                    return "数据操作错误。";
                }
            }
        }

        protected virtual string Base_Update(Mo aModel)
        {
            using (TransactionScope tans = new TransactionScope())
            {
                try
                {
                    _repository.Update(GetEntity_MapperFromModel(aModel));
                    _repository.Flush();
                    tans.Complete();
                    return string.Empty;
                }
                catch (Exception aException)
                {                  
                    return "数据操作错误。";
                }
            }
        }

        protected virtual string Base_SaveOrUpdate(Mo aModel)
        {
            return "";
        }

        protected virtual string Base_Delete(object aKey)
        {
            using (TransactionScope tans = new TransactionScope())
            {
                try
                {
                    _repository.Delete(aKey);
                    _repository.Flush();
                    tans.Complete();
                    return string.Empty;
                }
                catch (Exception aException)
                {
                 
                    return "数据操作错误。";
                }
            }
        }

        protected virtual Entity GetEntity(object aKey)
        {
            return _repository.Get(aKey);
        }

        protected IQueryable<Entity> TableQueryable
        {
            get
            {
                return _repository.Table();
            }
        }

        protected List<Entity> Entities
        {
            get
            {
                return _repository.Table().ToList();
            }
        }

        protected List<Entity> Entities_Cached
        {
            get
            {
                return _repository.TableWithCache().ToList();
            }
        }


        #region 接口方法

        public void Create(Mo aModel, ref string aResultMessage)
        {
            aResultMessage = Base_Create(aModel);
        }

        public void Update(Mo aModel, ref string aResultMessage)
        {
            aResultMessage = Base_Update(aModel);
        }

        public void SaveOrUpdate(Mo aModel, ref string aResultMessage)
        {
            aResultMessage = Base_SaveOrUpdate(aModel);
        }

        public void Delete(object aKey, ref string aResultMessage)
        {
            aResultMessage = Base_Delete(aKey);
        }

        public Mo Get(object aKey)
        {
            return GetModel_MapperFromEntity(GetEntity(aKey));
        }

        public void Commit()
        {
            
        }

        public void Cancel()
        {
           
        }

        #endregion



    }



}
