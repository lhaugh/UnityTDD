using System.Collections.Generic;
using UnityEngine;

namespace Project.Feature
{
    /// <summary>
    /// A storage unit for all registered users.
    /// </summary>
    public interface IUserStore 
    {
        /// <summary>
        /// The storage of all registered users.
        /// </summary>
        /// <value></value>
        IEnumerator<IUser> users { get; }
        
        IUser GetUser(int id);
        IUser CreateUser();

    }
}