# x32dotnet

X32.net is a reusuable class libray to natively communicate with the Behringer X32 digital mixing console.  Typically, when wanting to 
write custom software that supports the X32, programmers need to become proficient in the OSC protocol and UDP network programming.  
X32.net encapsulates all of that network and protocol logic then exposes the X32 as an easy to use .NET class.  

Access X32 functions with simple .NET methods calls, for example:

X32Console X32 = new X32Console();

X32.Connect();
X32.Channel[0].Strip.Fader.Value = 0.05f;
X32.SendParameter(X32.Channel[0].Strip.Fader);
X32.Disconnect();

This is a simple program that connects to a X32 and moves the first fader.  No OSC, no UDP, just write easy to read code.

