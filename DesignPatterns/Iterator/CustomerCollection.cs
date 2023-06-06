using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Iterator
{
    class CustomerCollection : Iterator
    {
        List<Customer> customer = new List<Customer>();
        private int _position = 0;

        public void ReverseDirection()
        {
            customer.Reverse();
        }

        public List<Customer> getItems()
        {
            return customer;
        }

        public void AddItem(Customer item)
        {
            customer.Add(item);
        }
       

        public override int Key()
        {
            return _position;
        }

        public override object Current()
        {
            return getItems()[_position];

        }

        public override bool MoveNext()
        {
            int updatedPosition = _position + 1;

            if (updatedPosition >= 0 && updatedPosition < getItems().Count)
            {
                _position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            _position = -1;
        }

        public override IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
