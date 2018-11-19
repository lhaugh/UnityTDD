using System.Collections.Generic;
using UnityEngine;

namespace Project.Feature
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class StandardUserStore : MonoBehaviour, IUserStore
    {
        public IEnumerator<IUser> users
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public IUser CreateUser()
        {
            throw new System.NotImplementedException();
        }

        public IUser GetUser(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}