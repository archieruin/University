using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_6_1
{
    public class Tire
    {
        public string Title { get; }
        public string Text { get; }
        public DateTime PublishDate { get; }
        
        public Tire(string title, string text)
        {
            Title = title;
            Text = text;
            PublishDate = DateTime.Now;
        }

        public Tire(string title, string text, DateTime publishDate)
        {
            Title = title;
            Text = text;
            PublishDate = publishDate;
        }
    }
    
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();
        public abstract int Key();
        public abstract object Current();
        public abstract bool MoveNext();
        public abstract void Reset();
    }

    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
    
    class NewsCollection : IteratorAggregate
    {
        List<Tire> _collection = new List<Tire>();
        
        public List<Tire> GetItems()
        {
            return _collection;
        }
        
        public void AddItem(Tire item)
        {
            _collection.Add(item);
        }
        
        public override IEnumerator GetEnumerator()
        {
            return new NewsIterator(this);
        }
    }
  
    class NewsIterator : Iterator
    {
        private NewsCollection _collection;
        private int _position = -1;

        public NewsIterator(NewsCollection collection)
        {
            _collection = collection;
        }
        
        public override object Current()
        {
            return _collection.GetItems()[_position];
        }

        public override int Key()
        {
            return _position;
        }
        
        public override bool MoveNext()
        {
            int updatedPosition = _position + 1;

            if (updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }
            return false;
        }
        
        public override void Reset()
        {
            _position = 0;
        }
    }
}
