#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.Net.NetworkInformation;
using JetBrains.Annotations;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>
	/// Statics of <see cref="PhysicalAddress"/>
	/// </summary>
	public interface IPhysicalAddressGlobals
	{
		/// <summary>
		/// Returns a new <see cref="IPhysicalAddress"/> instance with a zero length address. This field is read-only.
		/// </summary>
		[NotNull]
		IPhysicalAddress None { get; }

		/// <summary>
		/// Parses the specified <see cref="String"/> and stores its contents as the address bytes of the <see cref="IPhysicalAddress"/> returned by this method.
		/// </summary>
		/// <param name="address">A String containing the address that will be used to initialize the PhysicalAddress instance returned by this method.</param>
		/// <returns>A <see cref="IPhysicalAddress"/> instance with the specified address.</returns>
		[NotNull]
		IPhysicalAddress Parse([CanBeNull] string address);
	}
}

#endif
