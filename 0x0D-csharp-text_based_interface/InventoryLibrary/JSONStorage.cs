using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventoryLibrary
{
    /// <summary>
    /// Class that manages all serialization and deserialization
    /// </summary>
    public class JSONStorage
    {
        /// <summary>
        /// Dictionary of all objects
        /// </summary>
        /// <value> Storage through JSON </value>
        public Dictionary<string, object> objects = new Dictionary<string, object>();

        /// <summary>
        /// Get all objects
        /// </summary>
        /// <returns> Objects dictionary </returns>
        public Dictionary<string, object> All()
        {
            return this.objects;
        }

        /// <summary>
        /// Adds new key-value pair to dictionary
        /// </summary>
        /// <param name="obj"> Object to add </param>
        public void New(BaseClass obj)
        {
            if (obj != null)
            {
                this.objects.Add(obj.GetType().Name + "." + obj.id, obj);
            }
        }

        /// <summary>
        /// Saves dictionary to the file in storage
        /// </summary>
        public void Save()
        {
            string JSONString = JsonConvert.SerializeObject(objects);
            string JSONFile = @"../storage/inventory_manager.json";
            File.WriteAllText(JSONFile, JSONString);
        }

        /// <summary>
        /// Object creation from json file
        /// </summary>
        public void Load()
        {
            string JSONFile = @"../storage/inventory_manager.json";
            string JSONString = File.ReadAllText(JSONFile);
            if (JSONString == null || JSONString == "")
                return;
            
            this.objects = JsonConvert.DeserializeObject<Dictionary<string, object>>(JSONString);
        }
    }
}