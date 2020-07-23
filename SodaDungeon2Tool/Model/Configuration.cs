﻿using Newtonsoft.Json;
using System.ComponentModel;

namespace SodaDungeon2Tool.Model
{
    /// <summary>
    /// Store the current User Configuration
    /// </summary>
    public class Configuration
    {
        [DefaultValue(60)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public int sleepTimerInSeconds = 60;

        [DefaultValue(true)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool notifyOnFinish = true;

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool shutdownOnFinish = false;

        [DefaultValue(3)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public int numberOfNotifications = 3;

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool saveLastScreenshot = false;

        [DefaultValue("Default")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public string notificationSoundFileLocation = "Default";

        [DefaultValue(50)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public int notificationSoundVolume = 50;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Configuration()
        {
        }

        /// <summary>
        /// Contructor for loading the local Json file
        /// </summary>
        [JsonConstructor]
        public Configuration(int sleepTimerInSeconds, bool notifyOnFinish, bool shutdownOnFinish, int numberOfNotifications, bool saveLastScreenshot, string soundFileLocation, int notificationSoundVolume)
        {
            this.sleepTimerInSeconds = sleepTimerInSeconds;
            this.notifyOnFinish = notifyOnFinish;
            this.shutdownOnFinish = shutdownOnFinish;
            this.numberOfNotifications = numberOfNotifications;
            this.saveLastScreenshot = saveLastScreenshot;
            this.notificationSoundFileLocation = soundFileLocation;
            this.notificationSoundVolume = notificationSoundVolume;
        }
    }
}