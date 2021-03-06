#if NETSTANDARD1_5
using System.ComponentModel;
using System.IO;
using JetBrains.Annotations;

namespace Thinktecture.IO.Adapters
{
	/// <summary>Adds a buffering layer to read and write operations on another stream. This class cannot be inherited.</summary>
	public class BufferedStreamAdapter : StreamAdapter, IBufferedStream
	{
		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new BufferedStream UnsafeConvert()
		{
			return Implementation;
		}

		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new BufferedStream Implementation { get; }

		/// <summary>Initializes a new instance of the <see cref="BufferedStreamAdapter" /> class with a default buffer size of 4096 bytes.</summary>
		/// <param name="stream">The current stream. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> is <see langword="null" />. </exception>
		public BufferedStreamAdapter(Stream stream)
			: this(new BufferedStream(stream))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BufferedStreamAdapter" /> class with the specified buffer size.</summary>
		/// <param name="stream">The current stream. </param>
		/// <param name="bufferSize">The buffer size in bytes. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="bufferSize" /> is negative. </exception>
		public BufferedStreamAdapter(Stream stream, int bufferSize)
			: this(new BufferedStream(stream, bufferSize))
		{
		}

		/// <summary>
		/// Initializes new instance of the <see cref="BufferedStreamAdapter"/>.
		/// </summary>
		/// <param name="stream">Inner stream.</param>
		public BufferedStreamAdapter([NotNull] BufferedStream stream)
			: base(stream)
		{
			Implementation = stream;
		}
	}
}
#endif
