using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_19_1 {
    internal class Television {
        private string brand, model;
        private int maxChannels, minVolume, maxVolume, volume, channel;
        private bool isColored, isOn;

        public Television(string brand, string model, bool isColored) { 
            this.brand = brand;
            this.model = model;
            this.isColored = isColored;
            maxChannels = 100;
            minVolume = 0;
            maxVolume = 50;
        }

        public Television(string brand, string model, bool isColored, int maxChannels, int minVolume, int maxVolume) { 
            this.model= model;
            this.brand = brand;
            this.isColored = isColored;
            this.maxChannels = maxChannels; 
            this.minVolume = minVolume; 
            this.maxVolume = maxVolume; 
        }

        /// <summary>
        /// Turns the TV on (attribute isOn is set to true).
        /// </summary>
        public void turnOn() {
            isOn = true;
        }
        
        /// <summary>
        /// Turns the TV off (attribute isOn is set to false).
        /// </summary>
        public void turnOff() {
            isOn = false;
        }

        /// <summary>
        /// Raises the volume by 1 unit.
        /// </summary>
        public void raiseVolume() {
            if (isOn && volume < maxVolume) volume++;
        }

        /// <summary>
        /// Raises the volume by a certain amount.
        /// </summary>
        /// <param name="volume">The amount the volume is raised by.</param>
        public void raiseVolume(int volume) {
            if (isOn && this.volume <= maxVolume - volume) this.volume += volume;
            else if (isOn && this.volume > maxVolume - volume) this.volume = maxVolume;
        }

        /// <summary>
        /// Lowers the volume by 1 unit.
        /// </summary>
        public void lowerVolume() {
            if (isOn && volume > minVolume) volume--;
        }

        /// <summary>
        /// Lowers the volume by a certain amount.
        /// </summary>
        /// <param name="volume">The amount the volume is lowered by.</param>
        public void lowerVolume(int volume) {
            if (isOn && this.volume >= minVolume + volume) this.volume -= volume;
            else if (isOn && this.volume > maxVolume + volume) this.volume = minVolume;
        }

        /// <summary>
        /// Increases the channel by 1 unit.
        /// </summary>
        public void increaseChannel() {
            if (isOn && channel < maxChannels) channel++;
        }

        /// <summary>
        /// Decreases the channel by 1 unit.
        /// </summary>
        public void decreaseChannel() {
            if (isOn && channel > 0) channel--;
        }

        /// <summary>
        /// Returns the state of the TV.
        /// </summary>
        /// <returns>True if the TV is on, false otherwise.</returns>
        public bool getState() {
            return isOn;
        }

        /// <summary>
        /// Returns the current channel the TV is on.
        /// </summary>
        /// <returns></returns>
        public int getChannel() { 
            return channel; 
        }
        
        /// <summary>
        /// Returns the current volume the TV is on.
        /// </summary>
        /// <returns></returns>
        public int getVolume() {
            return volume;
        }

        /// <summary>
        /// Stringyfies the TV's information.
        /// </summary>
        /// <returns>All the attributes of the TV as a string.</returns>
        public string getInfo() {
            return $"Brand: {brand}\nModel: {model}\nOn/Off: {(isOn ? "On" : "Off")}\nMinimum Volume: {minVolume}\nMaximum Volume: {maxVolume}\nVolume: {volume}\nMaximum Channel: {maxChannels}\nChannel: {channel}\nColored: {(isColored ? "Yes" : "No")}";
        }

        /// <summary>
        /// Copies the information from another TV.
        /// </summary>
        /// <param name="television">The TV the information will be copied from.</param>
        public void copyInfo(Television television) {
            brand = television.brand;
            model = television.model;
            isColored = television.isColored;
            maxChannels = television.maxChannels;
            minVolume = television.minVolume;
            maxVolume = television.maxVolume;
        }

    }
}
