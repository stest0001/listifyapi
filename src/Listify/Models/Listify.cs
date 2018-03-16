using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Listify.Models
{
    public class Listify : IList<int>
    {
        private readonly int _minVal;
        private readonly int _maxVal;
        private readonly IEnumerable<int> _listVals;

        public Listify(int min, int max)
        {
            _minVal = Math.Min(min, max);
            _maxVal = Math.Max(min, max);

            _listVals = Enumerable.Range(_minVal, (_maxVal - _minVal));
        }

        public int this[int index]
        {
            get
            {
                var range = _maxVal - _minVal;

                if (index >= range)
                {
                    throw new IndexOutOfRangeException();
                }

                var val = _listVals.First();
                var count = 0;

                foreach (var i in _listVals)
                {
                    if (count == index)
                    {
                        val = i;
                        break;
                    }

                    count++;
                }

                return val;
            }

            set => throw new NotSupportedException();
        }

        public bool IsReadOnly => false;

        public bool IsFixedSize => false;

        public int Count => _maxVal - _minVal;

        public void Add(int item)
        {
            throw new NotSupportedException();
        }

        public void Clear()
        {
            throw new NotSupportedException();
        }

        public bool Contains(int item)
        {
            return item >= _minVal && item < _maxVal;
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotSupportedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotSupportedException();
        }

        public int IndexOf(int item)
        {
            if (item < _minVal || item >= _maxVal)
            {
                return -1;
            }

            return item - _minVal;
        }

        public void Insert(int index, int item)
        {
            throw new NotSupportedException();
        }

        public bool Remove(int item)
        {
            throw new NotSupportedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotSupportedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotSupportedException();
        }
    }
}