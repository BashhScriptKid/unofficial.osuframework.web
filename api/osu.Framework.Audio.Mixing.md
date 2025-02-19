# <a id="osu_Framework_Audio_Mixing"></a> Namespace osu.Framework.Audio.Mixing

### Classes

 [AudioMixer](osu.Framework.Audio.Mixing.AudioMixer.md)

Mixes together multiple <xref href="osu.Framework.Audio.Mixing.IAudioChannel" data-throw-if-not-resolved="false"></xref>s into one output.

### Interfaces

 [IAudioChannel](osu.Framework.Audio.Mixing.IAudioChannel.md)

An audio channel which plays audio. Audio channels can be routed into different mixers via <xref href="osu.Framework.Audio.Mixing.IAudioMixer.Add(osu.Framework.Audio.Mixing.IAudioChannel)" data-throw-if-not-resolved="false"></xref>.

 [IAudioMixer](osu.Framework.Audio.Mixing.IAudioMixer.md)

An audio mixer which one or more <xref href="osu.Framework.Audio.Mixing.IAudioChannel" data-throw-if-not-resolved="false"></xref>s can be routed into.
Supports DSP effects independent of other <xref href="osu.Framework.Audio.Mixing.IAudioMixer" data-throw-if-not-resolved="false"></xref>s.

