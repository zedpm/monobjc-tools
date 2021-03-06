//
// This file is part of Monobjc, a .NET/Objective-C bridge
// Copyright (C) 2007-2013 - Laurent Etiemble
//
// Monobjc is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// any later version.
//
// Monobjc is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with Monobjc.  If not, see <http://www.gnu.org/licenses/>.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Monobjc.Tools.Generator.Model
{
	/// <summary>
	///   Represents the model for an enumaration.
	/// </summary>
	[Serializable]
	[XmlRoot("Enumeration")]
	[XmlInclude(typeof(EnumerationValueEntity))]
	public partial class EnumerationEntity : TypedEntity
	{
		/// <summary>
		///   Initializes a new instance of the <see cref = "EnumerationEntity" /> class.
		/// </summary>
		public EnumerationEntity ()
		{
			this.Values = new EnumerationValueCollection();
		}

		/// <summary>
		///   Gets or sets a value indicating whether this <see cref = "EnumerationEntity" /> is flags.
		/// </summary>
		/// <value><c>true</c> if flags; otherwise, <c>false</c>.</value>
		[XmlAttribute]
		public bool Flags {
			get;
			set;
		}

		/// <summary>
		///   Gets or sets the values.
		/// </summary>
		/// <value>The values.</value>
		[XmlArray]
		[XmlArrayItem (typeof(EnumerationValueEntity), ElementName = "EnumerationValue")]
		public EnumerationValueCollection Values {
			get;
			set;
		}

		/// <summary>
		///   Gets the children.
		/// </summary>
		/// <value>The children.</value>
		[XmlIgnore]
		public override List<BaseEntity> Children {
			get {
				List<BaseEntity> children = new List<BaseEntity> ();
				children.AddRange (this.Values.Cast<BaseEntity> ());
				return children;
			}
		}

		/// <summary>
		///   Serves as a hash function for a particular type.
		/// </summary>
		/// <returns>
		///   A hash code for the current <see cref = "T:System.Object" />.
		/// </returns>
		/// <filterpriority>2</filterpriority>
		public override int GetHashValue ()
		{
			unchecked {
				int hash = base.GetHashValue();
				hash = hash * 23 + this.Flags.GetHashCode ();
				hash = hash * 23 + this.Values.GetHashValue ();
				return hash;
			}
		}
	}
}