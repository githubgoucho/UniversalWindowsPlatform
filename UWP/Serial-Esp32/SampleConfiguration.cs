//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using SerialTemplate;

namespace SerialTemplate
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "Serial Control";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title="Connect", ClassType=typeof(SerialConnectDisconnectPage)},
            new Scenario() { Title="Control", ClassType=typeof(SerialDeviceControlPage)},
            new Scenario() { Title="Firmware", ClassType=typeof(SerialFirmware)}
        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}
