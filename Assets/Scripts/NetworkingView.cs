﻿using UnityEngine;
using System.Collections;

public class NetworkingView : MonoBehaviour {

    private string connectionIP = "127.0.0.1";
    private int connectionPort = 25001;

    void OnGUI() {
        if (Network.peerType == NetworkPeerType.Disconnected) {
            GUI.Label(new Rect(10, 10, 200, 20), "Status: Disconnected");
        }
        if (GUI.Button(new Rect(10, 30, 120, 20), "Client Connect")) {
            Network.Connect(connectionIP, connectionPort);
        }
        if (GUI.Button(new Rect(10, 50, 120, 20), "Initailize Server")) {
            Network.InitializeServer(32, connectionPort, false);
        }
        else if (Network.peerType == NetworkPeerType.Client) {
            GUI.Label(new Rect(10, 10, 300, 20), "Status:Connected as client");
            if (GUI.Button(new Rect(10, 30, 120, 20), "Disconnect")) {
                Network.Disconnect(200);
            }
        }
    }
}
