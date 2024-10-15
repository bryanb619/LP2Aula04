using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coroutine.Assets.Scripts
{
    public abstract class AbstractItem : MonoBehaviour, IHasWeight, 
    IBag<AbstractItem>
    {   
        // IHasWeight interface
        public abstract float Weight { get; protected set;}



        // IBag interface ------------------------------------------------------
        public void Add(AbstractItem item)
        {

        }

        public void Remove(AbstractItem item)
        {
            
        }

        public IEnumerator<AbstractItem> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}