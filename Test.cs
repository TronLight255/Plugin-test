using System;
using MCGalaxy;
using MCGalaxy.Events.PlayerEvents;

public class AntiMod : Plugin {

    public override string name { get { return "AntiMod"; } }
    public override string creator { get { return "ChatGPT"; } }
    public override string MCGalaxy_Version { get { return "1.9.5.3"; } }

    // Palabras prohibidas
    string[] badWords = { "puta", "puto", "pendejo", "pendejo", "idiota", "mierda"};

    // Anti-spam (tiempos por jugador)
    static DateTime[] lastMsg = new DateTime[128];
    static int[] spamCount = new int[128];

    public override void Load(bool startup) {
        OnPlayerChatEvent.Register(HandleChat, 
