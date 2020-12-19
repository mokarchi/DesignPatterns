using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.restaurant
{
    /// <summary>
    /// The FlyweightFactory class
    /// </summary>
    class SliderFactory
    {
        private Dictionary<char, Slider> _sliders =
            new Dictionary<char, Slider>();

        public Slider GetSlider(char key)
        {
            Slider slider = null;

            //If we've already created one of the 
            //requested type of slider, just use that.
            if (_sliders.ContainsKey(key))
            {
                slider = _sliders[key];
            }
            else //Otherwise, create a brand new instance of the slider.
            {
                switch (key)
                {
                    case 'B': slider = new BaconMaster(); break;
                    case 'V': slider = new VeggieSlider(); break;
                    case 'Q': slider = new BBQKing(); break;
                }
                _sliders.Add(key, slider);
            }
            return slider;
        }
    }
}
