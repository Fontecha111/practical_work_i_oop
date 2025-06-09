using System;

namespace practicalwork
{
    public class PassengerTrain : Train
    {
        private int numberOfCarriages;
        private int capacity;

        public PassengerTrain(string ID, int arrivalTime, string type, int numberOfCarriages, int capacity) : base(ID, arrivalTime, type)
        {
            this.numberOfCarriages = numberOfCarriages;
            this.capacity = capacity;
        }

        public int getNumberOfCarriages()
        {
            return this.numberOfCarriages;
        }

        public int getCapacity()
        {
            return this.capacity;
        }

        public override string ShowInfo()
        {
            return $"Passenger Train ID: {ID}, Status: {status}, Arrival Time: {arrivalTime}, Carriages: {numberOfCarriages}, Capacity: {capacity}";
        }
    }
}