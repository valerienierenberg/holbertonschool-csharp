using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

/// <summary>
/// class JSONStorage
/// </summary>
class JSONStorage
{
    public Dictionary<string, BaseClass> objects;
    /// <summary>
    /// Return all objects
    /// </summary>
    /// <returns></returns>
    public Dictionary<string, BaseClass> All()
    {
        return objects;
    }

    /// <summary>
    /// New method - add a new key-value pair to objects
    /// </summary>
    /// <param name="obj"></param>
    public void New(BaseClass obj)
    {
        string kvPair;
        kvPair = String.Format("{0}:{1}", obj.GetType().Name, obj.id);
        this.objects.Add(kvPair, obj);
    }

    /// <summary>
    /// Save method - serializes objects to JSON and saves to the JSON file
    /// </summary>
    public void Save()
    {
        File.WriteAllText("storage/inventory_manager.json", JsonSerializer.Serialize(objects));
    }

    /// <summary>
    /// Load method - deserializes JSON file to objects
    /// </summary>
    public void Load()
    {
        objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(File.ReadAllText("storage/inventory_manager.json"));
    }
}
