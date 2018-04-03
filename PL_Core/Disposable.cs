using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_Core
{
    /// <summary>
    /// Disposable 类实现。
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    /// <author>
    /// Dongde
    /// </author>
    /// <remarks>
    /// 2016/9/6 [Dongde] 创建。
    /// </remarks>
    public class Disposable : IDisposable
    {
        private bool _isDisposed;

        /// <summary>
        /// 析构
        /// </summary>
        ~Disposable()
        {
            Dispose(true);
        }


        /// <summary>
        /// 执行与释放或重置非托管资源相关的应用程序定义的任务。
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        /// <summary>
        /// 释放资源
        /// </summary>
        /// <param name="aDisposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        private void Dispose(bool aDisposing)
        {
            if (!_isDisposed && aDisposing)
            {
                DisposeCore();
            }

            _isDisposed = true;
        }

        /// <summary>
        /// 释放资源核心代码，由子类覆盖。
        /// </summary>
        /// <author>
        /// Dongde
        /// </author>
        /// <remarks>
        /// 2016/9/6 [Dongde] 创建。
        /// </remarks>
        protected virtual void DisposeCore()
        {

        }
    }



}
