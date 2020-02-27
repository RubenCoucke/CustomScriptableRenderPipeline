﻿using System.Collections;
using System.Collections.Generic;

namespace UnityEditor.ShaderGraph.Internal
{
    public class FieldCollection : IEnumerable<FieldCollection.Item>
    {
        public class Item 
        {
            public FieldDescriptor field { get; }

            public Item(FieldDescriptor field)
            {
                this.field = field;
            }
        }

        readonly List<FieldCollection.Item> m_Items;

        public FieldCollection()
        {
            m_Items = new List<FieldCollection.Item>();
        }

        public void Add(FieldCollection fields)
        {
            foreach(FieldCollection.Item item in fields)
            {
                m_Items.Add(item);
            }
        }

        public void Add(FieldDescriptor field)
        {
            m_Items.Add(new Item(field));
        }

        public IEnumerator<FieldCollection.Item> GetEnumerator()
        {
            return m_Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
