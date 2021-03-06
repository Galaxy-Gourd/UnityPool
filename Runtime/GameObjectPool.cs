using GGSharpPool;
using UnityEngine;

namespace GGUnityPool
{
    /// <summary>
    /// Base class for GameObject pools. Used automatically by Instantiator.cs
    /// </summary>
    public class GameObjectPool : PoolBase
    {
        public GameObject pooledGameObject;
        
        protected override IClientPoolable CreateNewPoolable()
        {
            GameObject newObj = Pool.Instantiate(pooledGameObject);
            return newObj.AddComponent<GameObjectPooledComponent>();
        }
    }
}