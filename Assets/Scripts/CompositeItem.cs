using System.Collections.Generic;

namespace Coroutine.Assets.Scripts
{
    public class CompositeItem : AbstractItem
    {
        public override float Weight { get; protected set; }


        // ref de agregação
        private List<AbstractItem> composite = new List<AbstractItem>(); 

        

    }
}