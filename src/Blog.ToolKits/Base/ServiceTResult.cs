using Blog.ToolKits.Base.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.ToolKits.Base
{
    public class ServiceTResult<T>:ServiceResult where T: class
    {
        /// <summary>
        /// 服务层响应实体(泛型)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T Result { get; set; }

        /// <summary>
        /// 响应成功
        /// </summary>
        /// <param name="result"></param>
        /// <param name="message"></param>
        public void IsSuccess(T result = null, string message = "")
        {
            Message = message;
            Code = ServiceResultCode.Succeed;
            Result = result;
        }
    }
}
