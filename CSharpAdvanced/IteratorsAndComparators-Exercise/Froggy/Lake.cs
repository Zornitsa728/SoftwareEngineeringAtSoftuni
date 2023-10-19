using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        private int index;
        public Lake(List<int> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int j = index; j <= stones.Count - 1; j += 2)
            {
                yield return stones[j];
            }

            if (stones.Count % 2 == 0)
            {
                index = stones.Count - 1;
            }
            else
            {
                index = stones.Count - 2;
            }

            for (int i = index; i >= 0; i -= 2)
            {
                yield return stones[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
