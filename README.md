# Unnatural Pose Detector for SlimeVR
VRChat で SlimeVRを使っているときに、chestやwaistが妙な捻れ方をしているのに、ミラーを出していなくて気づくのが遅れることがあるので、通知してくれるソフトを作りました。
SlimeVRSever に VMCProtocol を送出させて、human://CHEST と human::/WAIST のrotation を見てYやZが30度(設定可能)以上ずれていたら、tada.wav(変更可能)を鳴らします。
一応、VMCProtocol を他のポートに転送する機能をつけてありますが、未テスト（VRChatしながら他のVMCPソフト使うことがほぼないので)

Visual Studio 2022 でビルドできます。.NET で C# で Forms です。

MITライセンスです。(Forms1.cs, Form1.Designer.cs, Program.cs に記載)

uOSCフォルダ内のプログラムは他者製MITライセンスソフトウェアuOSC を利用しています。
元はUnity用C# のためDebug.Log 等になっているのを、Console.WriteLineに変更しています。
[uOSC のライセンス表示](https://github.com/hecomi/uOSC/blob/master/LICENSE.md)
