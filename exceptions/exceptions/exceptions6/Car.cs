using System;
using System.Collections.Generic;
using System.Text;

namespace exceptions6
{
    class Car
    {
        public string Model { get; set; }
        private int Speed { get; set; }
        private int MaxSpeed { get; set; }

        public Car(string model, int speed, int maxSpeed)
        {
            this.Model = model;

            if (speed < 0 || maxSpeed < 0)
            {
                throw new NegativeSpeedException();
            }

            if (speed > maxSpeed)
            {
                var exception = new GoingTooFastException(speed, maxSpeed);
                exception.HelpLink = "www.visma.lv";

                throw exception;
            }
        }
    }
}
