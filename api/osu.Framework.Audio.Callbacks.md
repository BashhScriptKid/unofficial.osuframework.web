# <a id="osu_Framework_Audio_Callbacks"></a> Namespace osu.Framework.Audio.Callbacks

### Classes

 [BassCallback](osu.Framework.Audio.Callbacks.BassCallback.md)

Abstract class that provides an optional pinned <xref href="osu.Framework.Allocation.ObjectHandle%601" data-throw-if-not-resolved="false"></xref>, used for callbacks to
the Bass library.

 [DataStreamFileProcedures](osu.Framework.Audio.Callbacks.DataStreamFileProcedures.md)

Implementation of <xref href="osu.Framework.Audio.Callbacks.IFileProcedures" data-throw-if-not-resolved="false"></xref> that supports reading from a <xref href="System.IO.Stream" data-throw-if-not-resolved="false"></xref>.

 [FileCallbacks](osu.Framework.Audio.Callbacks.FileCallbacks.md)

Wrapper on <xref href="ManagedBass.FileProcedures" data-throw-if-not-resolved="false"></xref> to provide functionality in <xref href="osu.Framework.Audio.Callbacks.BassCallback" data-throw-if-not-resolved="false"></xref>.
Can delegate to a class implementing the <xref href="osu.Framework.Audio.Callbacks.IFileProcedures" data-throw-if-not-resolved="false"></xref> interface.

 [SyncCallback](osu.Framework.Audio.Callbacks.SyncCallback.md)

Wrapper on <xref href="ManagedBass.SyncProcedure" data-throw-if-not-resolved="false"></xref> to provide functionality in <xref href="osu.Framework.Audio.Callbacks.BassCallback" data-throw-if-not-resolved="false"></xref>.

### Interfaces

 [IFileProcedures](osu.Framework.Audio.Callbacks.IFileProcedures.md)

Interface that closely matches the definition of the <xref href="ManagedBass.FileProcedures" data-throw-if-not-resolved="false"></xref> struct.

