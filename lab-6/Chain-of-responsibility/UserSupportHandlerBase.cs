using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    internal abstract class UserSupportHandlerBase : IUserSupportHandler
    {
        private IUserSupportHandler? _next;

        public UserSupportHandlerBase SetNext(UserSupportHandlerBase next)
        {
            this._next = next;

            return next;
        }

        public virtual string Handle()
        {
            if (this._next == null)
            {
                return "Default Handler";
            } else
            {
                return this._next.Handle();
            }
        }
    }
}
