using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary
{
    class JSONStorage
    {
        // Properties:
        // objects - dictionary where keys are<ClassName>.<id> and values are the objects
        // Methods:
        // All() - return objects dictionary
        // New(obj) - add a new key-value pair to objects
        // Key: <obj ClassName>.<obj id>
        // Value: obj
        // Save() - serializes objects to JSON and saves to the JSON file
        // Load() - deserializes JSON file to objects
    }
}
