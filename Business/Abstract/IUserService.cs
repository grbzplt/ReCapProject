using Core.Utilities.Results.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //: IEntityService<User>
    public interface IUserService 
    {
        List<OperationClaim> GetClaims(User user);
        User GetByEmail(string email);
        void Add(User user);
    }
}