using UnityEngine;
using OPS.AntiCheat.Detector;
using System;
using System.Threading;
using OPS.AntiCheat;
using System.Windows.Forms;
using ExitGames.Demos.DemoPunVoice;
using UnityEngine.InputSystem;
using System.IO;
using System.Collections.Generic;

namespace YEP
{
    public class Cheat : MonoBehaviour
    {
        #region Standard Unity methods
        // Runs once.
        private void Start()
        {
            Utils.CreateConsole();


            {
                /* Player Stats
                 * Change the number 50 in myTotalExp and totalExp to the number you want for your level
                 * Change PlayersMoney to what you want
                 * Change Item Amounts Like The Example Below
                 * FileBasedPrefs.SetInt("EMFReaderInventory", 10);
                */
                FileBasedPrefs.SetInt("myTotalExp", 50 * 100);
                FileBasedPrefs.SetInt("totalExp", 50 * 100);
                FileBasedPrefs.SetInt("PlayersMoney", 50000);
                FileBasedPrefs.SetInt("completedTraining", 1);
                FileBasedPrefs.SetInt("PlayerDied", 0);
                
                // Items
                FileBasedPrefs.SetInt("EMFReaderInventory", int.MaxValue);
                FileBasedPrefs.SetInt("FlashlightInventory", int.MaxValue);
                FileBasedPrefs.SetInt("CameraInventory", int.MaxValue);
                FileBasedPrefs.SetInt("LighterInventory", int.MaxValue);
                FileBasedPrefs.SetInt("CandleInventory", int.MaxValue);
                FileBasedPrefs.SetInt("UVFlashlightInventory", int.MaxValue);
                FileBasedPrefs.SetInt("CrucifixInventory", int.MaxValue);
                FileBasedPrefs.SetInt("DSLRCameraInventory", int.MaxValue);
                FileBasedPrefs.SetInt("EVPRecorderInventory", int.MaxValue);
                FileBasedPrefs.SetInt("SaltInventory", int.MaxValue);
                FileBasedPrefs.SetInt("TripodInventory", int.MaxValue);
                FileBasedPrefs.SetInt("StrongFlashlightInventory", int.MaxValue);
                FileBasedPrefs.SetInt("MotionSensorInventory", int.MaxValue);
                FileBasedPrefs.SetInt("SoundSensorInventory", int.MaxValue);
                FileBasedPrefs.SetInt("SanityPillsInventory", int.MaxValue);
                FileBasedPrefs.SetInt("ThermometerInventory", int.MaxValue);
                FileBasedPrefs.SetInt("GhostWritingBookInventory", int.MaxValue);
                FileBasedPrefs.SetInt("IRLightSensorInventory", int.MaxValue);
                FileBasedPrefs.SetInt("ParabolicMicrophoneInventory", int.MaxValue);
                FileBasedPrefs.SetInt("IRLightSensorInventory", int.MaxValue);
                FileBasedPrefs.SetInt("ParabolicMicrophoneInventory", int.MaxValue);
                FileBasedPrefs.SetInt("GlowstickInventory", int.MaxValue);
                FileBasedPrefs.SetInt("HeadMountedCameraInventory", int.MaxValue);
                FileBasedPrefs.SetInt("SmudgeSticksInventory", int.MaxValue);
            }

            Console.WriteLine("YEP Cock");
        }
        #endregion

        private Player MyPlayer => GameController.instance.myPlayer.player;

        private List<PlayerData> Players => GameController.instance.playersData;

    }
}
