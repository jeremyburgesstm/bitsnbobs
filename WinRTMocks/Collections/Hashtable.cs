/*
 * This source file is part of one of Jeremy Burgess's samples.
 *
 * Copyright (c) 2013 Jeremy Burgess 
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using System;
using System.Collections.Generic;

namespace WinRTMocks.Collections
{
	/// <summary>
	/// Have you written something that uses only the simplest parts of "Hashtable"?
	/// 
	/// Does it use so many that the very thought of replacing them all with Dictionaries is horrific 
	/// terrifying?
	/// 
	/// Do you now _need_ to convert it to support Windows RT?
	/// 
	/// Then this is the class for you! Simple copy of a very reduced hashtable. Functionality greatly
	/// reduced, but should be easy enough to extend to support whatever bits of Hashtable you need.
	/// </summary>
	class Hashtable
	{
		private Dictionary<object, object> m_innerDictionary = new Dictionary<object, object>();

		public virtual int Count
		{
			get { return m_innerDictionary.Count; }
		}

		public virtual System.Collections.ICollection Keys
		{
			get { return m_innerDictionary.Keys; }
		}

		public virtual System.Collections.ICollection Value
		{
			get { return m_innerDictionary.Values; }
		}
		
		public virtual object this[object key]
		{
			get { return m_innerDictionary[key]; }
			set { m_innerDictionary[key] = value; }
		}

		public Hashtable(Hashtable other)
		{
			m_innerDictionary = new Dictionary<object, object>(m_innerDictionary);
		}

		public virtual void Add(object key, object value)
		{
			m_innerDictionary.Add(key, value);
		}

		public virtual void Clear()
		{
			m_innerDictionary.Clear();
		}

		public virtual object Clone()
		{
			return new Hashtable(this);
		}

		public virtual bool Contains(object key)
		{
			return ContainsKey(key);
		}

		public virtual bool ContainsKey(object key)
		{
			return m_innerDictionary.ContainsKey(key);
		}

		public virtual bool ContainsValue(object key)
		{
			return m_innerDictionary.ContainsValue(key);
		}

		public virtual void Remove(object key)
		{
			m_innerDictionary.Remove(key);
		}
	}
}
