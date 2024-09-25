using System.Collections.Concurrent;
using UnityEngine;


namespace Pixeltheory
{
    public class PixelPool
    {
        #region Fields
        #region Private
        private GameObject pooledPrefab;
        private ConcurrentBag<GameObject> pool;
        #endregion //Private
        #endregion //Fields

        #region Constructor
        public PixelPool(GameObject prefab, int initialAmount = 0)
        {
            this.pooledPrefab = prefab;
            this.pool = new ConcurrentBag<GameObject>();
            for (int i = 0; i < initialAmount; i++)
            {
                this.pool.Add(GameObject.Instantiate(this.pooledPrefab)); 
            }
        }
        #endregion //Constructor

        #region Destructor
        ~PixelPool()
        {
            this.pool.Clear();
            this.pooledPrefab = null;
        }
        #endregion //Destructor

        #region Methods
        #region Public
        public GameObject Borrow()
        {
            GameObject lendable;
            if (!this.pool.TryTake(out lendable))
            {
                lendable = GameObject.Instantiate(this.pooledPrefab);
            }
            return lendable;
        }
        
        public void Return(GameObject lendable, IPoolable resettable)
        {
            resettable.PoolReturnReset();
            this.pool.Add(lendable);
        }
        #endregion //Public
        #endregion //Methods
    }
}