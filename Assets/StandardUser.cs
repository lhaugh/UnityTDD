using UnityEngine;

namespace Project.Feature
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class StandardUser : MonoBehaviour, IUser
    {
        public int Id
        {
            get
            {
                return id;
            }
        }


        private int id;


        public StandardUser(int id)
        {
            this.id = id;
        }
    }
}