using UnityEngine;

namespace Runner.Renderer
{
    // Interface for coin detector components
    public interface ICoinDetector
    {
        Vector3 Position { get; }  // Detector position
    }
}