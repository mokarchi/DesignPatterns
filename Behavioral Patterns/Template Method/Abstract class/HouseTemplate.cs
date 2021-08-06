using System;

namespace Template
{
    public abstract class HouseTemplate
    {
        // Template method defines the sequence for building a house
        public void BuildHouse()
        {
            BuildFoundation();
            BuildPillars();
            BuildWalls();
            BuildWindows();
            Console.WriteLine("House is built");
        }
        // Methods to be implemented by subclasses
        protected abstract void BuildFoundation();
        protected abstract void BuildPillars();
        protected abstract void BuildWalls();
        protected abstract void BuildWindows();
    }
}
