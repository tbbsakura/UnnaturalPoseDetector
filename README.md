# Unnatural Pose Detector for SlimeVR
VRChat で SlimeVRを使っているときに、chestやwaistが妙な捻れ方をしているのに、ミラーを出していなくて気づくのが遅れることがあるので、通知してくれるソフトを作りました。
SlimeVRSever に VMCProtocol を送出させて、human://CHEST と human::/WAIST のrotation を見てYやZが30度(設定可能)以上ずれていたら、tada.wav(変更可能)を鳴らします。
一応、VMCProtocol を他のポートに転送する機能をつけてありますが、未テスト（VRChatしながら他のVMCPソフト使うことがほぼないので)

Visual Studio 2022 でビルドできます。.NET で C# で Forms です。

